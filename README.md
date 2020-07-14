# 使用C#和GDAL库创建GeoJSON和Shapefile文件互转程序

[TOC]

## 0 背景

### 0.0 Shapefile

​		`ESRI Shapefile`(shp)或简称`shapefile`，是ESRI开发的**空间数据开放格式**。目前，该文件格式已成为地理信息软件界的开放标准。

​		`Shapefile`属于一种**矢量**图形格式，能够保存**几何图形的位置即相关属性**，但无法存储地理数据的~~拓扑信息~~。

​		`Shapefile`作为一种比较原始的矢量数据存储方式，仅能存储几何图形的位置信息，而<u>无法在同一文件之中同时存储这些几何体的属性数据</u>，因此必须附带一个二维表用于存储`Shapefile`中每个几何要素的信属性信息。

​		`Shapefile`文件指的是一种文件存储方法，实际上这种文件格式是由*多个文件*组成的。其中组成一个`Shapefile`有3个文件必不可少，它们分别是：

​				●  *.shp 	→	图形格式，用于保存要素的几何实体

​				●  *.shx 	→	图形索引格式，几何体位置索引，记录每个几何体在shp文件中的位置，加快几何检索效率

​				●  *.dbf 	→	属性数据格式，以dBase的数据格式存储每个几何形状属性数据

表示同一数据的一组文件其**文件名前缀相同**。其中，“真正”的`Shapefile`的后缀是shp，然而仅有这个文件数据是*不完整*的，必须把其他两个附带上才能构成一组完整的地理数据。除了这三个必须的文件以外，还有可选文件：

​				●  *.prj 	→	投帧式，用于保存地理坐标系统与投影信息，是一个存储投影描述符的文本文件

​				●  *.sbn & *.sbx 	→	几何体的空间索引

​				●  *.fbn & *.fbx 	→	只读的Shapefiles的几何体的空间索引

​				●  *.ain & *.aih 	→	列表中活动字段的属性索引

​				●  *.ixs 	→	可读写Shapefile文件的地理编码索引

​				●  *.mxs 	→	可读写Shapefile文件的地理编码索引（ODB格式）

​				●  *.atx 	→	.dbf文件的属性索引

​				●  *.shp.xml 	→	以xml保存的元数据

​				●  *.cpg 	→	用于描述.dbf文件的代码页，指明其使用的字符编码

使用它们可以增强空间数据的表达能力。值得注意的是，**所有的文件都必须位于用一个目录之中**。

​		对于一个`Shapefile`来所，其.shp或.dbf文件最大的体积不能超过2GB。

### 0.1 GeoJSON

​		`GeoJSON`是一种基于JSON（**JavaScript对象表达法**）的地理空间数据交换格式，它定义了集中类型的JSON对象及其它们组合在一起的方法，以表示有关地理要素、属性和它们的空间范围的数据。

### 0.2 Shapefile和GeoJSON的区别与关系

​		`GeoJSON`与ESRI的`Shapefile`相比更加小巧简单。GeoJSON仅用一个文件（*.json）就能实现地理空间数据的存储，在网络传输方面要优于`Shapefile`。

## 1 程序设计

### 1.0 技术使用

- 开发语言：C#
- 开发工具：VS2019
- 开发类库：GDAL、DevExpress

### 1.1 在C#开发中GDAL的配置

​		在VS项目中打开**“管理NuGet程序包...”**界面，并使用关键字<u>gdal</u>检索，在结果中选择**GDAL**和**GDAL.Native**进行下载。下载完成后，在<u>解决方案资源管理器</u>的根目录下就会出现**GdalConfigure.cs**和**GdalConfigure.vb**两个文件。然后在<u>项目初始化阶段</u>或者<u>执行与GDAL库相关代码前</u>执行如下代码，即可使用GDAL。至此完成GDAL配置。

```c#
// 注册所有的驱动
GdalConfiguration.ConfigureGdal();
GdalConfiguration.ConfigureOgr();
OSGeo.GDAL.Gdal.AllRegister();

OSGeo.GDAL.Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES"); // 支持中文路径
OSGeo.GDAL.Gdal.SetConfigOption("SHAPE_ENCODING", ""); // 使属性表字段支持中文
```

