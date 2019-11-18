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
            if (
                String.IsNullOrEmpty(cityOne.Text) ||
                String.IsNullOrEmpty(cityTwo.Text) ||
                String.IsNullOrEmpty(numericUpDown1.Text) ||
                String.IsNullOrEmpty(numericUpDown2.Text) ||
                String.IsNullOrEmpty(numericUpDown3.Text)
                )
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Vertex newVertex = new Vertex(
                cityOne.Text,
                cityTwo.Text,
                int.Parse(numericUpDown1.Text),
                int.Parse(numericUpDown2.Text),
                int.Parse(numericUpDown3.Text));

                newVertex.IncludeDB();
                this.Close();
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
