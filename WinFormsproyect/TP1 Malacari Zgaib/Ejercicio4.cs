using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Malacari_Zgaib
{
    public partial class Ejercicio4 : Form
    {
        List<Objeto> lista = new List<Objeto>();
             public const int RUN = 32;
        public Ejercicio4()
        {
            InitializeComponent();
        }
   
        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            objetoBindingSource.DataSource = lista;
            for (int i=1;i<5;i++)
                cmbCriterioOrdenamiento.Items.Add(i);
            cmbCriterioOrdenamiento.Text = "1";
            lblcriterio.Text = "Criterio de Ordenamiento:\n\n1. Paises \n2. Item Type \n3. Order Number \n4. Units Sold";
        }
        private void btnLeer_Click(object sender, EventArgs e)
        {
            lista.Clear();
            dataGridView1.DataSource = null;
            if (txtCantidadFilas.Text == "")//default
            { 
                txtCantidadFilas.Text = "3";
                DialogResult msj = MessageBox.Show("Como usted no especifico la cantidad de lineas que quiso leer del archivo, le facilitamos su trabajo, eligiendo 3 lineas. Quiere especificar otra cantidad?","ATENCION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (msj == DialogResult.Yes)
                { 
                    txtCantidadFilas.Text = ""; 
                    return;
                }
                
            }
           
            
            LeerArchivo();
            dataGridView1.DataSource = lista;
        }
        private void LeerArchivo()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Todos los archivos|*.*|Archivos csv|*.csv";
            openFileDialog1.FilterIndex = 2;
            int cantidadFilas = Convert.ToInt32(txtCantidadFilas.Text);
            int i = 0; //Para ir linea por linea y finalizar en la indicada
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(openFileDialog1.FileName))
                {

                    while (!reader.EndOfStream && i != cantidadFilas + 1)//quiero leer 5 lineas a partir de la que esta despues de country, itemType etc
                    {
                        var line = reader.ReadLine();
                        var values = line.Split(';');
                        Objeto aniadir = new Objeto(values[0], values[1], values[2], values[3]);
                        lista.Add(aniadir);
                        i++;
                    }

                    lista.Remove(lista.ElementAt(0));//no incluimos en la lista para ordenamiento la primer linea de conutry, item etc
                }
            }
        }
        private void BubbleSort()
        {
            int criterio;
            criterio = Convert.ToInt32(cmbCriterioOrdenamiento.SelectedItem);
            //List<Objeto> aux = new List<Objeto>();
            Objeto aux;
            if (criterio == 1)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    for (int j = 0; j < lista.Count - 1; j++)
                    {
                        if (lista[j].pais.CompareTo(lista[j + 1].pais) > 0)
                        {
                            aux = lista[j + 1];
                            lista[j + 1] = lista[j];
                            lista[j] = aux;
                        }
                    }
                }
            }
            else if (criterio == 2)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    for (int j = 0; j < lista.Count - 1; j++)
                    {
                        if (lista[j].itemType.CompareTo(lista[j + 1].itemType) > 0)
                        {
                            aux = lista[j + 1];
                            lista[j + 1] = lista[j];
                            lista[j] = aux;
                        }
                    }
                }
            }
            else if (criterio == 3)
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    for (int j = 0; j < lista.Count - 1; j++)
                    {
                        if (lista[j].orderID.CompareTo(lista[j + 1].orderID) > 0)
                        {
                            aux = lista[j + 1];
                            lista[j + 1] = lista[j];
                            lista[j] = aux;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < lista.Count; i++)
                {
                    for (int j = 0; j < lista.Count - 1; j++)
                    {
                        if (lista[j].unitsSold.CompareTo(lista[j + 1].unitsSold) > 0)
                        {
                            aux = lista[j + 1];
                            lista[j + 1] = lista[j];
                            lista[j] = aux;
                        }
                    }
                }
            }

        }
        private void merge(int l, int m, int r)
        {
            int i, j, k;
            int n1 = m - l + 1;
            int n2 = r - m; //r<m
            //creamos arrays de mitades, temporales (subproblema)

            int criterio;
            criterio = Convert.ToInt32(cmbCriterioOrdenamiento.SelectedItem);

            List<Objeto> mitad =new List<Objeto>(n1);
            List<Objeto> mitad2 = new List<Objeto>(n2);
            //Copia los datos originales a los array mitades
            for (i = 0; i < n1; i++)
            {
                mitad.Add(lista[l + i]);

            }
            for (j = 0; j < n2; j++)
            {
                mitad2.Add(lista[m + 1 + j]);

            }

            //une las mitades ordenadas en el array original
            i = 0; // Indice inicial de la primera mitad
            j = 0; //Indice inicial de la segunda mitad
            k = l; // Indice inicial del array union
            if (criterio == 1)
            {
                while (i < n1 && j < n2)
                {
                    if (mitad[i].pais.CompareTo(mitad2[j].pais) < 0)
                    {
                        lista[k] = mitad[i];
                        i++;
                    }
                    else
                    {
                        lista[k] = mitad2[j];
                        j++;
                    }
                    k++;
                }
            }
            else if (criterio == 2)
            {
                while (i < n1 && j < n2)
                {
                    if (mitad[i].itemType.CompareTo(mitad2[j].itemType) < 0)
                    {
                        lista[k] = mitad[i];
                        i++;
                    }
                    else
                    {
                        lista[k] = mitad2[j];
                        j++;
                    }
                    k++;
                }
            }
            else if (criterio == 3)
            {
                while (i < n1 && j < n2)
                {
                    if (mitad[i].orderID.CompareTo(mitad2[j].orderID) < 0)
                    {
                        lista[k] = mitad[i];
                        i++;
                    }
                    else
                    {
                        lista[k] = mitad2[j];
                        j++;
                    }
                    k++;
                }
            }
            else
            {
                while (i < n1 && j < n2)
                {
                    if (mitad[i].unitsSold.CompareTo(mitad2[j].unitsSold) < 0)
                    {
                        lista[k] = mitad[i];
                        i++;
                    }
                    else
                    {
                        lista[k] = mitad2[j];
                        j++;
                    }k++;
                }
            }
           

            //Si hay elementos restantes en las primeras mitades, los copia al array original
            while (i < n1)
            {
                lista[k] = mitad[i];
                k++;
                i++;
               
            }

            while (j < n2)
            {
                lista[k] = mitad2[j];
                k++;
                j++;
                
            }
        }
        private void mergeSort(int left, int right)
        {
            List<Objeto> aux = new List<Objeto>();
            if (left < right )
            {
                //sacamos indice de la mitad

                int m = left + (right - left) / 2;
                //Ordenamos primera y segunda mitad
                mergeSort(left, m);
                mergeSort(m + 1, right);

                merge(left, m, right);
            }
        }
        private void ShellSort()
        {
            int criterio;
            criterio = Convert.ToInt32(cmbCriterioOrdenamiento.SelectedItem);
            int n =lista.Count;
            //          string temp,temp1,temp2,temp3,temp4;
            Objeto aux;
            // empezamos con una brecha grande y despues se reduce
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i += 1)
                {

                    aux = lista[i];
                    int j;
                    if (criterio == 1)
                    {
                        for (j = i; j >= gap && lista[j - gap].pais.CompareTo(aux.pais) > 0; j -= gap)
                        { //estamos asignando dos veces lo mismo, pero para mantener el orden lo necesitamos
                            lista[j] = lista[j - gap];
                        }
                        
                    }
                    else if (criterio == 2)
                    {
                        for (j = i; j >= gap && lista[j - gap].itemType.CompareTo(aux.itemType) > 0; j -= gap)
                        { //estamos asignando dos veces lo mismo, pero para mantener el orden lo necesitamos
                            lista[j] = lista[j - gap];
                        }
                       
                    }
                    else if (criterio == 3)
                    {
                        for (j = i; j >= gap && lista[j - gap].orderID.CompareTo(aux.orderID) > 0; j -= gap)
                        { //estamos asignando dos veces lo mismo, pero para mantener el orden lo necesitamos
                            lista[j] = lista[j - gap];
                        }
                    
                    }
                    else 
                    {
                        for (j = i; j >= gap && lista[j - gap].unitsSold.CompareTo(aux.unitsSold) > 0; j -= gap)
                        { //estamos asignando dos veces lo mismo, pero para mantener el orden lo necesitamos
                            lista[j] = lista[j - gap];
                        }
                        
                    }
                    lista[j] = aux;
                }

            }
        }
        private void quickSort(int low,int high)
        {
            if (low < high)
            {
                //pi es el indice de particionamiento
                int pi = Ultimopartition( low, high);

                quickSort( low, pi - 1);  // antes de pi
                quickSort(pi + 1, high); // despuss de  pi
            }
        }
        private int Ultimopartition(int low,int high)
        {
            int i = (low - 1);
            int criterio;
            criterio = Convert.ToInt32(cmbCriterioOrdenamiento.SelectedItem);
            string pivot;
            if (criterio == 1)
            {
                pivot = lista[high].pais;
                
                for (int j = low; j < high; j++)
                {
                    // If current element is smaller  
                    // than the pivot 
                    if (lista[j].pais.CompareTo(pivot) < 0)
                    {
                        i++;

                        // swap arr[i] and arr[j] 
                        Objeto temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }
            else if (criterio == 2)
            {
                pivot = lista[high].itemType;
               
                for (int j = low; j < high; j++)
                {
                    // If current element is smaller  
                    // than the pivot 
                    if (lista[j].itemType.CompareTo(pivot) < 0)
                    {
                        i++;

                        // swap arr[i] and arr[j] 
                        Objeto temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }
            else if (criterio == 3)
            {
                pivot = lista[high].orderID;
                
                for (int j = low; j < high; j++)
                {
                    // If current element is smaller  
                    // than the pivot 
                    if (lista[j].orderID.CompareTo(pivot) < 0)
                    {
                        i++;
                        Objeto temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }
            else
            {
                pivot = lista[high].unitsSold;
               
                for (int j = low; j < high; j++)
                {
                    // If current element is smaller  
                    // than the pivot 
                    if (lista[j].unitsSold.CompareTo(pivot) < 0)
                    {
                        i++;
                        Objeto temp = lista[i];
                        lista[i] = lista[j];
                        lista[j] = temp;
                    }
                }
            }

           // swap arr[i+1] and arr[high] (or pivot) 
            Objeto temp1 = lista[i + 1];
            lista[i + 1] = lista[high];
            lista[high] = temp1;

            return i + 1;
        }
        public static string getMax(string[] arr)
        {
            string max = arr[0];
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].CompareTo(max)>0)
                    max = arr[i];
            return max;
        }
        private void insertionSort(int left, int right)
        {
            int criterio;
            criterio = Convert.ToInt32(cmbCriterioOrdenamiento.SelectedItem);

            for (int i = left + 1; i <= right; i++)
            {
                Objeto temp;
                 temp = lista[i];
                int j = i - 1;
               
                if (criterio == 1)
                {
                    while (j >= left && lista[j].pais.CompareTo(temp.pais) > 0)
                    {
                        lista[j + 1] = lista[j];
                        j--;
                    }
                }
                else if (criterio == 2)
                {
                    while (j >= left &&lista[j].itemType.CompareTo(temp.itemType) > 0)
                    {
                        lista[j + 1] = lista[j];
                        j--;
                    }
                }
                else if (criterio == 3)
                {
                    while (j >= left && lista[j].orderID.CompareTo(temp.orderID) > 0)
                    {
                        lista[j + 1] = lista[j];
                        j--;
                    }
                }
                else
                {
                    while (j >= left && lista[j].unitsSold.CompareTo(temp.unitsSold) > 0)
                    {
                        lista[j + 1] = lista[j];
                        j--;
                    }
                }
                lista[j + 1] = temp;
                
            }
        }
        private void timSort()
        {
            int n = lista.Count;
            //ordenamos arrays individuales de tamanio RUN (32)
            for (int i = 0; i < n; i += RUN)
                insertionSort(i, Math.Min((i + 31), (n - 1)));  
            for (int i = RUN; i < n; i = 2 * i)
            {

                for (int left = 0; left < n;left += 2 * i)
                {

                    int mid = left + i - 1;
                    if (mid > n)
                        break;
                    int right = Math.Min((left +(2 * i )- 1), (n - 1));

                    merge(left, mid, right);//r<m
                }
            }
        }
     
        private void btnBubble_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("Es un sencillo algoritmo de ordenamiento que funciona revisando cada elemento de la lista que va a ser ordenada con el siguiente," +
                " intercambiándolos de posición si están en el orden equivocado, hasta que la lista quede completamente ordenada. Tiempo de ejecucion O(n^2)", "Bubble Sort", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
         
            if (msj == DialogResult.OK) 
            {
                var watch = new System.Diagnostics.Stopwatch();

                watch.Start();
                BubbleSort();
                watch.Stop();
                string a = watch.ElapsedMilliseconds.ToString();
                MessageBox.Show("execution time " + a + "ms");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
      
           
        }
        private void btnShell_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("Es una ordenación por inserción que usa la ordenación por inserción lineal para ordenar pequeñas sublistas para producir sublistas más grandes parcialmente ordenadas. De acuerdo con el teorema de Poonen, el tiempo de ejecucion en el peor caso es de O(n(log n)^2)", "Shell Sort", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (msj == DialogResult.OK)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                ShellSort();
                watch.Stop();
                string a = watch.ElapsedMilliseconds.ToString();
                MessageBox.Show("execution time " + a + "ms");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
        }
        private void btnMerge_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("Siguiendo el paradigma de dividir y conquistar, Merge Sort divide la secuencia de n elementos en dos subsecuencias de n/2 elementos. Luego, ordena dichas subsecuencias recursivamente, para terminar uniendo las subsecuencias ordenadas y llegar a un array de n elementos ordenados. Tiempo de ejecucion logaritmico (O(n log n))", "Merge Sort", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (msj == DialogResult.OK)
            {
                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                mergeSort(0, lista.Count - 1);
                watch.Stop();
                string a = watch.ElapsedMilliseconds.ToString();
                MessageBox.Show("execution time " + a + "ms");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
        }
        private void btnQuick_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("Construido sobre una base de ordenamiento parcial, se trata de particionar un array alrededor de un elemento pivote. Luego de elegir dicho elemento, coloca los elementos del array tal que todos antes del pivot sean menores a el, con los mayores a la derecha. Esos elementos se ordenan recursivamente. A diferencia del Merge Sort, Quick Sort llama a la recursion despues del particionamiento. El Tiempo de ejecucion en el peor caso,aunque es raro, es (O(^2)). Normalmente toma O(nlog n)", "Quick Sort", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (msj == DialogResult.OK)
            {

                var watch = new System.Diagnostics.Stopwatch();
                quickSort(0, lista.Count - 1);

                watch.Stop();
                string a = watch.ElapsedMilliseconds.ToString();
                MessageBox.Show("execution time " + a + "ms");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            DialogResult msj = MessageBox.Show("Si la lista tiene menos de 32 elementos, Tim Sort ejecuta un orden por insercion, el cual mira los elementos uno por uno y luego construye la lista ordenada insertando el elemento en la posicion correcta. Si la lista es mas grande, el algoritmo pasa por la lista de izquierda a derecha, identificando alguna secuencia que se pueda 'mergear' con la secuencia identificada anteriormente, como dice el mismo Tim, inteligentemente. Tiempo de ejecucion en el peor caso: O(n log n) ", "Tim Sort", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (msj == DialogResult.OK)
            {

                var watch = new System.Diagnostics.Stopwatch();
                watch.Start();
                timSort();
                watch.Stop();
                string a = watch.ElapsedMilliseconds.ToString();
                MessageBox.Show("execution time " + a + "ms");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = lista;
            }
        }
        private void objetoBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            objetoBindingSource.DataSource = lista;
           // objetoBindingSource.DataSource = Enum.GetNames(typeof(Objeto));
        }

        private void cmbCriterioOrdenamiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ( !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if ((e.KeyChar > '4'))
            {
                MessageBox.Show("Solo puede ingresar del 1 al 4");
                e.Handled = true;
            }

        }

        private void txtCantidadFilas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Solo puede ingresar numeros");
                e.Handled = true;
            }
            if (txtCantidadFilas.Text!=""&&Convert.ToInt32(txtCantidadFilas.Text)> 1048576)
            {
                MessageBox.Show("Solo puede ingresar hasta 1048576");
                e.Handled = true;
            }
        }
    }
}
