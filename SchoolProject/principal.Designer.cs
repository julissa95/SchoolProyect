namespace SchoolProject
{
    partial class principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingresarNuevoAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAlumnodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarNotasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresaAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNuevoAlumnoToolStripMenuItem,
            this.ingresaAlumnosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1227, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ingresarNuevoAlumnoToolStripMenuItem
            // 
            this.ingresarNuevoAlumnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresarNotasToolStripMenuItem,
            this.verAlumnodsToolStripMenuItem,
            this.ingresarNotasToolStripMenuItem1});
            this.ingresarNuevoAlumnoToolStripMenuItem.Name = "ingresarNuevoAlumnoToolStripMenuItem";
            this.ingresarNuevoAlumnoToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.ingresarNuevoAlumnoToolStripMenuItem.Text = "Menu Del Sistema";
            // 
            // verAlumnodsToolStripMenuItem
            // 
            this.verAlumnodsToolStripMenuItem.Name = "verAlumnodsToolStripMenuItem";
            this.verAlumnodsToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.verAlumnodsToolStripMenuItem.Text = "Ver Alumnods";
            this.verAlumnodsToolStripMenuItem.Click += new System.EventHandler(this.verAlumnodsToolStripMenuItem_Click);
            // 
            // ingresarNotasToolStripMenuItem
            // 
            this.ingresarNotasToolStripMenuItem.Name = "ingresarNotasToolStripMenuItem";
            this.ingresarNotasToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.ingresarNotasToolStripMenuItem.Text = "Ingresar Nuevo alumno";
            this.ingresarNotasToolStripMenuItem.Click += new System.EventHandler(this.ingresarNotasToolStripMenuItem_Click);
            // 
            // ingresarNotasToolStripMenuItem1
            // 
            this.ingresarNotasToolStripMenuItem1.Name = "ingresarNotasToolStripMenuItem1";
            this.ingresarNotasToolStripMenuItem1.Size = new System.Drawing.Size(246, 26);
            this.ingresarNotasToolStripMenuItem1.Text = "Ingresar notas";
            this.ingresarNotasToolStripMenuItem1.Click += new System.EventHandler(this.ingresarNotasToolStripMenuItem1_Click);
            // 
            // ingresaAlumnosToolStripMenuItem
            // 
            this.ingresaAlumnosToolStripMenuItem.Name = "ingresaAlumnosToolStripMenuItem";
            this.ingresaAlumnosToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.ingresaAlumnosToolStripMenuItem.Text = "Ingresa Alumnos";
            this.ingresaAlumnosToolStripMenuItem.Click += new System.EventHandler(this.ingresaAlumnosToolStripMenuItem_Click);
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1227, 675);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal";
            this.Load += new System.EventHandler(this.principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingresarNuevoAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verAlumnodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarNotasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresaAlumnosToolStripMenuItem;
    }
}