using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolProject
{
    public partial class Form1 : Form
    {
        private List<Alumno> miListaAlumno = new List<Alumno>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarCombo();
        }
        private void cargarCombo()
        {
            comboBoxAnnee.Items.Add("7ème");
            comboBoxAnnee.Items.Add("8eme");
            comboBoxAnnee.Items.Add("9eme");
            comboBoxAnnee.Items.Add("3ème");
            comboBoxAnnee.Items.Add("2ème");
            comboBoxAnnee.Items.Add("Rheto");
            comboBoxAnnee.Items.Add("Philo");
            
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
          
            try
            {

               
                if (validarCampos() == true)
                {
                    Alumno miAlumno = new Alumno();
                    miAlumno.nombreAlumno = txtNombreAlumno.Text;
                    miAlumno.Apellido = txtApellido.Text;
                    miAlumno.anee = comboBoxAnnee.SelectedItem.ToString();
                    miAlumno.dni = TxtDNI.Text;
                    miAlumno.fechaNacimiento = dpkNacimiento.Value;
                    if (radioFemino.Checked)
                    {
                        miAlumno.sexo = "feminino";
                    }
                    else
                    {
                        miAlumno.sexo = "Masculino";
                    }
                    miListaAlumno.Add(miAlumno);
                    vaciarCampo();
                    ListaAlumno miform = new ListaAlumno(miListaAlumno);
                    miform.Show();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
        private bool validarCampos()
        {
            bool retorno = false;
            if (txtNombreAlumno.Text == "" || txtApellido.Text == "" || TxtDNI.Text == "")
            {
                retorno = false;
                MessageBox.Show("El campo NombreAlumno, Apellido o Dni no debe ser vacio");

            }
            else
            {
                retorno = true;
            }
            return retorno;
        }

        private void vaciarCampo()
        {
            txtApellido.Text = "";
            txtNombreAlumno.Text = "";
            TxtDNI.Text = "";
            dpkNacimiento.CustomFormat = " ";
            comboBoxAnnee.Text="";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            vaciarCampo();
        }

        private void btnVerAlumno_Click(object sender, EventArgs e)
        {
                
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
