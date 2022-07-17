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
    public partial class AddRoomForm : Form
    {
        public Room Result { get; set; }
        private DataContext context = new();

        public AddRoomForm()
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
            if (building is not null &&
                int.TryParse(textBox2.Text, out var number) &&
                int.TryParse(textBox3.Text, out var level) &&
                double.TryParse(textBox4.Text, out var width) &&
                double.TryParse(textBox5.Text, out var length) &&
                double.TryParse(textBox6.Text, out var height) &&
                !string.IsNullOrEmpty(textBox1.Text))
            {
                Result = new Room
                {
                    Number = number.ToString(),
                    BuildingId = building.Id,
                    Level = level,
                    Width = width,
                    Height = height,
                    Length = length,
                    RoomType = textBox1.Text
                };
            }
        }
    }
}
