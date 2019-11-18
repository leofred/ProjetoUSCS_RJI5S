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
            this.calcRoute = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.originCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hopsRB = new System.Windows.Forms.RadioButton();
            this.distRB = new System.Windows.Forms.RadioButton();
            this.costRB = new System.Windows.Forms.RadioButton();
            this.destinyCB = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calcRoute
            // 
            this.calcRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.calcRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcRoute.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.calcRoute.Location = new System.Drawing.Point(12, 575);
            this.calcRoute.Name = "calcRoute";
            this.calcRoute.Size = new System.Drawing.Size(480, 66);
            this.calcRoute.TabIndex = 11;
            this.calcRoute.Text = "Calcular Rota";
            this.calcRoute.UseVisualStyleBackColor = false;
            this.calcRoute.Click += new System.EventHandler(this.calcRoute_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button2.Location = new System.Drawing.Point(259, 666);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 29);
            this.button2.TabIndex = 12;
            this.button2.Text = "Excluir Cidade";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button3.Location = new System.Drawing.Point(12, 666);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 29);
            this.button3.TabIndex = 13;
            this.button3.Text = "Adicionar Cidade";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(165)))), ((int)(((byte)(173)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.richTextBox1.Location = new System.Drawing.Point(12, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(480, 353);
            this.richTextBox1.TabIndex = 15;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button1.Location = new System.Drawing.Point(132, 666);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Adicionar Vértice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button4.Location = new System.Drawing.Point(379, 666);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 29);
            this.button4.TabIndex = 17;
            this.button4.Text = "Excluir Vértice";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(255, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destino";
            // 
            // originCB
            // 
            this.originCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.originCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.originCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.originCB.FormattingEnabled = true;
            this.originCB.Location = new System.Drawing.Point(12, 431);
            this.originCB.Name = "originCB";
            this.originCB.Size = new System.Drawing.Size(234, 29);
            this.originCB.TabIndex = 11;
            this.originCB.SelectedIndexChanged += new System.EventHandler(this.originCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(8, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Origem";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.costRB);
            this.groupBox1.Controls.Add(this.distRB);
            this.groupBox1.Controls.Add(this.hopsRB);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.groupBox1.Location = new System.Drawing.Point(12, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(480, 74);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Métricas";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // hopsRB
            // 
            this.hopsRB.AutoSize = true;
            this.hopsRB.Location = new System.Drawing.Point(38, 28);
            this.hopsRB.Name = "hopsRB";
            this.hopsRB.Size = new System.Drawing.Size(64, 25);
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
            this.distRB.Location = new System.Drawing.Point(188, 28);
            this.distRB.Name = "distRB";
            this.distRB.Size = new System.Drawing.Size(91, 25);
            this.distRB.TabIndex = 7;
            this.distRB.TabStop = true;
            this.distRB.Tag = "B";
            this.distRB.Text = "Distância";
            this.distRB.UseVisualStyleBackColor = true;
            this.distRB.CheckedChanged += new System.EventHandler(this.distRB_CheckedChanged);
            // 
            // costRB
            // 
            this.costRB.AutoSize = true;
            this.costRB.Location = new System.Drawing.Point(355, 28);
            this.costRB.Name = "costRB";
            this.costRB.Size = new System.Drawing.Size(68, 25);
            this.costRB.TabIndex = 8;
            this.costRB.TabStop = true;
            this.costRB.Tag = "C";
            this.costRB.Text = "Custo";
            this.costRB.UseVisualStyleBackColor = true;
            this.costRB.CheckedChanged += new System.EventHandler(this.costRB_CheckedChanged);
            // 
            // destinyCB
            // 
            this.destinyCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.destinyCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.destinyCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinyCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.destinyCB.FormattingEnabled = true;
            this.destinyCB.Location = new System.Drawing.Point(259, 431);
            this.destinyCB.Name = "destinyCB";
            this.destinyCB.Size = new System.Drawing.Size(234, 29);
            this.destinyCB.TabIndex = 14;
            this.destinyCB.SelectedIndexChanged += new System.EventHandler(this.destinyCB_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button5.Location = new System.Drawing.Point(458, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 28);
            this.button5.TabIndex = 18;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.button6.Location = new System.Drawing.Point(418, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(34, 28);
            this.button6.TabIndex = 19;
            this.button6.Text = "?";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(59)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(504, 712);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.destinyCB);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.originCB);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.calcRoute);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USCSNet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button calcRoute;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox originCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton costRB;
        private System.Windows.Forms.RadioButton distRB;
        private System.Windows.Forms.RadioButton hopsRB;
        private System.Windows.Forms.ComboBox destinyCB;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

