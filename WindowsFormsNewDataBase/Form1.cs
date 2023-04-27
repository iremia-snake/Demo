using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsNewDataBase.Controller;

namespace WindowsFormsNewDataBase
{
    public partial class Form1 : Form
    {
        Query controller;
        public Form1()
        {
            controller = new Query(ConnectionString.ConnString);
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controller.UpdatePerson();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            controller.Add(BoxFirstName.Text, BoxLastName.Text, Int32.Parse(BoxAge.Text));
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            controller.Delete(Int32.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Id"].Value.ToString()));
        }

        private void BoxLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
