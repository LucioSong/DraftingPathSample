namespace DraftingPathSample
{
    partial class SelectionFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBox_rotate = new System.Windows.Forms.ComboBox();
            this.comboBox_trans = new System.Windows.Forms.ComboBox();
            this.button_rotate = new System.Windows.Forms.Button();
            this.button_trans = new System.Windows.Forms.Button();
            this.numericUpDown_trans = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_rotate = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rotate)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.comboBox_rotate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_trans, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_rotate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_trans, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_trans, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown_rotate, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 69);
            this.tableLayoutPanel1.TabIndex = 0;
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
            this.comboBox_rotate.Location = new System.Drawing.Point(3, 37);
            this.comboBox_rotate.Name = "comboBox_rotate";
            this.comboBox_rotate.Size = new System.Drawing.Size(99, 20);
            this.comboBox_rotate.TabIndex = 8;
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
            this.comboBox_trans.Size = new System.Drawing.Size(99, 20);
            this.comboBox_trans.TabIndex = 7;
            // 
            // button_rotate
            // 
            this.button_rotate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rotate.Location = new System.Drawing.Point(213, 37);
            this.button_rotate.Name = "button_rotate";
            this.button_rotate.Size = new System.Drawing.Size(101, 29);
            this.button_rotate.TabIndex = 6;
            this.button_rotate.Text = "Rotate";
            this.button_rotate.UseVisualStyleBackColor = true;
            this.button_rotate.Click += new System.EventHandler(this.button_rotate_Click);
            // 
            // button_trans
            // 
            this.button_trans.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_trans.Location = new System.Drawing.Point(213, 3);
            this.button_trans.Name = "button_trans";
            this.button_trans.Size = new System.Drawing.Size(101, 28);
            this.button_trans.TabIndex = 5;
            this.button_trans.Text = "Translate";
            this.button_trans.UseVisualStyleBackColor = true;
            this.button_trans.Click += new System.EventHandler(this.button_trans_Click);
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
            this.numericUpDown_trans.Location = new System.Drawing.Point(108, 3);
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
            this.numericUpDown_trans.Size = new System.Drawing.Size(99, 21);
            this.numericUpDown_trans.TabIndex = 3;
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
            this.numericUpDown_rotate.Location = new System.Drawing.Point(108, 37);
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
            this.numericUpDown_rotate.Size = new System.Drawing.Size(99, 21);
            this.numericUpDown_rotate.TabIndex = 4;
            // 
            // SelectionFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 93);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SelectionFunction";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Selection Function";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectionFunction_FormClosing);
            this.Load += new System.EventHandler(this.SelectionFunction_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_rotate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown numericUpDown_trans;
        private System.Windows.Forms.NumericUpDown numericUpDown_rotate;
        private System.Windows.Forms.Button button_trans;
        private System.Windows.Forms.Button button_rotate;
        private System.Windows.Forms.ComboBox comboBox_trans;
        private System.Windows.Forms.ComboBox comboBox_rotate;
    }
}