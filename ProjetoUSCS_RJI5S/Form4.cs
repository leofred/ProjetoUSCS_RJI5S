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
    public partial class Form4 : Form
    {
        private Database db = new Database();
        private List<City> city_list;

        public Form4()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
            city_list = db.getAllCitys();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (City city in city_list)
            {
                allCities.Items.Add(city.GetSIGLA());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            City cityToRemove = new City(allCities.Text, "remove");
            cityToRemove.DeleteDB();
            this.Close();
        }
    }
}
