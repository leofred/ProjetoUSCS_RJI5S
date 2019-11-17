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
        int[,] metricA = new int [ , ] {
             { 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 1, 0, 1, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 1, 1, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 1, 1, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 1, 0, 0, 0, 1, 1, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
             { 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 },
             { 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 1, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 1, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 1 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1 },
             { 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0 }
            };
        int [ ,] metricB = new int [ , ] {
             { 0, 6, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 6, 0, 1, 2, 0, 0, 0,12, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 7, 1, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 2, 2, 0, 6, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 6, 0, 7, 0, 0, 0, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 5, 7, 0, 2, 5, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 2, 0, 3, 7, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0,12, 0, 0, 0, 5, 3, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,20 },
             { 0, 0, 0, 0, 0, 0, 7, 7, 0, 0, 0, 0, 0, 0, 0, 0, 9, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 1, 2, 0, 0, 0, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 8, 0, 0, 0 },
             { 0, 0, 0, 0, 3, 0, 0, 0, 0, 3, 0, 0,10, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,10, 0, 8, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0,20, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,20, 0,18,22, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,18, 0, 0,21, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 9, 0, 8, 0, 0, 0,22, 0, 0,22, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,21,22, 0, 4,15 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 8 },
             { 0, 0, 0, 0, 0, 0, 0,20, 0, 0, 0, 0, 0, 0, 0, 0, 0,15, 8, 0 }
            };
        int [ ,] metricC = new int [ , ] {
             { 0, 2, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 2, 0, 3, 5, 0, 0, 0,10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 2, 3, 0, 5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 5, 5, 0, 2,10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 2, 0, 2, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0,10, 2, 0,16,15, 0, 7, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0,16, 0,10, 8,10, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0,10, 0, 0, 0,15,10, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 6 },
             { 0, 0, 0, 0, 0, 0, 8, 6, 0, 0, 0, 0, 0, 0, 0, 0, 6, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 7,10, 0, 0, 0, 4, 6, 0, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0, 0, 0, 0, 4, 0, 0, 0 },
             { 0, 0, 0, 0, 2, 0, 0, 0, 0, 6, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 2, 0, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 3, 0, 0, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 2, 6, 0, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 3, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 6, 0, 4, 0, 0, 0, 6, 0, 0, 7, 0, 0 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 7, 0, 3, 4 },
             { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 3, 0, 5 },
             { 0, 0, 0, 0, 0, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 5, 0 }
            };
        public Form1()
        {
            city_list = db.getAllCitys ( );
            vertex_list = db.getAllVertex ( );
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

            matrix.createMatrix ( );

            Dijkstra.dijkstra ( matrix.MatrixStruct , originIndex , destinyIndex);
            
            List<City> citysPath = new List<City>();

            foreach ( int cityIndex in Path.cityPath ) {
                citysPath.Add ( city_list [ cityIndex ] );
            }

            citysPath.Reverse ( );

            foreach ( City item in citysPath ) {
                richTextBox1.Text += item.Getnome ( ) + "\n";
            }
        }
    }
}
