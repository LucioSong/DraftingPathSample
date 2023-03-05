using DraftingPathComponent;
using DraftingPathStruct;
using DraftPath._3DTools.DraftEntity;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DraftingPathSample
{
    public partial class Form1 : Form
    {
        DraftingViewport viewport = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            viewport = new DraftingViewport();
            //viewport = new DraftingViewport(Color.LightSkyBlue, Color.White);
            viewport.Dock = DockStyle.Fill;
            panel1.Controls.Add(viewport);

            propertyGrid1.SelectedObject = viewport;

            viewport.EntiesSelectionChange += Viewport_EntiesSelectionChange;

            comboBox_rotate.SelectedIndex = comboBox_trans.SelectedIndex = 0;
        }

        private void Viewport_EntiesSelectionChange(object sender, EventArgs e)
        {
            List<int> selection = sender as List<int>;
            if (selection != null && selection.Count > 0)
            {
                int selInd = selection[0];

                propertyGrid2.SelectedObject = viewport.GetEntity(selInd);
            }
            else
            {
                propertyGrid2.SelectedObject = null;
            }
        }

        private void button_add_text_Click(object sender, EventArgs e)
        {
            bool ret = viewport.CreateEntityText("Drafting Path");
            MessageBox.Show(ret.ToString());            
        }

        private void button_get_path_Click(object sender, EventArgs e)
        {
            ListDataForm ldf = new ListDataForm(new ArrayList(viewport.GetProcessPathsAll()));
            ldf.ShowDialog();
        }

        private void button_trans_Click(object sender, EventArgs e)
        {
            try
            {
                EntityCommon entComm = propertyGrid2.SelectedObject as EntityCommon;
                if (entComm != null)
                {
                    double val = Convert.ToDouble(numericUpDown_trans.Value);
                    switch (comboBox_trans.SelectedIndex)
                    {
                        case 0:
                            {
                                entComm.TranslateRelXYZ(val, 0, 0);
                            }
                            break;

                        case 1:
                            {
                                entComm.TranslateRelXYZ(0, val, 0);
                            }
                            break;

                        case 2:
                            {
                                entComm.TranslateRelXYZ(0, 0, val);
                            }
                            break;
                    }
                }                
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button_rotate_Click(object sender, EventArgs e)
        {
            try
            {
                EntityCommon entComm = propertyGrid2.SelectedObject as EntityCommon;
                if (entComm != null)
                {
                    double val = Convert.ToDouble(numericUpDown_rotate.Value);
                    switch (comboBox_rotate.SelectedIndex)
                    {
                        case 0:
                            {
                                entComm.RotateRelX(val);
                            }
                            break;

                        case 1:
                            {
                                entComm.RotateRelY(val);
                            }
                            break;

                        case 2:
                            {
                                entComm.RotateRelZ(val);
                            }
                            break;
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void button_import_dxf_dwg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            string theFilter = "DXF file(*.dxf)|*.dxf|DWG file(*.DWG)|*.dwg";
            openFileDialog1.Filter = theFilter;
            openFileDialog1.Multiselect = false;
            openFileDialog1.AddExtension = true;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                viewport.ImportDrawingFileDXF_DWG(openFileDialog1.FileName);
            }
        }

        private void button_get_sel_minmax_Click(object sender, EventArgs e)
        {
            Pt3D min, max;
            viewport.SelectionMinMax(out min, out max);
            MessageBox.Show(string.Format("Selection\r\n min : ({0}, {1}, {2}) \r\n max : ({3}, {4}, {5})",
                                            min.X, min.Y, min.Z,
                                            max.X, max.Y, max.Z));
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            
        }

        SelectionFunction _selectionFunc = null;
        private void button_sel_func_Click(object sender, EventArgs e)
        {
            if (_selectionFunc == null)
            {
                _selectionFunc = new SelectionFunction(viewport);
            }

            _selectionFunc.Show();
            _selectionFunc.Focus();
        }

        ParameterColor _parameterColor = null;
        private void button_set_parameter_color_Click(object sender, EventArgs e)
        {
            if (_parameterColor == null)
            {
                _parameterColor = new ParameterColor(viewport);
            }

            _parameterColor.Show();
            _parameterColor.Focus();
        }
    }
}
