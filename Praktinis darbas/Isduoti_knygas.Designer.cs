namespace Praktinis_darbas
{
    partial class Isduoti_knygas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_sarasonr = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pavadinimas = new System.Windows.Forms.TextBox();
            this.txt_elpastas = new System.Windows.Forms.TextBox();
            this.txt_numeris = new System.Windows.Forms.TextBox();
            this.txt_grupe = new System.Windows.Forms.TextBox();
            this.txt_vardas = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_sarasonr
            // 
            this.txt_sarasonr.Location = new System.Drawing.Point(43, 56);
            this.txt_sarasonr.Name = "txt_sarasonr";
            this.txt_sarasonr.Size = new System.Drawing.Size(201, 22);
            this.txt_sarasonr.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_pavadinimas);
            this.panel1.Controls.Add(this.txt_elpastas);
            this.panel1.Controls.Add(this.txt_numeris);
            this.panel1.Controls.Add(this.txt_grupe);
            this.panel1.Controls.Add(this.txt_vardas);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.txt_sarasonr);
            this.panel1.Location = new System.Drawing.Point(175, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 498);
            this.panel1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(584, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 132);
            this.listBox1.TabIndex = 16;
            this.listBox1.Visible = false;
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            this.listBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyUp);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 15;
            this.button2.Text = "Isduoti knyga";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(425, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Knygos isdavimo data";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(425, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Knygos pavadinimas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Studento_elpastas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Studento_numeris";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Studento grupe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Studento vardas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Iveskito studento saraso numeri";
            // 
            // txt_pavadinimas
            // 
            this.txt_pavadinimas.Location = new System.Drawing.Point(584, 319);
            this.txt_pavadinimas.Name = "txt_pavadinimas";
            this.txt_pavadinimas.Size = new System.Drawing.Size(209, 22);
            this.txt_pavadinimas.TabIndex = 6;
            this.txt_pavadinimas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pavadinimas_KeyDown);
            this.txt_pavadinimas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_pavadinimas_KeyUp);
            // 
            // txt_elpastas
            // 
            this.txt_elpastas.Location = new System.Drawing.Point(584, 203);
            this.txt_elpastas.Name = "txt_elpastas";
            this.txt_elpastas.Size = new System.Drawing.Size(209, 22);
            this.txt_elpastas.TabIndex = 5;
            // 
            // txt_numeris
            // 
            this.txt_numeris.Location = new System.Drawing.Point(584, 145);
            this.txt_numeris.Name = "txt_numeris";
            this.txt_numeris.Size = new System.Drawing.Size(209, 22);
            this.txt_numeris.TabIndex = 4;
            // 
            // txt_grupe
            // 
            this.txt_grupe.Location = new System.Drawing.Point(584, 87);
            this.txt_grupe.Name = "txt_grupe";
            this.txt_grupe.Size = new System.Drawing.Size(209, 22);
            this.txt_grupe.TabIndex = 3;
            // 
            // txt_vardas
            // 
            this.txt_vardas.Location = new System.Drawing.Point(584, 29);
            this.txt_vardas.Name = "txt_vardas";
            this.txt_vardas.Size = new System.Drawing.Size(209, 22);
            this.txt_vardas.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ieskoti";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(584, 265);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 22);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // Isduoti_knygas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1295, 675);
            this.Controls.Add(this.panel1);
            this.Name = "Isduoti_knygas";
            this.Text = "Isduoti_knygas";
            this.Load += new System.EventHandler(this.Isduoti_knygas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_sarasonr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pavadinimas;
        private System.Windows.Forms.TextBox txt_elpastas;
        private System.Windows.Forms.TextBox txt_numeris;
        private System.Windows.Forms.TextBox txt_grupe;
        private System.Windows.Forms.TextBox txt_vardas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}