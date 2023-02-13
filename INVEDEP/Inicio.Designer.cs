namespace INVEDEP
{
    partial class Inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menúToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peticionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registroInvedepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menúToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1143, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menúToolStripMenuItem
            // 
            this.menúToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peticionarioToolStripMenuItem,
            this.citasToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.registroInvedepToolStripMenuItem});
            this.menúToolStripMenuItem.Name = "menúToolStripMenuItem";
            this.menúToolStripMenuItem.Size = new System.Drawing.Size(73, 29);
            this.menúToolStripMenuItem.Text = "&Menú";
            // 
            // peticionarioToolStripMenuItem
            // 
            this.peticionarioToolStripMenuItem.Name = "peticionarioToolStripMenuItem";
            this.peticionarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.peticionarioToolStripMenuItem.Text = "&Peticionario";
            this.peticionarioToolStripMenuItem.Click += new System.EventHandler(this.peticionarioToolStripMenuItem_Click);
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.citasToolStripMenuItem.Text = "&Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.informesToolStripMenuItem.Text = "&Informes";
            this.informesToolStripMenuItem.Click += new System.EventHandler(this.informesToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.usuarioToolStripMenuItem.Text = "&Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 728);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 20, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1143, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // registroInvedepToolStripMenuItem
            // 
            this.registroInvedepToolStripMenuItem.Name = "registroInvedepToolStripMenuItem";
            this.registroInvedepToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.registroInvedepToolStripMenuItem.Text = "Registro Invedep";
            this.registroInvedepToolStripMenuItem.Click += new System.EventHandler(this.registroInvedepToolStripMenuItem_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menúToolStripMenuItem;
        private ToolStripMenuItem peticionarioToolStripMenuItem;
        private ToolStripMenuItem citasToolStripMenuItem;
        private ToolStripMenuItem informesToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem registroInvedepToolStripMenuItem;
    }
}