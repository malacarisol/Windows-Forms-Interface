
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
    public partial class Ejercicio2 : Form
    {
        public struct Node
        {
            public Node(int first, int second, int third)
            {
                First = first;
                Second = second;
                Third = third;
            }

            public int First { get; set; }
            public int Second { get; set; }
            public int Third { get; set; }
            public string imprimir()
            {
                return First.ToString() + " " + Second.ToString() + " " + Third.ToString();
            }
        }
        static List<Node> visitados = new List<Node>();
        static int capacidad1, capacidad2, capacidad3;
        static int contenido1, contenido2, contenido3;
        static int objetivo1, objetivo2, objetivo3;        //contenidos a alcanzar

        private void splitContainer1_Panel2_BackgroundImageChanged(object sender, EventArgs e)
        {

        }

        private void Jugar_Click(object sender, EventArgs e)
        {
            if (txttcapacidad1.Text != "" && txttcapacidad2.Text != "" && txtcapacidad3.Text != "" &&
                txtContenidoInicial1.Text != "" && txtContenidoInicial2.Text != "" && txtContenidoInicial3.Text != "" &&
                txtContenidoFinal1.Text != "" && txtContenidoFinal2.Text != "" && txtContenidoFinal3.Text != "")
            {
                cmbDesde.Items.Clear();
                cmbHasta.Items.Clear();
                capacidad1 = Convert.ToInt32(txttcapacidad1.Text);
                capacidad2 = Convert.ToInt32(txttcapacidad2.Text);
                capacidad3 = Convert.ToInt32(txtcapacidad3.Text);
                contenido1 = Convert.ToInt32(txtContenidoInicial1.Text);
                contenido2 = Convert.ToInt32(txtContenidoInicial2.Text);
                contenido3 = Convert.ToInt32(txtContenidoInicial3.Text);
                objetivo1 = Convert.ToInt32(txtContenidoFinal1.Text);
                objetivo2 = Convert.ToInt32(txtContenidoFinal2.Text);
                objetivo3 = Convert.ToInt32(txtContenidoFinal3.Text);

                lblNiveles1.Visible = true;
                lblniveljaarra3.Visible = true;
                lblniveljarra2.Visible = true;
                lblNivelJarra1.Visible = true;

                lblcontenidoactual1.Visible = true;
                lblcontenidoactual2.Visible = true;
                lblcontenidoactual3.Visible = true;
                lblDesde.Visible = true;
                lblHasta.Visible = true;
                cmbDesde.Visible = true;
                cmbHasta.Visible = true;
                btnMovimiento.Visible = true;
                lblcontenidoactual1.Text = txtContenidoInicial1.Text;
                lblcontenidoactual2.Text = txtContenidoInicial2.Text;
                lblcontenidoactual3.Text = txtContenidoInicial3.Text;

                for (int i = 1; i < 4; i++)
                {
                    cmbHasta.Items.Add(i);
                    cmbDesde.Items.Add(i);
                }
                if (changeWater(contenido1, contenido2, contenido3) == false)
                {
                    MessageBox.Show("Combinacion Imposible");
                }
                visitados.Clear();
            }
            else MessageBox.Show("Por favor complete todos los campos");
        }

        public Ejercicio2()
        {
            InitializeComponent();

        }

        private void Resolver_Click_1(object sender, EventArgs e)
        {
            if (txttcapacidad1.Text != "" && txttcapacidad2.Text != "" && txtcapacidad3.Text != "" &&
                   txtContenidoInicial1.Text != "" && txtContenidoInicial2.Text != "" && txtContenidoInicial3.Text != "" &&
                   txtContenidoFinal1.Text != "" && txtContenidoFinal2.Text != "" && txtContenidoFinal3.Text != "")
            {
                capacidad1 = Convert.ToInt32(txttcapacidad1.Text);
            capacidad2 = Convert.ToInt32(txttcapacidad2.Text);
            capacidad3 = Convert.ToInt32(txtcapacidad3.Text);
            contenido1 = Convert.ToInt32(txtContenidoInicial1.Text);
            contenido2 = Convert.ToInt32(txtContenidoInicial2.Text);
            contenido3 = Convert.ToInt32(txtContenidoInicial3.Text);
            objetivo1 = Convert.ToInt32(txtContenidoFinal1.Text);
            objetivo2 = Convert.ToInt32(txtContenidoFinal2.Text);
            objetivo3 = Convert.ToInt32(txtContenidoFinal3.Text);

            string pasos_para_resolver = "Pasos: \n \n";

            if (changeWater(contenido1, contenido2, contenido3))
            {
                for (int i = 0; i < visitados.Count(); i++)
                {
                    pasos_para_resolver = pasos_para_resolver + visitados[i].imprimir() + "\n";

                }
                lblResolver.Text = pasos_para_resolver;
            }
            else MessageBox.Show("Combinacion Imposible ");
            visitados.Clear();
            }
            else MessageBox.Show("Por favor complete todos los campos");

        }

        private void btnMovimiento_Click(object sender, EventArgs e)
        {
            int actual1 = Convert.ToInt32(lblcontenidoactual1.Text); //jarra1
            int actual2 = Convert.ToInt32(lblcontenidoactual2.Text);
            int actual3 = Convert.ToInt32(lblcontenidoactual3.Text);
            int desde = Convert.ToInt32(cmbDesde.SelectedItem);
            int hasta = Convert.ToInt32(cmbHasta.SelectedItem);
            if (desde==1)
            {
                if(actual1>0)
                {
                    if (hasta == 2 && actual2 < capacidad2) //de 1 a 2
                    {
                        if (actual2 + actual1 <= capacidad2)
                        {
                            lblcontenidoactual2.Text = (actual1 + actual2).ToString();
                            lblcontenidoactual1.Text = 0.ToString();
                        }
                        else
                        {
                            lblcontenidoactual2.Text = capacidad2.ToString();
                            lblcontenidoactual1.Text = (actual1 - (capacidad2 - actual2)).ToString();
                        }
                    }
                    else if (hasta == 3 && actual3 < capacidad3)//de 1 a 3
                    {
                        if (actual3 + actual1 <= capacidad3)
                        {
                            lblcontenidoactual3.Text = (actual1 + actual3).ToString();
                            lblcontenidoactual1.Text = 0.ToString();
                        }
                        else
                        {
                            lblcontenidoactual3.Text = capacidad3.ToString();
                            lblcontenidoactual1.Text = (actual1 - (capacidad3 - actual3)).ToString();
                        }
                    }

                }
            }
            if (desde == 2)
            {
                if (actual2 > 0)
                {
                    if (hasta == 1 && actual1 < capacidad1) //de 2 a uno
                    {
                        if (actual2 + actual1 <= capacidad1)
                        {
                            lblcontenidoactual1.Text = (actual1 + actual2).ToString();
                            lblcontenidoactual2.Text = 0.ToString();
                        }
                        else
                        {
                            lblcontenidoactual1.Text = capacidad1.ToString();
                            lblcontenidoactual2.Text = (actual2 - (capacidad1 - actual1)).ToString();
                        }
                    }
                    else if (hasta == 3 && actual3 < capacidad3)// de 2 a 3
                    {
                        if (actual3 + actual2 <= capacidad3)
                        {
                            lblcontenidoactual3.Text = (actual2 + actual3).ToString();
                            lblcontenidoactual2.Text = 0.ToString();
                        }
                        else
                        {
                            lblcontenidoactual3.Text = capacidad3.ToString();
                            lblcontenidoactual2.Text = (actual2 - (capacidad3 - actual3)).ToString();
                        }
                    }

                }
            }
            if (desde == 3)
                {
                    if (actual3 > 0)
                    {
                        if (hasta == 1 && actual1 < capacidad1) //de 3 a 1
                        {
                            if (actual3 + actual1 <= capacidad1)
                            {
                                lblcontenidoactual1.Text = (actual1 + actual3).ToString();
                                lblcontenidoactual3.Text = 0.ToString();
                            }
                            else
                            {
                                lblcontenidoactual1.Text = capacidad1.ToString();
                                lblcontenidoactual3.Text = (actual3 - (capacidad1 - actual1)).ToString();
                            }
                        }
                        else if (hasta == 2 && actual2 < capacidad2)//de 3   a 2
                        {
                            if (actual3 + actual2 <= capacidad2)
                            {
                                lblcontenidoactual2.Text = (actual2 + actual3).ToString();
                                lblcontenidoactual3.Text = 0.ToString();
                            }
                            else
                            {
                                lblcontenidoactual2.Text = capacidad2.ToString();
                                lblcontenidoactual3.Text = (actual3 - (capacidad2 - actual2)).ToString();
                            }
                        }

                    }
                
            }

            if (Convert.ToInt32(lblcontenidoactual1.Text) == objetivo1 && Convert.ToInt32(lblcontenidoactual2.Text) == objetivo2 && Convert.ToInt32(lblcontenidoactual3.Text) == objetivo3)
            {
                MessageBox.Show("Felicitaciones! Has resuelto el acertijo \n");
                lblcontenidoactual1.Text = txtContenidoInicial1.Text;
                lblcontenidoactual2.Text = txtContenidoInicial2.Text;
                lblcontenidoactual3.Text = txtContenidoInicial3.Text;

            }
            
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
        }
        static bool visited(int contenido1, int contenido2, int contenido3)
        {
            for (int i = 0; i < visitados.Count(); i++)
            {
                if (visitados[i].First == contenido1 && visitados[i].Second == contenido2 && visitados[i].Third == contenido3)
                    return true;
            }
            return false;
        }
        static int min(int a, int b)
        {
            return a < b ? a : b;
        }
        static bool changeWater(int contenido1, int contenido2, int contenido3)
        {
            if (contenido1 == objetivo1 && contenido2 == objetivo2 && contenido3 == objetivo3)
            {
                Node nodonuevo = new Node(contenido1, contenido2, contenido3);
                visitados.Add(nodonuevo);
                Console.WriteLine("", contenido1, contenido2, contenido3);
                return true;
            }
            if (visited(contenido1, contenido2, contenido3) == false)
            {
                
                Node nodonuevo = new Node(contenido1, contenido2, contenido3);
                visitados.Add(nodonuevo);
                return changeWater(contenido1 + min(contenido2, (capacidad1 - contenido1)), contenido2 - min(contenido2, (capacidad1 - contenido1)), contenido3) || changeWater(contenido1, contenido2 - min(contenido2, (capacidad3 - contenido3)), contenido3 + min(contenido2, (capacidad3 - contenido3))) || changeWater(contenido1 - min(contenido1, (capacidad2 - contenido2)), contenido2 + min(contenido1, (capacidad2 - contenido2)), contenido3) || changeWater(contenido1, contenido2 + min(contenido3, (capacidad2 - contenido2)), contenido3 - min(contenido3, (capacidad2 - contenido2))) || changeWater(contenido1 + min(contenido3, (capacidad1 - contenido1)), contenido2, contenido3 - min(contenido3, (capacidad1 - contenido1))) || changeWater(contenido1 - min(contenido1, (capacidad3 - contenido3)), contenido2, contenido3 + min(contenido1, (capacidad3 - contenido3)));
            }
            else return false;
        }
        private void cmbDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (cmbDesde.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                cmbDesde.Text = "";
            }

        }

        private void cmbHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (cmbHasta.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                cmbHasta.Text = "";
            }
        }

        private void txttcapacidad1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txttcapacidad1.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txttcapacidad1.Text = "";
            }
        }

        private void txttcapacidad2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtContenidoInicial2.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtContenidoInicial2.Text = "";
            }

        }

        private void txtcapacidad3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtcapacidad3.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtcapacidad3.Text = "";
            }
        }

        private void txtContenidoInicial1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtContenidoInicial1.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtContenidoInicial1.Text = "";
            }

        }

        private void txtContenidoInicial2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtContenidoInicial2.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtContenidoInicial2.Text = "";
            }

        }

        private void txtContenidoInicial3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtContenidoInicial3.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtContenidoInicial3.Text = "";
            }
        }

        private void txtContenidoFinal1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtContenidoFinal1.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtContenidoFinal1.Text = "";
            }

        }

        private void txtContenidoFinal2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtContenidoFinal2.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtContenidoFinal2.Text = "";
            }

        }

        private void txtContenidoFinal3_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtContenidoFinal3.Text.Length >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                txtContenidoFinal3.Text = "";
            }
        }

    }
}
