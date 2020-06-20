namespace SchoolProject
{
    partial class Form1
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
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxAnnee = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dpkNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnVerAlumno = new System.Windows.Forms.Button();
            this.radioMasculino = new System.Windows.Forms.RadioButton();
            this.radioFemino = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Alumno";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.BackColor = System.Drawing.Color.PapayaWhip;
            this.txtNombreAlumno.ForeColor = System.Drawing.Color.DarkRed;
            this.txtNombreAlumno.Location = new System.Drawing.Point(195, 71);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(401, 22);
            this.txtNombreAlumno.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(195, 158);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(401, 22);
            this.txtApellido.TabIndex = 3;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "DNI";
            // 
            // TxtDNI
            // 
            this.TxtDNI.Location = new System.Drawing.Point(195, 240);
            this.TxtDNI.Name = "TxtDNI";
            this.TxtDNI.Size = new System.Drawing.Size(401, 22);
            this.TxtDNI.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha NAcimiento";
            // 
            // comboBoxAnnee
            // 
            this.comboBoxAnnee.FormattingEnabled = true;
            this.comboBoxAnnee.Location = new System.Drawing.Point(195, 438);
            this.comboBoxAnnee.Name = "comboBoxAnnee";
            this.comboBoxAnnee.Size = new System.Drawing.Size(401, 24);
            this.comboBoxAnnee.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grado";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(58, 568);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(112, 47);
            this.btnEnviar.TabIndex = 10;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(528, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 47);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dpkNacimiento
            // 
            this.dpkNacimiento.Location = new System.Drawing.Point(191, 339);
            this.dpkNacimiento.Name = "dpkNacimiento";
            this.dpkNacimiento.Size = new System.Drawing.Size(405, 22);
            this.dpkNacimiento.TabIndex = 12;
            // 
            // btnVerAlumno
            // 
            this.btnVerAlumno.Location = new System.Drawing.Point(267, 568);
            this.btnVerAlumno.Name = "btnVerAlumno";
            this.btnVerAlumno.Size = new System.Drawing.Size(136, 47);
            this.btnVerAlumno.TabIndex = 13;
            this.btnVerAlumno.Text = "Ver lista Alumno";
            this.btnVerAlumno.UseVisualStyleBackColor = true;
            this.btnVerAlumno.Click += new System.EventHandler(this.btnVerAlumno_Click);
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Location = new System.Drawing.Point(110, 514);
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Size = new System.Drawing.Size(159, 26);
            this.radioMasculino.TabIndex = 14;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Sexo Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // radioFemino
            // 
            this.radioFemino.AutoSize = true;
            this.radioFemino.Location = new System.Drawing.Point(293, 514);
            this.radioFemino.Name = "radioFemino";
            this.radioFemino.Size = new System.Drawing.Size(155, 26);
            this.radioFemino.TabIndex = 15;
            this.radioFemino.TabStop = true;
            this.radioFemino.Text = "Sexo Feminimo";
            this.radioFemino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 694);
            this.Controls.Add(this.radioFemino);
            this.Controls.Add(this.radioMasculino);
            this.Controls.Add(this.btnVerAlumno);
            this.Controls.Add(this.dpkNacimiento);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxAnnee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDNI);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombreAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAnnee;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dpkNacimiento;
        private System.Windows.Forms.Button btnVerAlumno;
        private System.Windows.Forms.RadioButton radioMasculino;
        private System.Windows.Forms.RadioButton radioFemino;
    }
}

