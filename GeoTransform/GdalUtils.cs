using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DataSource = OSGeo.OGR.DataSource;
using Driver = OSGeo.OGR.Driver;
using Ogr = OSGeo.OGR.Ogr;
using File = System.IO.File;

namespace GeoTransform
{
    class GdalUtils
    {
        public static void InitGDAL()
        {
            GdalConfiguration.ConfigureGdal();
            GdalConfiguration.ConfigureOgr();
            OSGeo.GDAL.Gdal.AllRegister();
            OSGeo.GDAL.Gdal.SetConfigOption("GDAL_FILENAME_IS_UTF8", "YES");
            OSGeo.GDAL.Gdal.SetConfigOption("SHAPE_ENCODING", "");
        }

        /// <summary>
        /// Shapefile 转 GeoJSON
        /// </summary>
        /// <param name="shp_path">Shapefile文件路径（.shp）</param>
        /// <param name="output_path">输出GeoJSON文件路径</param>
        /// <returns>转换成功，返回true；转换失败，返回false</returns>
        public static string Shp2GeoJSON(string shp_path, string output_path)
        {
            DataSource ds = Ogr.Open(shp_path, 0);
            if (ds == null) return "数据源加载失败";
            Driver dr = Ogr.GetDriverByName("GeoJSON");
            if (dr == null) return "数据驱动加载失败";
            dr.CopyDataSource(ds, output_path, null);
            dr.Deregister();
            dr.Dispose();
            ds.Dispose();
            OSGeo.GDAL.Gdal.GDALDestroyDriverManager();
            return "Shapefile 转 GeoJSON 成功";
        }

        /// <summary>
        /// GeoJSON 转 Shapefile
        /// </summary>
        /// <param name="geojson_path">GeoJSON文件路径</param>
        /// <param name="output_path">输出Shapefile文件路径（.shp）</param>
        /// <returns>转换成功，返回true；转换失败，返回false</returns>
        public static string GeoJSON2Shp(string geojson_path, string output_path)
        {
            DataSource ds = Ogr.Open(geojson_path, 0);
            if (ds == null) return "数据源加载失败";
            Driver dr = Ogr.GetDriverByName("ESRI Shapefile");
            if (dr == null) return "数据驱动加载失败";
            if (File.Exists(output_path)) dr.DeleteDataSource(output_path);
            dr.CopyDataSource(ds, output_path, null);
            dr.Deregister();
            dr.Dispose();
            ds.Dispose();
            OSGeo.GDAL.Gdal.GDALDestroyDriverManager();
            return "GeoJSON 转 Shapefile 成功";
        }
    }
}
