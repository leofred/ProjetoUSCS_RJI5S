using ProjetoUSCS_RJI5S.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoUSCS_RJI5S
{
    public partial class Form3 : Form
    {
        private Database db = new Database();
        private List<City> city_list;

        public Form3()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
            city_list = db.getAllCitys();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            foreach (City city in city_list)
            {
                cityOne.Items.Add(city.GetSIGLA());
                cityTwo.Items.Add(city.GetSIGLA());
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Vertex newVertex = new Vertex(
                cityOne.Text,
                cityTwo.Text,
                int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text));

            newVertex.IncludeDB();
            this.Close();
        }
    }
}
