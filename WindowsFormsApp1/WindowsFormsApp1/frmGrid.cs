using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmGrid : Form
    {
        public frmGrid()
        {
            InitializeComponent();
        }

        private void frmGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new object[]
{
    new {Id = 1, Nome = "A"},
    new {Id = 2, Nome = "B"},
}
.ToList();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //if (e.Value != null && e.Value.Equals(1))

            //{
            //    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Coral;
            //}

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                int valor = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value.ToString());
                if (valor * 5 == 10)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Coral;
                }
            }
        }
    }
}
