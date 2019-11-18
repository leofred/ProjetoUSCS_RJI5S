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
using WindowsFormsApp1.Classes;
using System.Diagnostics;

namespace ProjetoUSCS_RJI5S
{
    public partial class Form1 : Form
    {
        private Database db = new Database ( );
        private List<City> city_list;
        private List<Vertex> vertex_list;

        string metricChoose;
        int originIndex;
        int destinyIndex;
        
        public Form1()
        {
            city_list = db.getAllCitys ( );
            vertex_list = db.getAllVertex ( );
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent ();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach ( City city in city_list ){
                originCB.Items.Add ( city.GetSIGLA ( ) );
                destinyCB.Items.Add ( city.GetSIGLA ( ) );
            }
        }

        private void hopsRB_CheckedChanged ( object sender , EventArgs e ) {
            metricChoose = hopsRB.Tag.ToString();
        }

        private void distRB_CheckedChanged ( object sender , EventArgs e ) {
            metricChoose = distRB.Tag.ToString ( );
        }

        private void costRB_CheckedChanged ( object sender , EventArgs e ) {
            metricChoose = costRB.Tag.ToString ( );
        }


        private void originCB_SelectedIndexChanged ( object sender , EventArgs e ) {
            originIndex = originCB.SelectedIndex;
        }

        private void destinyCB_SelectedIndexChanged ( object sender , EventArgs e ) {
            destinyIndex = destinyCB.SelectedIndex;
        }
        private void calcRoute_Click ( object sender , EventArgs e ) {
            
            richTextBox1.Text = String.Format ( "Rota de {0} para {1}\n===================\n" , city_list [ originIndex ].Getnome ( ) , city_list [ destinyIndex ].Getnome ( )  );
            
            Matrix matrix = new Matrix ( city_list , vertex_list , metricChoose );

            matrix.createMatrix ();

            Dijkstra.dijkstra (matrix.MatrixStruct , originIndex , destinyIndex);
            
            List<City> citysPath = new List<City>();

            foreach ( int cityIndex in Path.cityPath ) {
                citysPath.Add ( city_list [ cityIndex ] );

                Console.WriteLine(city_list[cityIndex].Getnome());
            }

            citysPath.Reverse ( );

            foreach ( City item in citysPath ) {
                richTextBox1.Text += item.Getnome ( ) + "\n";
            }

            Debug.WriteLine(citysPath);
            Path.cityPath.Clear();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form2 addCity = new Form2();
            if (addCity.ShowDialog(this) == DialogResult.OK)
            {
                city_list = db.getAllCitys();
                vertex_list = db.getAllVertex();

                foreach (City city in city_list)
                {
                    originCB.Items.Add(city.GetSIGLA());
                    destinyCB.Items.Add(city.GetSIGLA());
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form4 removeCity = new Form4();
            if (removeCity.ShowDialog(this) == DialogResult.OK)
            {
                city_list = db.getAllCitys();
                vertex_list = db.getAllVertex();

                foreach (City city in city_list)
                {
                    originCB.Items.Add(city.GetSIGLA());
                    destinyCB.Items.Add(city.GetSIGLA());
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 addVertex = new Form3();
            if (addVertex.ShowDialog(this) == DialogResult.OK)
            {
                city_list = db.getAllCitys();
                vertex_list = db.getAllVertex();

                foreach (City city in city_list)
                {
                    originCB.Items.Add(city.GetSIGLA());
                    destinyCB.Items.Add(city.GetSIGLA());
                }
            }
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Form5 removeVertex = new Form5();
            if (removeVertex.ShowDialog(this) == DialogResult.OK)
            {
                city_list = db.getAllCitys();
                vertex_list = db.getAllVertex();

                foreach (City city in city_list)
                {
                    originCB.Items.Add(city.GetSIGLA());
                    destinyCB.Items.Add(city.GetSIGLA());
                }
            }
        }
    }
}
