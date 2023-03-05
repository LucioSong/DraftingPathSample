using DraftingPathComponent;
using System;
using System.Windows.Forms;

namespace DraftingPathSample
{
    public partial class SelectionFunction : Form
    {
        DraftingViewport _viewport = null;
        public SelectionFunction(DraftingViewport draftingViewport)
        {
            InitializeComponent();

            _viewport = draftingViewport;
        }

        private void SelectionFunction_Load(object sender, EventArgs e)
        {
            comboBox_rotate.SelectedIndex = comboBox_trans.SelectedIndex = 0;
        }

        private void button_trans_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(numericUpDown_trans.Value);
            switch (comboBox_trans.SelectedIndex)
            {
                case 0:
                    {
                        _viewport.SelectionTranslate(val, 0, 0);                        
                    }
                    break;

                case 1:
                    {
                        _viewport.SelectionTranslate(0, val, 0);
                    }
                    break;

                case 2:
                    {
                        _viewport.SelectionTranslate(0, 0, val);
                    }
                    break;
            }
        }

        private void button_rotate_Click(object sender, EventArgs e)
        {
            double val = Convert.ToDouble(numericUpDown_rotate.Value);
            switch (comboBox_rotate.SelectedIndex)
            {
                case 0:
                    {
                        _viewport.SelectionRotateRelX(val);
                    }
                    break;

                case 1:
                    {
                        _viewport.SelectionRotateRelY(val);
                    }
                    break;

                case 2:
                    {
                        _viewport.SelectionRotateRelZ(val);
                    }
                    break;
            }
        }

        private void SelectionFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
