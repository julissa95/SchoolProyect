namespace SchoolProject
{
    partial class ListaAlumno
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
            this.dgvListaAlumno = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaAlumno
            // 
            this.dgvListaAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaAlumno.Location = new System.Drawing.Point(35, 60);
            this.dgvListaAlumno.Name = "dgvListaAlumno";
            this.dgvListaAlumno.RowHeadersWidth = 51;
            this.dgvListaAlumno.RowTemplate.Height = 24;
            this.dgvListaAlumno.Size = new System.Drawing.Size(884, 390);
            this.dgvListaAlumno.TabIndex = 0;
            // 
            // ListaAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 497);
            this.Controls.Add(this.dgvListaAlumno);
            this.Name = "ListaAlumno";
            this.Text = "ListaAlumno";
            this.Load += new System.EventHandler(this.ListaAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaAlumno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaAlumno;
    }
}