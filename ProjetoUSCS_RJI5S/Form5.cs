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
    public partial class Form5 : Form
    {

        private Database db = new Database();
        private List<Vertex> vertex_list;
        public Form5()
        {
            MaximizeBox = false;
            MinimizeBox = false;
            InitializeComponent();
            vertex_list = db.getAllVertex();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            foreach (Vertex vertex in vertex_list)
            {
                allVertex.Items.Add(vertex.GetComboName());
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(allVertex.Text))
            {
                MessageBox.Show("Por favor, selecione um vértice.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var confirmResult = MessageBox.Show("Tem certeza que deseja remover esse vértice?",
                                     "Remover Vértice",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    Vertex selectedVertex = vertex_list[allVertex.SelectedIndex];
                    Vertex vertexToRemove = new Vertex(selectedVertex);

                    vertexToRemove.DeleteDB();
                    this.Close();
                }
            }    
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
