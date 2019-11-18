namespace ProjetoUSCS_RJI5S
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hopsRB = new System.Windows.Forms.RadioButton();
            this.distRB = new System.Windows.Forms.RadioButton();
            this.costRB = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.destinyCB = new System.Windows.Forms.ComboBox();
            this.originCB = new System.Windows.Forms.ComboBox();
            this.calcRoute = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // hopsRB
            // 
            this.hopsRB.AutoSize = true;
            this.hopsRB.Location = new System.Drawing.Point(6, 18);
            this.hopsRB.Name = "hopsRB";
            this.hopsRB.Size = new System.Drawing.Size(50, 17);
            this.hopsRB.TabIndex = 6;
            this.hopsRB.TabStop = true;
            this.hopsRB.Tag = "A";
            this.hopsRB.Text = "Hops";
            this.hopsRB.UseVisualStyleBackColor = true;
            this.hopsRB.CheckedChanged += new System.EventHandler(this.hopsRB_CheckedChanged);
            // 
            // distRB
            // 
            this.distRB.AutoSize = true;
            this.distRB.Location = new System.Drawing.Point(79, 18);
            this.distRB.Name = "distRB";
            this.distRB.Size = new System.Drawing.Size(69, 17);
            this.distRB.TabIndex = 7;
            this.distRB.TabStop = true;
            this.distRB.Tag = "B";
            this.distRB.Text = "Distäncia";
            this.distRB.UseVisualStyleBackColor = true;
            this.distRB.CheckedChanged += new System.EventHandler(this.distRB_CheckedChanged);
            // 
            // costRB
            // 
            this.costRB.AutoSize = true;
            this.costRB.Location = new System.Drawing.Point(167, 18);
            this.costRB.Name = "costRB";
            this.costRB.Size = new System.Drawing.Size(52, 17);
            this.costRB.TabIndex = 8;
            this.costRB.TabStop = true;
            this.costRB.Tag = "C";
            this.costRB.Text = "Custo";
            this.costRB.UseVisualStyleBackColor = true;
            this.costRB.CheckedChanged += new System.EventHandler(this.costRB_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costRB);
            this.groupBox1.Controls.Add(this.distRB);
            this.groupBox1.Controls.Add(this.hopsRB);
            this.groupBox1.Location = new System.Drawing.Point(9, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(225, 40);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métricas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.destinyCB);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.originCB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 360);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(240, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // destinyCB
            // 
            this.destinyCB.FormattingEnabled = true;
            this.destinyCB.Location = new System.Drawing.Point(121, 16);
            this.destinyCB.Name = "destinyCB";
            this.destinyCB.Size = new System.Drawing.Size(113, 21);
            this.destinyCB.TabIndex = 14;
            this.destinyCB.SelectedIndexChanged += new System.EventHandler(this.destinyCB_SelectedIndexChanged);
            // 
            // originCB
            // 
            this.originCB.FormattingEnabled = true;
            this.originCB.Location = new System.Drawing.Point(6, 16);
            this.originCB.Name = "originCB";
            this.originCB.Size = new System.Drawing.Size(113, 21);
            this.originCB.TabIndex = 11;
            this.originCB.SelectedIndexChanged += new System.EventHandler(this.originCB_SelectedIndexChanged);
            // 
            // calcRoute
            // 
            this.calcRoute.Location = new System.Drawing.Point(258, 500);
            this.calcRoute.Name = "calcRoute";
            this.calcRoute.Size = new System.Drawing.Size(102, 29);
            this.calcRoute.TabIndex = 11;
            this.calcRoute.Text = "Calcular Rota";
            this.calcRoute.UseVisualStyleBackColor = true;
            this.calcRoute.Click += new System.EventHandler(this.calcRoute_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(258, 430);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Excluir Cidade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 360);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Adicionar Cidade";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(348, 342);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Adicionar Vértice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(258, 465);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(102, 29);
            this.button4.TabIndex = 17;
            this.button4.Text = "Excluir Vértice";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 540);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calcRoute);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USCSNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton hopsRB;
        private System.Windows.Forms.RadioButton distRB;
        private System.Windows.Forms.RadioButton costRB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox destinyCB;
        private System.Windows.Forms.ComboBox originCB;
        private System.Windows.Forms.Button calcRoute;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
    }
}

