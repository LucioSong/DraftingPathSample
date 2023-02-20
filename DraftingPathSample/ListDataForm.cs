using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
