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
    public partial class FacultyForm : Form
    {
        private DataContext context = new();

        public FacultyForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = context.Faculties.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new AddFacultyForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                context.Faculties.Add(form.Result);
                context.SaveChanges();
                dataGridView1.DataSource = context.Faculties.ToList();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var list = (List<Faculty>)dataGridView1.DataSource;
            foreach (var row in dataGridView1.SelectedRows)
            {
                var index = ((DataGridViewRow)row).Index;
                context.Faculties.Remove(list[index]);
            }
            context.SaveChanges();
            dataGridView1.DataSource = context.Faculties.ToList();
        }
    }
}
