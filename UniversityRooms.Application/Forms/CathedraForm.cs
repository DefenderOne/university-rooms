using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityRooms.UI.Database;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Forms
{
    public partial class CathedraForm : Form
    {
        private DataContext context = new();
        public CathedraForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Cathedras.ToList();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            var form = new AddCathedraForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                context.Cathedras.Add(form.Result);
                context.SaveChanges();
                dataGridView1.DataSource = context.Cathedras.ToList();
            }
        }

        private void deleteButton_Click_1(object sender, EventArgs e)
        {
            var list = (List<Cathedra>)dataGridView1.DataSource;
            foreach (var row in dataGridView1.SelectedRows)
            {
                var index = ((DataGridViewRow)row).Index;
                context.Cathedras.Remove(list[index]);
            }
            context.SaveChanges();
            dataGridView1.DataSource = context.Cathedras.ToList();
        }
    }
}
