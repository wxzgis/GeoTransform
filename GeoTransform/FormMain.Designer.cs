namespace GeoTransform
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_shp2json_go = new System.Windows.Forms.Button();
            this.btn_shp2json_output = new System.Windows.Forms.Button();
            this.tbx_shp2json_output = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_shp2json_input = new System.Windows.Forms.Button();
            this.tbx_shp2json_input = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_json2shp_go = new System.Windows.Forms.Button();
            this.btn_json2shp_output = new System.Windows.Forms.Button();
            this.tbx_json2shp_output = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_json2shp_input = new System.Windows.Forms.Button();
            this.tbx_json2shp_input = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(355, 167);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(347, 141);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shapefile to GeoJSON";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_shp2json_go);
            this.groupBox2.Controls.Add(this.btn_shp2json_output);
            this.groupBox2.Controls.Add(this.tbx_shp2json_output);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(2, 68);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(343, 69);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据输出";
            // 
            // btn_shp2json_go
            // 
            this.btn_shp2json_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shp2json_go.Location = new System.Drawing.Point(289, 46);
            this.btn_shp2json_go.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shp2json_go.Name = "btn_shp2json_go";
            this.btn_shp2json_go.Size = new System.Drawing.Size(50, 23);
            this.btn_shp2json_go.TabIndex = 2;
            this.btn_shp2json_go.Text = "执行";
            this.btn_shp2json_go.UseVisualStyleBackColor = true;
            this.btn_shp2json_go.Click += new System.EventHandler(this.Button_Go_Click);
            // 
            // btn_shp2json_output
            // 
            this.btn_shp2json_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shp2json_output.Location = new System.Drawing.Point(289, 18);
            this.btn_shp2json_output.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shp2json_output.Name = "btn_shp2json_output";
            this.btn_shp2json_output.Size = new System.Drawing.Size(50, 21);
            this.btn_shp2json_output.TabIndex = 1;
            this.btn_shp2json_output.Text = "浏览";
            this.btn_shp2json_output.UseVisualStyleBackColor = true;
            this.btn_shp2json_output.Click += new System.EventHandler(this.Button_Output_Click);
            // 
            // tbx_shp2json_output
            // 
            this.tbx_shp2json_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_shp2json_output.Location = new System.Drawing.Point(4, 18);
            this.tbx_shp2json_output.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_shp2json_output.Name = "tbx_shp2json_output";
            this.tbx_shp2json_output.Size = new System.Drawing.Size(282, 21);
            this.tbx_shp2json_output.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_shp2json_input);
            this.groupBox1.Controls.Add(this.tbx_shp2json_input);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(343, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据输入";
            // 
            // btn_shp2json_input
            // 
            this.btn_shp2json_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_shp2json_input.Location = new System.Drawing.Point(289, 18);
            this.btn_shp2json_input.Margin = new System.Windows.Forms.Padding(2);
            this.btn_shp2json_input.Name = "btn_shp2json_input";
            this.btn_shp2json_input.Size = new System.Drawing.Size(50, 21);
            this.btn_shp2json_input.TabIndex = 1;
            this.btn_shp2json_input.Text = "浏览";
            this.btn_shp2json_input.UseVisualStyleBackColor = true;
            this.btn_shp2json_input.Click += new System.EventHandler(this.Button_Input_Click);
            // 
            // tbx_shp2json_input
            // 
            this.tbx_shp2json_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_shp2json_input.Location = new System.Drawing.Point(4, 18);
            this.tbx_shp2json_input.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_shp2json_input.Name = "tbx_shp2json_input";
            this.tbx_shp2json_input.Size = new System.Drawing.Size(282, 21);
            this.tbx_shp2json_input.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(347, 141);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "GeoJSON to Shapefile";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_json2shp_go);
            this.groupBox3.Controls.Add(this.btn_json2shp_output);
            this.groupBox3.Controls.Add(this.tbx_json2shp_output);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox3.Location = new System.Drawing.Point(2, 68);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(343, 69);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "数据输出";
            // 
            // btn_json2shp_go
            // 
            this.btn_json2shp_go.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_json2shp_go.Location = new System.Drawing.Point(289, 46);
            this.btn_json2shp_go.Margin = new System.Windows.Forms.Padding(2);
            this.btn_json2shp_go.Name = "btn_json2shp_go";
            this.btn_json2shp_go.Size = new System.Drawing.Size(50, 23);
            this.btn_json2shp_go.TabIndex = 2;
            this.btn_json2shp_go.Text = "执行";
            this.btn_json2shp_go.UseVisualStyleBackColor = true;
            this.btn_json2shp_go.Click += new System.EventHandler(this.Button_Go_Click);
            // 
            // btn_json2shp_output
            // 
            this.btn_json2shp_output.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_json2shp_output.Location = new System.Drawing.Point(289, 18);
            this.btn_json2shp_output.Margin = new System.Windows.Forms.Padding(2);
            this.btn_json2shp_output.Name = "btn_json2shp_output";
            this.btn_json2shp_output.Size = new System.Drawing.Size(50, 21);
            this.btn_json2shp_output.TabIndex = 1;
            this.btn_json2shp_output.Text = "浏览";
            this.btn_json2shp_output.UseVisualStyleBackColor = true;
            this.btn_json2shp_output.Click += new System.EventHandler(this.Button_Output_Click);
            // 
            // tbx_json2shp_output
            // 
            this.tbx_json2shp_output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_json2shp_output.Location = new System.Drawing.Point(4, 18);
            this.tbx_json2shp_output.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_json2shp_output.Name = "tbx_json2shp_output";
            this.tbx_json2shp_output.Size = new System.Drawing.Size(282, 21);
            this.tbx_json2shp_output.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_json2shp_input);
            this.groupBox4.Controls.Add(this.tbx_json2shp_input);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(2, 2);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(343, 66);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "数据输入";
            // 
            // btn_json2shp_input
            // 
            this.btn_json2shp_input.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_json2shp_input.Location = new System.Drawing.Point(289, 18);
            this.btn_json2shp_input.Margin = new System.Windows.Forms.Padding(2);
            this.btn_json2shp_input.Name = "btn_json2shp_input";
            this.btn_json2shp_input.Size = new System.Drawing.Size(50, 21);
            this.btn_json2shp_input.TabIndex = 1;
            this.btn_json2shp_input.Text = "浏览";
            this.btn_json2shp_input.UseVisualStyleBackColor = true;
            this.btn_json2shp_input.Click += new System.EventHandler(this.Button_Input_Click);
            // 
            // tbx_json2shp_input
            // 
            this.tbx_json2shp_input.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbx_json2shp_input.Location = new System.Drawing.Point(4, 18);
            this.tbx_json2shp_input.Margin = new System.Windows.Forms.Padding(2);
            this.tbx_json2shp_input.Name = "tbx_json2shp_input";
            this.tbx_json2shp_input.Size = new System.Drawing.Size(282, 21);
            this.tbx_json2shp_input.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 167);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "地理空间数据格式转换";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_shp2json_input;
        private System.Windows.Forms.TextBox tbx_shp2json_input;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_shp2json_output;
        private System.Windows.Forms.TextBox tbx_shp2json_output;
        private System.Windows.Forms.Button btn_shp2json_go;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_json2shp_go;
        private System.Windows.Forms.Button btn_json2shp_output;
        private System.Windows.Forms.TextBox tbx_json2shp_output;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_json2shp_input;
        private System.Windows.Forms.TextBox tbx_json2shp_input;
    }
}

