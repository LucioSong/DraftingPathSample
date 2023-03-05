using DraftingPathComponent;
using System;
using System.Windows.Forms;

namespace DraftingPathSample
{
    public partial class ParameterColor : Form
    {
        DraftingViewport _viewport = null;
        public ParameterColor(DraftingViewport viewport)
        {
            InitializeComponent();

            _viewport = viewport;

            for (int i = 0; i < 100; i++)
            {
                comboBox_para_index.Items.Add(i.ToString());
            }

            comboBox_para_index.SelectedIndex = 0;
        }

        private void comboBox_para_index_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_para_index.SelectedIndex;
            if (index != -1)
            {
                label_color.BackColor = _viewport.GetEntityParameterColor(index);
            }
        }

        private void ParameterColor_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void label_color_Click(object sender, EventArgs e)
        {
            if (colorDialog_paraColor.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                int scannerInd = comboBox_para_index.SelectedIndex;
                if (scannerInd != -1)
                {
                    _viewport.SetEntityParameterColor(scannerInd, colorDialog_paraColor.Color);
                    label_color.BackColor = colorDialog_paraColor.Color;
                }
            }
        }
    }
}
