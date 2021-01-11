using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Malacari_Zgaib
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }
        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void ejercicio1_Click(object sender, EventArgs e)
        {  
            EjercicioUno formE = new EjercicioUno();
            formE.Show();

        }
        private void Ejercicio2_Click(object sender, EventArgs e)
        {
            Ejercicio2 formE = new Ejercicio2();
            formE.Show();
        }
        private void Ejercicio3_Click(object sender, EventArgs e)
        {
            Ejercicio3 formE = new Ejercicio3();
            formE.Show();
        }

        private void Ejercicio4_Click(object sender, EventArgs e)
        {
            Ejercicio4 formE = new Ejercicio4();
            formE.Show();
        }
    }
}