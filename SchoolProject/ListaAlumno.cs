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
    public partial class ListaAlumno : Form
    {
        private List<Alumno> lisaAlumno=new List<Alumno>();
        public ListaAlumno(List<Alumno> lsAlumno)
        {
            InitializeComponent();

            lisaAlumno = lsAlumno;
        }

        private void ListaAlumno_Load(object sender, EventArgs e)
        {
            dgvListaAlumno.DataSource = lisaAlumno;
        }
        
    }
}
