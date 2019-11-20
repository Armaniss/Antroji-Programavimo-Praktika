namespace Praktinis_darbas
{
    partial class MDIParent1
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.peržiūrėtiKnygasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peržiūtėtiKnygasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasiimtiKnygaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gražintiKnygaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peržiūrėtiKnygasToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(843, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 533);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(843, 25);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // peržiūrėtiKnygasToolStripMenuItem
            // 
            this.peržiūrėtiKnygasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peržiūtėtiKnygasToolStripMenuItem,
            this.pasiimtiKnygaToolStripMenuItem,
            this.gražintiKnygaToolStripMenuItem});
            this.peržiūrėtiKnygasToolStripMenuItem.Name = "peržiūrėtiKnygasToolStripMenuItem";
            this.peržiūrėtiKnygasToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.peržiūrėtiKnygasToolStripMenuItem.Text = "Knygos";
            // 
            // peržiūtėtiKnygasToolStripMenuItem
            // 
            this.peržiūtėtiKnygasToolStripMenuItem.Name = "peržiūtėtiKnygasToolStripMenuItem";
            this.peržiūtėtiKnygasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.peržiūtėtiKnygasToolStripMenuItem.Text = "Peržiūtėti knygas";
            this.peržiūtėtiKnygasToolStripMenuItem.Click += new System.EventHandler(this.peržiūtėtiKnygasToolStripMenuItem_Click);
            // 
            // pasiimtiKnygaToolStripMenuItem
            // 
            this.pasiimtiKnygaToolStripMenuItem.Name = "pasiimtiKnygaToolStripMenuItem";
            this.pasiimtiKnygaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pasiimtiKnygaToolStripMenuItem.Text = "Pasiimti knyga";
            this.pasiimtiKnygaToolStripMenuItem.Click += new System.EventHandler(this.pasiimtiKnygaToolStripMenuItem_Click);
            // 
            // gražintiKnygaToolStripMenuItem
            // 
            this.gražintiKnygaToolStripMenuItem.Name = "gražintiKnygaToolStripMenuItem";
            this.gražintiKnygaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gražintiKnygaToolStripMenuItem.Text = "Gražinti knyga";
            this.gražintiKnygaToolStripMenuItem.Click += new System.EventHandler(this.gražintiKnygaToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 558);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MDIParent1";
            this.Text = "Studentas";
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem peržiūrėtiKnygasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peržiūtėtiKnygasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasiimtiKnygaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gražintiKnygaToolStripMenuItem;
    }
}



