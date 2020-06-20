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
    public partial class FormNotas : Form
    {
        public FormNotas()
        {
            InitializeComponent();
        }

        private void FormNotas_Load(object sender, EventArgs e)
        {
            cargarcomboMateria();
        }
        private void cargarcomboMateria()
        {
            comboMateria.Items.Add("Geogrfia");
            comboMateria.Items.Add("Historia");
            comboMateria.Items.Add("matematicas");
            comboMateria.Items.Add("fisica");
            comboMateria.Items.Add("Literatura");
            comboMateria.Items.Add("Quimica");
            comboMateria.Items.Add("Ingles");
            comboMateria.Items.Add("Frances");
            comboMateria.Items.Add("Catechismo");
            comboMateria.Items.Add("Educacion fisica");
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
           if(validarCampos() == true)
            {
                if (Convert.ToInt32(txtNota.Text) < 0 || Convert.ToInt32(txtNota.Text) > 10)
                {
                    MessageBox.Show("LA nota no debe ser inferior a 0 o  superior a 10");

                }
            }

           
        }
        private bool validarCampos()
        {
            bool retorno = false;
            if(txtDNI.Text=="" || txtNota.Text == "")
            {
                retorno = false;
                MessageBox.Show("El campo Nota o Dni no debe ser vacio");

            }
            else
            {
                retorno = true;
            }
            return retorno;
        }
    }
}
