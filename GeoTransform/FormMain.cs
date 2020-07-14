using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GeoTransform
{
    public partial class FormMain : Form
    {
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
    }
}
