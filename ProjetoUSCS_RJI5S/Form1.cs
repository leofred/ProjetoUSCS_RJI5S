﻿using ProjetoUSCS_RJI5S.Class;
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
    public partial class Form1 : Form
    {
        int[,] metricA;
        int[,] metricB;
        int[,] metricC;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graph t = new Graph();
            t.dijkstra(this.metricC, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.metricA = new int[,] {
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

            this.metricB = new int[,] {
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

            this.metricC = new int[,] {
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
        }
    }
}
