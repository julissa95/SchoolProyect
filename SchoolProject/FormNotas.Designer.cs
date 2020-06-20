namespace SchoolProject
{
    partial class FormNotas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.chkprimerparcial = new System.Windows.Forms.CheckBox();
            this.chk2doparcial = new System.Windows.Forms.CheckBox();
            this.chkfinal = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "DNI ";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(159, 62);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(346, 22);
            this.txtDNI.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Materia";
            // 
            // comboMateria
            // 
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(159, 146);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(346, 24);
            this.comboMateria.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nota";
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(159, 245);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(346, 22);
            this.txtNota.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(242, 360);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(176, 55);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // chkprimerparcial
            // 
            this.chkprimerparcial.AutoSize = true;
            this.chkprimerparcial.Location = new System.Drawing.Point(51, 316);
            this.chkprimerparcial.Name = "chkprimerparcial";
            this.chkprimerparcial.Size = new System.Drawing.Size(148, 26);
            this.chkprimerparcial.TabIndex = 7;
            this.chkprimerparcial.Text = "Primer Parcial";
            this.chkprimerparcial.UseVisualStyleBackColor = true;
            // 
            // chk2doparcial
            // 
            this.chk2doparcial.AutoSize = true;
            this.chk2doparcial.Location = new System.Drawing.Point(296, 316);
            this.chk2doparcial.Name = "chk2doparcial";
            this.chk2doparcial.Size = new System.Drawing.Size(126, 26);
            this.chk2doparcial.TabIndex = 8;
            this.chk2doparcial.Text = "2nd Parcial";
            this.chk2doparcial.UseVisualStyleBackColor = true;
            // 
            // chkfinal
            // 
            this.chkfinal.AutoSize = true;
            this.chkfinal.Location = new System.Drawing.Point(526, 316);
            this.chkfinal.Name = "chkfinal";
            this.chkfinal.Size = new System.Drawing.Size(75, 26);
            this.chkfinal.TabIndex = 9;
            this.chkfinal.Text = "Final";
            this.chkfinal.UseVisualStyleBackColor = true;
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chkfinal);
            this.Controls.Add(this.chk2doparcial);
            this.Controls.Add(this.chkprimerparcial);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.label1);
            this.Name = "FormNotas";
            this.Text = "FormNotas";
            this.Load += new System.EventHandler(this.FormNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.CheckBox chkprimerparcial;
        private System.Windows.Forms.CheckBox chk2doparcial;
        private System.Windows.Forms.CheckBox chkfinal;
    }
}