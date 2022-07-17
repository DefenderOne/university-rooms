using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityRooms.UI.Models;

namespace UniversityRooms.UI.Forms
{
    public partial class AddBuildingForm : Form
    {
        public Building Result { get; set; }

        public AddBuildingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) &&
                !string.IsNullOrEmpty(textBox2.Text) && int.TryParse(textBox2.Text, out int result) &&
                !string.IsNullOrEmpty(textBox3.Text))
            {
                Result = new Building
                {
                    Name = textBox1.Text,
                    LevelsCount = result,
                    Address = textBox3.Text
                };
            }
        }
    }
}
