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
    public partial class EjercicioUno : Form
    {
        List<cQuesos> lista;                
        public EjercicioUno()
        {
            InitializeComponent();
            lista = Inicializar();
        }
        static List<cQuesos> Inicializar()
        {
            List<cQuesos> listaQ = new List<cQuesos>();
            cQuesos parmesano = new cQuesos();  
            parmesano.nombre = "parmesano";
            parmesano.peso = 500;
            parmesano.precio = 12000;
            listaQ.Add(parmesano);             //Agregamos un queso a la lista para que no empiece vacia
            return listaQ;
        }

        private void cQuesosBindingSource_CurrentChanged(object sender, EventArgs e)
        {  
            cQuesosBindingSource.DataSource = lista;             //Copiamos la lista de cQuesos a los datos de la Binding Source
        }
        private void voraz_Click(object sender, EventArgs e)
        {
            if (textWmax.Text == "")
            {
                MessageBox.Show("Debe ingresar un peso maximo");
                return;
            }
            float[] peso;                //Creamos arrrays para que el codigo sea mas legible, en lugar de usar lista[i].elemento
            float[] precio;
            string[] nombres;
            
            float wMax;   //Peso max de la mochila
          
            peso=new float[lista.Count];
            precio = new float[lista.Count];
            nombres = new string[lista.Count];
            wMax= float.Parse(textWmax.Text);
            
            for (int i=0;i<lista.Count;i++) 
                peso[i] = (float)lista[i].peso;     
                       
            for (int i = 0; i < lista.Count; i++)
                precio[i] = (float)lista[i].precio;

            for (int i = 0; i < lista.Count; i++)
                nombres[i] = lista[i].nombre;

            string[] robo = new string[nombres.Length+1];   //Guardamos en una lista los datos de los quesos que nos llevamos. En la ultima posicion el monto acumulado
            if (peso.Length > 1 && precio.Length > 1)         //Solo ordeno si hay +  de 1 elem.
                mergeSort(precio, peso, nombres, 0, precio.Length - 1);          //Ordena la lista de quesos por beneficio precio/peso
                                                                                 
            else if (peso.Length == 0 || precio.Length == 0)
            {
                MessageBox.Show("No hay quesos");
                return;
            }


            robo=Algoritmovoraz(peso, precio,nombres, wMax,robo);
            
            var message = string.Join(Environment.NewLine, robo);     

            MessageBox.Show("QUESOS ROBADOS: \n"+message);
        }
        private static string[] Algoritmovoraz(float[] Peso, float[] Precio, string[] Nombre, float Wmax, string[] Robo, float montoRobado = 0, float Wactual = 0, int i = 0)
        {
            if (Wactual == Wmax ||i>0 && Peso[i - 1] == Peso[Peso.Length - 1])    //caso base o si llegue al final de la lista
            {
                Robo[i] = "\n El monto robado es: "+ montoRobado.ToString();      //aca se guarda el monto final
                return Robo;
            }
            else
            {
                if (Peso[i] > Wmax - Wactual)   //Si el peso es mas grande que el volumen que me queda en la mochila
                {
                    float pesoAUX = Math.Abs(Wmax - Wactual);                               //_____________CORTO EL QUESO PARA QUE ENTRE
                    Wactual = Wactual + pesoAUX;
                    montoRobado = montoRobado+ ((Precio[i] / Peso[i])* pesoAUX );
                    Robo[i] = Nombre[i] + "\t" + pesoAUX +" kilos";               //Guardo el nombre y el peso del queso en la lista string
                }

                else if (Peso[i] <= Wmax - Wactual)   //si entra en la mochila lo guardo entero
                {
                    Wactual = Wactual + Peso[i];
                    montoRobado = montoRobado + Precio[i];
                    Robo[i] = Nombre[i] + "\t" + Peso[i] + " kilos";
                }
                
               i++;
                return Algoritmovoraz(Peso, Precio, Nombre,Wmax, Robo,montoRobado, Wactual, i);
            }
        }
        private static void merge(float[] precio, float[] peso, string[] nombres,int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m;

            //creamos arrays de mitades, temporales (subproblema)
            float[] mitadPrecio = new float[n1];     
            float[] mitad2Precio = new float[n2]; 
            float[] mitadPeso = new float[n1];
            float[] mitad2Peso = new float[n2];
            string[] mitadNombres = new string[n1];
            string[] mitad2Nombres = new string[n2];


            //Copia los datos originales a los array mitades
            for (i = 0; i < n1; i++)
            {
                mitadPrecio[i] = precio[l + i];
                mitadPeso[i] = peso[l + i];
                mitadNombres[i] = nombres[l + i];
            }
            for (j = 0; j < n2; j++)
            {
                mitad2Precio[j] = precio[m + 1 + j];
                mitad2Peso[j] = peso[m + 1 + j];
                mitad2Nombres[j] = nombres[m + 1 + j];
            }

            //une las mitades ordenadas en el array original
            i = 0; // Indice inicial de la primera mitad
            j = 0; //Indice inicial de la segunda mitad
            k = l; // Indice inicial del array union
            while (i < n1 && j < n2)
            {
                if (mitadPrecio[i] / mitadPeso[i] >= mitad2Precio[j] / mitad2Peso[j])
                {
                    precio[k] = mitadPrecio[i];
                    peso[k] = mitadPeso[i];
                    nombres[k] = mitadNombres[i];
                    i++;
                }
                else
                {
                    precio[k] = mitad2Precio[j];
                    peso[k] = mitad2Peso[j];
                    nombres[k] = mitad2Nombres[j];
                    j++;
                }
                k++;
            }

            //Si hay elementos restantes en las primeras mitades, los copia al array original
            while (i < n1)
            {
                precio[k] = mitadPrecio[i];
                peso[k] = mitadPeso[i];
                nombres[k] = mitadNombres[i];
                i++;
                k++;
            }
            
            while (j < n2)
            {
                precio[k] = mitad2Precio[j];
                peso[k] = mitad2Peso[j];
                nombres[k] = mitad2Nombres[j];
                j++;
                k++;
            }
        }
        private static void mergeSort(float[] precio, float[] peso,string[] nombres,int left, int right)
        {
            if (left < right)
            {
               //sacamos indice de la mitad
                int m = left + (right - left) / 2;

                //Ordenamos primera y segunda mitad
                mergeSort(precio, peso,nombres, left, m);
                mergeSort(precio, peso,nombres, m + 1, right);

                merge(precio, peso,nombres, left, m, right);
            }
        }
        private void dinamica_Click(object sender, EventArgs e)
        {
            if (textWmax.Text == "")
            {
                MessageBox.Show("Debe ingresar un peso maximo");
                return;
            }
            else
            {
                float[] peso = new float[lista.Count];    //Creamos arrays para que el codigo sea mas legible
                float[] precio = new float[lista.Count];
                string[] nombres = new string[lista.Count];
                float wMax = float.Parse(textWmax.Text);

                for (int i = 0; i < lista.Count; i++)
                {
                    peso[i] = (float)lista[i].peso;
                    precio[i] = (float)lista[i].precio;
                    nombres[i] = lista[i].nombre;
                }

                if (peso.Length == 0 || precio.Length == 0)
                {
                    MessageBox.Show("No hay quesos");
                    return;
                }

                float[,] array = new float[peso.Length + 1, (int)wMax + 1];   //matriz de programacion dinamica, la utilizamos despues para el analisis
                int[] QuesosRobados = Algoritmodinamico(array, peso, precio, wMax);   //Esta funcion devuelve un array con la posicion individual de los quesos robados
                string[] auxDatos = new string[QuesosRobados.Length];
                float montoRobado = 0;

                if (QuesosRobados[0] == -1)   //Metodo propio para reconocer una posicion existente
                {
                    MessageBox.Show("El monto robado es: 0");
                    return;
                }


                for (int j = 0; j < QuesosRobados.Length; j++)
                {
                    if (QuesosRobados[j] != -1)
                    {
                        auxDatos[j] = nombres[QuesosRobados[j]] + "\t" + peso[QuesosRobados[j]] + " kilos";    //Con las posiciones, obtenemos los datos de los quesos
                        montoRobado = montoRobado + precio[QuesosRobados[j]];   //De igual manera se calcula el monto
                    }
                }
                var message = string.Join(Environment.NewLine, auxDatos);

                MessageBox.Show("QUESOS ROBADOS: \n" + message + "\n" + "El monto Robado es " + montoRobado);
            }
        }
        static int[] Algoritmodinamico(float[,] arr, float[] peso,float[] precio,  float Wmax)
        {
            int i = 0;
            int b = 0;
            int j = 0;

            int[] posiciones = new int[peso.Length+1];


            for ( i = 0; i <= peso.Length; i++)
            {
               posiciones[i] = -1;    ///lenamos el array de las posiciones de los quesos con -1 (posicion incoherente)
               for ( j = 0; j <=Wmax; j++)
                {
                    if (i == 0 || j == 0)
                        arr[i, j] = 0;
                    else if (peso[i - 1] <= j)
                        arr[i, j] = max(precio[i - 1] + arr[i - 1, (j - (int)peso[i - 1])], arr[i - 1, j]); //se compara si la suma de los anteriores quesos es mas alta que la del peso actual
                    else
                        arr[i, j] = arr[i - 1, j];    //si no, se guarda la ultima suma mas alta
                }
            }

            i = i - 1;
            j = j - 1;

            while(i > 0 && j > 0)    //se busca obtener las posiciones de las sumas
            {
                if (arr[i, j] != arr[i - 1, j])     //nos fijamos en que momento se fueron agregando quesos
                {  
                    i = i - 1;
                    j = j - (int)peso[i];
                    posiciones[b] = i; 
                    b++;
                }

                else i = i - 1;
            }

            return posiciones;
        }
        static float max(float a, float b)
        {
            if (a > b)
                return a;
            else return b;
        }
         
        
        //Se controla el ingreso correcto de los datos
        private void pesoTextBox_KeyPress(object sender, KeyPressEventArgs e)      
        {
          if ((e.KeyChar != '.')&&!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
           {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
           }
           if (pesoTextBox.TextLength >= 8)
           { 
                MessageBox.Show("El numero es demasiado grande");  //Porque sino hay overflow 
                e.Handled = true;
                pesoTextBox.Clear();
           }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void nombreTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)))
            {
                MessageBox.Show("Solo puede ingresar letras");
                e.Handled = true;
            }
        }

        private void precioTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (precioTextBox.TextLength >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                precioTextBox.Clear();
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void text1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (textWmax.TextLength >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                textWmax.Clear();
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textWmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != '.') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (textWmax.TextLength >= 8)
            {
                MessageBox.Show("El numero es demasiado grande");
                e.Handled = true;
                textWmax.Clear();
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
