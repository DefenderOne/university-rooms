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
    public partial class AddFacultyForm : Form
    {
        public Faculty Result;
        private DataContext context = new();

        public AddFacultyForm()
        {
            InitializeComponent();
            comboBox1.DataSource = context.Buildings.Select(f => new ComboboxItem
            {
                Text = f.Name,
                Value = f
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var building = (comboBox1.SelectedItem as ComboboxItem)!.Value as Building;
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                building is not null)
            {
                Result = new Faculty
                {
                    Name = textBox1.Text,
                    BuildingId = building.Id
                };
            }
        }
    }
}
