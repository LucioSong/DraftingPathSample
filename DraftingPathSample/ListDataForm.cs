using System;
using System.Collections;
using System.Windows.Forms;

namespace DraftingPathSample
{
    public partial class ListDataForm : Form
    {
        ArrayList _list = null;
        public ListDataForm(ArrayList lst)
        {
            InitializeComponent();

            _list = lst;
        }

        private void ListDataForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _list;
        }
    }
}
