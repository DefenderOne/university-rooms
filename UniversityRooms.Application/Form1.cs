using Microsoft.EntityFrameworkCore;
using UniversityRooms.UI.Database;

namespace UniversityRooms.UI
{
    public partial class Form1 : Form
    {
        private DataContext context;

        public Form1()
        {
            InitializeComponent();
            context = new DataContext();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.RoomTypes.Select(rt => new
            {
                Название = rt.Name
            }).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = context.Rooms.Include(r => r.Building).Include(r => r.Type);
            dataGridView1.DataSource = data.Select(r => new
            {
                Название = $"Помещение {r.Number}",
                Корпус = r.Building.Name,
                Тип = r.Type.Name,
                Этаж = r.Level,
                Длина = r.Length,
                Ширина = r.Width,
                Высота = r.Height
            }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = context.Buildings.Select(b => new
            {
                Название = b.Name,
                Адрес = b.Address,
                Этажей = b.LevelsCount
            }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var data = context.Faculties.Include(f => f.Building);
            dataGridView1.DataSource = data.Select(f => new
            {
                Название = f.Name,
                Корпус = f.Building.Name
            }).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var data = context.Cathedras.Include(f => f.Building).Include(f => f.Faculty);
            dataGridView1.DataSource = context.Cathedras.Select(f => new
            {
                Название = f.Name,
                Факультет = f.Faculty.Name,
                Корпус = f.Building.Name
            }).ToList();
        }
    }
}