![](https://wuxizheing.oss-cn-beijing.aliyuncs.com/images/20200714143147.png)

### 1.2 编写GeoJSON和Shapefile的互转方法

​		为了程序编写的规范化，将GeoJSON转Shapefile和Shapefile转GeoJSON的方法以**静态**的形式写入一个类体中，即**工具类**，名为`GdalUtils.cs`。

​		其中在文件头引入3个GDAL类，分别是`DataSource`、`Driver`和`Ogr`。

```c#
using DataSource = OSGeo.OGR.DataSource;
using Driver = OSGeo.OGR.Driver;
using Ogr = OSGeo.OGR.Ogr;
```

​		Shapefile转GeoJSON的方法：

```c#
/// <summary>
/// Shapefile 转 GeoJSON
/// </summary>
/// <param name="shp_path">Shapefile文件路径（.shp）</param>
/// <param name="output_path">输出GeoJSON文件路径</param>
/// <returns>转换成功，返回true；转换失败，返回false</returns>
public static bool Shp2GeoJSON(string shp_path, string output_path)
{
    DataSource ds = Ogr.Open(shp_path, 0);
    if (ds == null) return false;
    Driver dr = Ogr.GetDriverByName("GeoJSON");
    if (dr == null) return false;
    dr.CopyDataSource(ds, output_path, null);
    ds.Dispose(); dr.Dispose();
    return true;
}
```

​		GeoJSON转Shapefile方法：

```c#
/// <summary>
/// GeoJSON 转 Shapefile
/// </summary>
/// <param name="geojson_path">GeoJSON文件路径</param>
/// <param name="output_path">输出Shapefile文件路径（.shp）</param>
/// <returns>转换成功，返回true；转换失败，返回false</returns>
public static bool GeoJSON2Shp(string geojson_path, string output_path)
{
    DataSource ds = Ogr.Open(geojson_path, 0);
    if (ds == null) return false;
    Driver dr = Ogr.GetDriverByName("ESRI Shapefile");
    if (dr == null) return false;
    dr.CopyDataSource(ds, output_path, null);
    ds.Dispose();
    dr.Dispose();
    return true;
}
```

### 1.3 程序界面设计

<img src="https://wuxizheing.oss-cn-beijing.aliyuncs.com/images/20200714155332.png" style="zoom: 80%;" />

```c#
private string ENV_PATH;
public FormMain()
{
    InitializeComponent();
    string exe = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
    this.ENV_PATH = System.IO.Path.GetDirectoryName(exe);
    GdalUtils.InitGDAL();
}

private void GetPath(TextBox tbx, string filter)
{
    OpenFileDialog ofg = new OpenFileDialog() {
        Filter = filter,
        InitialDirectory = ENV_PATH
    };
    DialogResult result = ofg.ShowDialog();
    if(result == DialogResult.OK || result == DialogResult.Yes)
        tbx.Text = ofg.FileName;
    else
        tbx.Text = "";
}
private void Button_Input_Click(object sender, EventArgs e)
{
    if((Button)sender == btn_shp2json_input)
        GetPath(tbx_shp2json_input, "(*.shp)|*.shp");
    else if((Button)sender == btn_json2shp_input)
        GetPath(tbx_json2shp_input, "(*.json)|*.json");
}

private void SavePath(TextBox tbx, string filter)
{
    SaveFileDialog sfg = new SaveFileDialog()
    {
        Filter = filter,
        InitialDirectory = ENV_PATH
    };
    DialogResult result = sfg.ShowDialog();
    if (result == DialogResult.OK || result == DialogResult.Yes)
        tbx.Text = sfg.FileName;
    else
        tbx.Text = "";
}
private void Button_Output_Click(object sender, EventArgs e)
{
    if ((Button)sender == btn_shp2json_output)
        SavePath(tbx_shp2json_output, "(*.json)|*.json");
    else if ((Button)sender == btn_json2shp_output)
        SavePath(tbx_json2shp_output, "(*.shp)|*.shp");
}

private void Button_Go_Click(object sender, EventArgs e)
{
    string result = "";
    if ((Button)sender == btn_shp2json_go)
        result = GdalUtils.Shp2GeoJSON(tbx_shp2json_input.Text, tbx_shp2json_output.Text);
    else if ((Button)sender == btn_json2shp_go)
        result = GdalUtils.GeoJSON2Shp(tbx_json2shp_input.Text, tbx_json2shp_output.Text);
    MessageBox.Show(result);
    Application.ExitThread();
    System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
}
```

## 2 分享