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
    public partial class BuildingForm : Form
    {
        private DataContext context = new();
        public BuildingForm()
        {
            InitializeComponent();
        }

        private void BuildingForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Buildings.ToList();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var list = (List<Building>)dataGridView1.DataSource;
            foreach (var row in dataGridView1.SelectedRows)
            {
                var index = ((DataGridViewRow)row).Index;
                context.Buildings.Remove(list[index]);
            }
            context.SaveChanges();
            dataGridView1.DataSource = context.Buildings.ToList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var form = new AddBuildingForm();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                context.Buildings.Add(form.Result);
                context.SaveChanges();
                dataGridView1.DataSource = context.Buildings.ToList();
            }
        }
    }
}
