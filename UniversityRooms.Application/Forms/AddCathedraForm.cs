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
    public partial class AddCathedraForm : Form
    {
        public Cathedra Result { get; set; }
        private DataContext context = new();
        public AddCathedraForm()
        {
            InitializeComponent();
            comboBox1.DataSource = context.Faculties.Select(f => new ComboboxItem
            {
                Text = f.Name,
                Value = f
            }).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var faculty = (comboBox1.SelectedItem as ComboboxItem)!.Value as Faculty;
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                faculty is not null)
            {
                Result = new Cathedra
                {
                    Name = textBox1.Text,
                    FacultyId = faculty.Id
                };
            }
        }
    }
}
