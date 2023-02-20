namespace DraftingPathSample
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.propertyGrid2 = new System.Windows.Forms.PropertyGrid();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_trans = new System.Windows.Forms.ComboBox();
            this.comboBox_rotate = new System.Windows.Forms.ComboBox();
            this.numericUpDown_trans = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_rotate = new System.Windows.Forms.NumericUpDown();
            this.button_trans = new System.Windows.Forms.Button();
            this.button_rotate = new System.Windows.Forms.Button();
            this.button_add_text = new System.Windows.Forms.Button();
            this.button_get_path = new System.Windows.Forms.Button();
            this.button_import_dxf_dwg = new System.Windows.Forms.Button();
            this.button_get_sel_minmax = new System.Windows.Forms.Button();
            this.button_test = new System.Windows.Forms.Button();
            this.button_sel_func = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rotate)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(12, 42);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1060, 778);
            this.splitContainer1.SplitterDistance = 742;
            this.splitContainer1.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 774);
            this.panel1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.propertyGrid1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Size = new System.Drawing.Size(310, 774);
            this.splitContainer2.SplitterDistance = 400;
            this.splitContainer2.TabIndex = 3;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(308, 398);
            this.propertyGrid1.TabIndex = 2;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.propertyGrid2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer3.Size = new System.Drawing.Size(308, 368);
            this.splitContainer3.SplitterDistance = 300;
            this.splitContainer3.TabIndex = 7;
            // 
            // propertyGrid2
            // 
            this.propertyGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid2.Location = new System.Drawing.Point(0, 0);
            this.propertyGrid2.Name = "propertyGrid2";
            this.propertyGrid2.Size = new System.Drawing.Size(308, 300);
            this.propertyGrid2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_trans, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_rotate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_trans, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_rotate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_trans, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_rotate, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(302, 58);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // comboBox_trans
            // 
            this.comboBox_trans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_trans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_trans.FormattingEnabled = true;
            this.comboBox_trans.Items.AddRange(new object[] {
            "Translate X",
            "Translate Y",
            "Translate Z"});
            this.comboBox_trans.Location = new System.Drawing.Point(3, 3);
            this.comboBox_trans.Name = "comboBox_trans";
            this.comboBox_trans.Size = new System.Drawing.Size(97, 20);
            this.comboBox_trans.TabIndex = 0;
            // 
            // comboBox_rotate
            // 
            this.comboBox_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_rotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_rotate.FormattingEnabled = true;
            this.comboBox_rotate.Items.AddRange(new object[] {
            "Rotate X",
            "Rotate Y",
            "Rotate Z"});
            this.comboBox_rotate.Location = new System.Drawing.Point(3, 32);
            this.comboBox_rotate.Name = "comboBox_rotate";
            this.comboBox_rotate.Size = new System.Drawing.Size(97, 20);
            this.comboBox_rotate.TabIndex = 1;
            // 
            // numericUpDown_trans
            // 
            this.numericUpDown_trans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_trans.DecimalPlaces = 2;
            this.numericUpDown_trans.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_trans.Location = new System.Drawing.Point(106, 3);
            this.numericUpDown_trans.Maximum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            0});
            this.numericUpDown_trans.Minimum = new decimal(new int[] {
            -1530494977,
            232830,
            0,
            -2147483648});
            this.numericUpDown_trans.Name = "numericUpDown_trans";
            this.numericUpDown_trans.Size = new System.Drawing.Size(97, 21);
            this.numericUpDown_trans.TabIndex = 2;
            // 
            // numericUpDown_rotate
            // 
            this.numericUpDown_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_rotate.DecimalPlaces = 2;
            this.numericUpDown_rotate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown_rotate.Location = new System.Drawing.Point(106, 32);
            this.numericUpDown_rotate.Maximum = new decimal(new int[] {
            35999,
            0,
            0,
            131072});
            this.numericUpDown_rotate.Minimum = new decimal(new int[] {
            35999,
            0,
            0,
            -2147352576});
            this.numericUpDown_rotate.Name = "numericUpDown_rotate";
            this.numericUpDown_rotate.Size = new System.Drawing.Size(97, 21);
            this.numericUpDown_rotate.TabIndex = 3;
            // 
            // button_trans
            // 
            this.button_trans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_trans.Location = new System.Drawing.Point(209, 3);
            this.button_trans.Name = "button_trans";
            this.button_trans.Size = new System.Drawing.Size(90, 23);
            this.button_trans.TabIndex = 4;
            this.button_trans.Text = "Translate";
            this.button_trans.UseVisualStyleBackColor = true;
            this.button_trans.Click += new System.EventHandler(this.button_trans_Click);
            // 
            // button_rotate
            // 
            this.button_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rotate.Location = new System.Drawing.Point(209, 32);
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.Size = new System.Drawing.Size(90, 23);
            this.button_rotate.TabIndex = 5;
            this.button_rotate.Text = "Rotate";
            this.button_rotate.UseVisualStyleBackColor = true;
            this.button_rotate.Click += new System.EventHandler(this.button_rotate_Click);
            // 
            // button_add_text
            // 
            this.button_add_text.Location = new System.Drawing.Point(13, 13);
            this.button_add_text.Name = "button_add_text";
            this.button_add_text.Size = new System.Drawing.Size(75, 23);
            this.button_add_text.TabIndex = 5;
            this.button_add_text.Text = "Add Text";
            this.button_add_text.UseVisualStyleBackColor = true;
            this.button_add_text.Click += new System.EventHandler(this.button_add_text_Click);
            // 
            // button_get_path
            // 
            this.button_get_path.Location = new System.Drawing.Point(95, 13);
            this.button_get_path.Name = "button_get_path";
            this.button_get_path.Size = new System.Drawing.Size(80, 23);
            this.button_get_path.TabIndex = 6;
            this.button_get_path.Text = "Get Path all";
            this.button_get_path.UseVisualStyleBackColor = true;
            this.button_get_path.Click += new System.EventHandler(this.button_get_path_Click);
            // 
            // button_import_dxf_dwg
            // 
            this.button_import_dxf_dwg.Location = new System.Drawing.Point(181, 13);
            this.button_import_dxf_dwg.Name = "button_import_dxf_dwg";
            this.button_import_dxf_dwg.Size = new System.Drawing.Size(105, 23);
            this.button_import_dxf_dwg.TabIndex = 7;
            this.button_import_dxf_dwg.Text = "Import Dxf, Dwg";
            this.button_import_dxf_dwg.UseVisualStyleBackColor = true;
            this.button_import_dxf_dwg.Click += new System.EventHandler(this.button_import_dxf_dwg_Click);
            // 
            // button_get_sel_minmax
            // 
            this.button_get_sel_minmax.Location = new System.Drawing.Point(292, 13);
            this.button_get_sel_minmax.Name = "button_get_sel_minmax";
            this.button_get_sel_minmax.Size = new System.Drawing.Size(120, 23);
            this.button_get_sel_minmax.TabIndex = 8;
            this.button_get_sel_minmax.Text = "Selection min max";
            this.button_get_sel_minmax.UseVisualStyleBackColor = true;
            this.button_get_sel_minmax.Click += new System.EventHandler(this.button_get_sel_minmax_Click);
            // 
            // button_test
            // 
            this.button_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_test.Location = new System.Drawing.Point(13, 826);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(75, 23);
            this.button_test.TabIndex = 9;
            this.button_test.Text = "Test";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // button_sel_func
            // 
            this.button_sel_func.Location = new System.Drawing.Point(418, 13);
            this.button_sel_func.Name = "button_sel_func";
            this.button_sel_func.Size = new System.Drawing.Size(118, 23);
            this.button_sel_func.TabIndex = 10;
            this.button_sel_func.Text = "Selection Function";
            this.button_sel_func.UseVisualStyleBackColor = true;
            this.button_sel_func.Click += new System.EventHandler(this.button_sel_func_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 861);
            this.Controls.Add(this.button_sel_func);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.button_get_sel_minmax);
            this.Controls.Add(this.button_import_dxf_dwg);
            this.Controls.Add(this.button_get_path);
            this.Controls.Add(this.button_add_text);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drafting path Sample";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rotate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.PropertyGrid propertyGrid1;
        private System.Windows.Forms.PropertyGrid propertyGrid2;
        private System.Windows.Forms.Button button_add_text;
        private System.Windows.Forms.Button button_get_path;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox_trans;
        private System.Windows.Forms.ComboBox comboBox_rotate;
        private System.Windows.Forms.NumericUpDown numericUpDown_trans;
        private System.Windows.Forms.NumericUpDown numericUpDown_rotate;
        private System.Windows.Forms.Button button_trans;
        private System.Windows.Forms.Button button_rotate;
        private System.Windows.Forms.Button button_import_dxf_dwg;
        private System.Windows.Forms.Button button_get_sel_minmax;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Button button_sel_func;
    }
}

