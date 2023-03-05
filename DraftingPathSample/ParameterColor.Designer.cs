namespace DraftingPathSample
{
    partial class ParameterColor
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
            this.comboBox_para_index = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_color = new System.Windows.Forms.Label();
            this.colorDialog_paraColor = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // comboBox_para_index
            // 
            this.comboBox_para_index.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_para_index.FormattingEnabled = true;
            this.comboBox_para_index.Location = new System.Drawing.Point(128, 20);
            this.comboBox_para_index.Name = "comboBox_para_index";
            this.comboBox_para_index.Size = new System.Drawing.Size(89, 20);
            this.comboBox_para_index.TabIndex = 0;
            this.comboBox_para_index.SelectedIndexChanged += new System.EventHandler(this.comboBox_para_index_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Parameter index : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Color : ";
            // 
            // label_color
            // 
            this.label_color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_color.Location = new System.Drawing.Point(128, 49);
            this.label_color.Name = "label_color";
            this.label_color.Size = new System.Drawing.Size(89, 20);
            this.label_color.TabIndex = 3;
            this.label_color.Click += new System.EventHandler(this.label_color_Click);
            // 
            // ParameterColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 81);
            this.Controls.Add(this.label_color);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_para_index);
            this.Name = "ParameterColor";
            this.ShowIcon = false;
            this.Text = "ParameterColor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ParameterColor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_para_index;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_color;
        private System.Windows.Forms.ColorDialog colorDialog_paraColor;
    }
}