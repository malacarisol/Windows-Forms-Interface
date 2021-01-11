using Microsoft.Msagl.Drawing;
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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer;
        Microsoft.Msagl.Drawing.Graph graph;
        List<(string, List<string>)> listaAdy;

        static bool[,] matrizdeAdyacencia;
        private void Ejercicio3_Load(object sender, EventArgs e)
        {
            viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

            graph = new Microsoft.Msagl.Drawing.Graph("graph");
            //Hacemos la lista y matriz de adyacencia
            ActualizarAdyacencias();

            //actualizo viewer
            viewer.Graph = graph;
            splitContainer1.Panel2.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(viewer);
            splitContainer1.Panel2.ResumeLayout();
        }
        private void HacerMatriz()
        {
            matrizdeAdyacencia=new bool[graph.NodeCount, graph.NodeCount];
            int fuente = -1;
            int destino = -1;
            // recorro todos los bordes
            foreach (Microsoft.Msagl.Drawing.Edge borde in graph.Edges)
            {
                // por cada borde, me fijo cual es el fuente y cual es el destino
                for (int i = 0; i < graph.NodeCount; i++)
                {
                    if (borde.SourceNode.Attr.Id == graph.Nodes.ElementAt(i).Attr.Id)
                    {
                        fuente = i; // me guardo la posición del nodo fuente
                    }
                    else if (borde.TargetNode.Attr.Id == graph.Nodes.ElementAt(i).Attr.Id)
                    {
                        destino = i; // me guardo la posición del nodo destino
                    }
                }
                // asumiendo que es no direccional, igualo a 1 en las dos posiciones, para indicar que se relacionan
                matrizdeAdyacencia[fuente, destino] = true;
                matrizdeAdyacencia[destino, fuente] = true;

            }
        } 
        private void HacerLista()
        {
            listaAdy= new List<(string, List<string>)>();
            for (int i = 0; i < graph.NodeCount; i++)
            {
                listaAdy.Add((graph.Nodes.ElementAt(i).LabelText, new List<string>()));
            }
            foreach (Microsoft.Msagl.Drawing.Edge borde in graph.Edges)
            {
                for (int i = 0; i < graph.NodeCount; i++)
                {
                    if(i<graph.EdgeCount)
                        graph.Edges.ElementAt(i).Attr.ArrowheadLength = 0.1; //flecha pequenia para que parezca bidireccional
                    if (borde.SourceNode.Attr.Id.Equals(graph.Nodes.ElementAt(i).Attr.Id))
                    {
                        listaAdy.ElementAt(i).Item2.Add(borde.TargetNode.Attr.Id);
                    }
                    else if (borde.TargetNode.Attr.Id.Equals(graph.Nodes.ElementAt(i).Attr.Id))
                    {
                        listaAdy.ElementAt(i).Item2.Add(borde.SourceNode.Attr.Id);
                    }
                }

            }
        }
        private void ActualizarAdyacencias()
        {
            HacerMatriz();
            HacerLista();
        }
        private bool ElegirColoresBacktracking(int[] coloresUsados,int nodoactual,int cantidadColores = 8)
        {
            if (nodoactual == graph.NodeCount)  //funcion para asignar color a los nodos adyacentes por medio de backtracking
                return true;                                         //colores usados tiene el color correspondiente al numero de nodo(posicion=numero de nodo)
            for (int i=1;i<=cantidadColores;i++)
            {
                if(SePuedeUsar(nodoactual,i,coloresUsados))
                {
                    coloresUsados[nodoactual] = i;              //Actualizo el color de la lista
                    if(ElegirColoresBacktracking(coloresUsados,nodoactual + 1, cantidadColores))
                            return true;
                    
                    coloresUsados[nodoactual] = 0;
                }
            }
            return false;

        }
        private bool SePuedeUsar(int nodoActual,int colorActual,int[] coloresUsados)
        {
            for (int i=0;i<graph.NodeCount;i++)
            {
                if (matrizdeAdyacencia[nodoActual, i] == true && colorActual == coloresUsados[i])
                {
                    return false;
                }
            }
            return true;
        }
        private void Decolorear()
        {
            for(int i=0;i<graph.NodeCount;i++)
                graph.FindNode(listaAdy.ElementAt(i).Item1).Attr.Color= Microsoft.Msagl.Drawing.Color.Black; 
        }
        private void Colorear()
        { 
            Decolorear(); //decolora para comenzar con los nodos en negro
            int[] coloresUsados = new int[graph.NodeCount];
            if (ElegirColoresBacktracking(coloresUsados, 0))
                pintarnodos(coloresUsados);

            //actualizo
            viewer.Graph = graph;
            splitContainer1.Panel2.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(viewer);
            splitContainer1.Panel2.ResumeLayout();
        }
        private void pintarnodos(int[] coloresusados)
        { 
            for (int i = 0; i < graph.NodeCount; i++)
                graph.FindNode(listaAdy.ElementAt(i).Item1).Attr.Color = setColor(coloresusados.ElementAt(i));
        }
        private Microsoft.Msagl.Drawing.Color setColor(int i)
        {
            switch(i)
            {
                case 0:
                    return (Microsoft.Msagl.Drawing.Color.Black);
                case 1:
                    return (Microsoft.Msagl.Drawing.Color.Red);
                case 2:
                    return (Microsoft.Msagl.Drawing.Color.Yellow);
                case 3:
                    return (Microsoft.Msagl.Drawing.Color.Turquoise);
                case 4:
                    return (Microsoft.Msagl.Drawing.Color.Violet);
                case 5:
                    return (Microsoft.Msagl.Drawing.Color.Orange);
                case 6:
                    return (Microsoft.Msagl.Drawing.Color.Green);
                case 7:
                    return (Microsoft.Msagl.Drawing.Color.Blue);
                default:
                    return Microsoft.Msagl.Drawing.Color.Black;
            }
        }
        private int getPos(Node n)
        { 
            int i;
            foreach(Microsoft.Msagl.Drawing.Node nodo in graph.Nodes)
            {
                i= 0;
                if (n == nodo)
                    return i;
                i++;
            }return -1;


        }
        private void AniadirRandom()
        {
            string palabraRandom = GetRandomAlphaNumeric();
            graph.AddNode(palabraRandom); //Asigno IDs
            cmbDesde.Items.Add(palabraRandom);
            cmbHasta.Items.Add(palabraRandom);
            ActualizarAdyacencias();
            //actualizo viewer
            viewer.Graph = graph;
            splitContainer1.Panel2.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(viewer);
            splitContainer1.Panel2.ResumeLayout();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            // Función que dispara al clickearse el btnAgregar. Agrega un nodo al graph
            // Si un nodo con el mismo nombre no fue agregado anteriormente, lo agrego a mis comboBoxs.
            Microsoft.Msagl.Drawing.Node nodoAux = graph.Nodes.FirstOrDefault(q => q.Id == txtNombreNodo.Text);
            if (nodoAux == null)
            {

                graph.AddNode(txtNombreNodo.Text).Attr.Id = txtNombreNodo.Text;
                graph.FindNode(txtNombreNodo.Text).Attr.Color = Microsoft.Msagl.Drawing.Color.Black; //por default color negro

                //actualizo comobo box
                cmbDesde.Items.Add(txtNombreNodo.Text);
                cmbHasta.Items.Add(txtNombreNodo.Text);


                //actualizo lista y matriz adyacencia

                ActualizarAdyacencias();  //actualizo
                viewer.Graph = graph;
                splitContainer1.Panel2.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(viewer);
                splitContainer1.Panel2.ResumeLayout();

            }
           
            txtNombreNodo.Text = " ";
        }
 
        private void agregarCon_Click(object sender, EventArgs e)
        {

            if (txtNombreConexion.Text == "")
            {
                MessageBox.Show("Por favor complete el nombre de la conexion");
                
                return;
            }

            string nombre = txtNombreConexion.Text;

            if(graph.FindNode(cmbDesde.Text)==null||graph.FindNode(cmbHasta.Text)==null)
            {
                if (graph.FindNode(cmbHasta.Text) == null&& graph.FindNode(cmbDesde.Text) != null)
                       MessageBox.Show("ERROR: el nodo hasta no existe");
               
                else if (graph.FindNode(cmbDesde.Text) == null&&graph.FindNode(cmbHasta.Text) != null)
                       MessageBox.Show("ERROR: el nodo desde no existe");
               
                else
                    MessageBox.Show("ERROR: los nodos no existen");

                cmbDesde.Text = " ";
                cmbHasta.Text = " ";

                return;
            }

            graph.AddEdge(cmbDesde.Text, cmbHasta.Text).Attr.Id = txtNombreConexion.Text;

            for (int i = 0; i < graph.EdgeCount; i++)
            {
                if (graph.Edges.ElementAt(i).Attr.Id.Equals(nombre))
                {
                    //punta de la flecha pequenia paraq parezca no direccional
                    graph.Edges.ElementAt(i).Attr.ArrowheadLength = 0.1; //flecha pequenia para q parezca no direccionado
                    graph.Edges.ElementAt(i).Attr.Weight = Convert.ToInt32(numPesoConexion.Value);
                }
            }

            //agrego a la lista de adyacencia los target node y source node de la ultima conexion aniadida

            ActualizarAdyacencias();
            if (!(graph.FindNode(listaAdy.ElementAt(0).Item1).Attr.Color == Microsoft.Msagl.Drawing.Color.Black))
                Colorear();

            // Actualizo el mapa
            viewer.Graph = graph;
            splitContainer1.Panel2.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(viewer);
            splitContainer1.Panel2.ResumeLayout();
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
           
            Microsoft.Msagl.Drawing.Node nodoAux = graph.Nodes.FirstOrDefault(q => q.Id == txtQuitar.Text);
            if (nodoAux != null)
            {
                graph.RemoveNode(graph.FindNode(txtQuitar.Text));
                cmbDesde.Items.Remove(txtQuitar.Text);
                cmbHasta.Items.Remove(txtQuitar.Text);
                //actualizo lista y matriz adyacencia
                ActualizarAdyacencias();
                //actualizo viewer
                viewer.Graph = graph;
                splitContainer1.Panel2.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                splitContainer1.Panel2.Controls.Add(viewer);
                splitContainer1.Panel2.ResumeLayout();

            }
        }

        private void btnColorear_Click(object sender, EventArgs e)
        {
            Colorear();
        }

        private void btnDecolorear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hola");
            Decolorear();
        }

        public void btnAgregarNodos_Click(object sender, EventArgs e)
        {
            
            //agrego nodos
            graph.AddNode("Buenos Aires"); //Asigno IDs
            graph.AddNode("La Pampa");
            graph.AddNode("Rio Negro");
            graph.AddNode("Neuquen");
            graph.AddNode("Chubut");
            graph.AddNode("La Rioja");
            graph.AddNode("Mendoza");
            graph.AddNode("Tierra del Fuego");
            graph.AddNode("San Juan");
            graph.AddNode("Santa Cruz");
            graph.AddNode("Jujuy");
            graph.AddNode("Salta");
            graph.AddNode("Formosa");
            graph.AddNode("Chaco");
            graph.AddNode("Corrientes");
            graph.AddNode("Misiones");
            graph.AddNode("Santa Fe");
            graph.AddNode("Santiago Del Estero");
            graph.AddNode("Tucuman");
            graph.AddNode("Catamarca");

            graph.AddEdge("Buenos Aires", "La Pampa").Attr.Id = "BA-LP";
            graph.AddEdge("La Pampa", "Rio Negro").Attr.Id = "LP-RN";
            graph.AddEdge("Rio Negro", "Neuquen").Attr.Id = "RN-NQN";
            graph.AddEdge("Neuquen", "Mendoza").Attr.Id = "NQN-MDZ";
            graph.AddEdge("Mendoza", "San Juan").Attr.Id = "MDZ-SJ";
            graph.AddEdge("San Juan", "La Rioja").Attr.Id = "SJ-LR";
            graph.AddEdge("Rio Negro", "Chubut").Attr.Id = "RN-CHBT";
            graph.AddEdge("Chubut", "Santa Cruz").Attr.Id = "CHBT-SC";
            graph.AddEdge("Santa Cruz", "Tierra del Fuego").Attr.Id = "CHBT-SC";
            graph.AddEdge("Jujuy", "Salta").Attr.Id = "JJ-SL";
            graph.AddEdge("Salta", "Formosa").Attr.Id = "SL-FM";
            graph.AddEdge("Salta", "Chaco").Attr.Id = "SL-CH";
            graph.AddEdge("Salta", "Santiago Del Estero").Attr.Id = "SL-SDE";
            graph.AddEdge("Salta", "Tucuman").Attr.Id = "SL-TM";
            graph.AddEdge("Salta", "Catamarca").Attr.Id = "SL-CM";
            graph.AddEdge("Catamarca", "La Rioja").Attr.Id = "CM-LR";
            graph.AddEdge("Catamarca", "Santiago Del Estero").Attr.Id = "CM-SDE";
            graph.AddEdge("Formosa", "Chaco").Attr.Id = "FM-CH";
            graph.AddEdge("Tucuman", "Santiago Del Estero").Attr.Id = "TM-SDE";
            graph.AddEdge("Chaco", "Santiago Del Estero").Attr.Id = "CH-SDE";
            graph.AddEdge("Corrientes", "Misiones").Attr.Id = "CR-MS";
            graph.AddEdge("Corrientes", "Santa Fe").Attr.Id = "CR-SF";


            cmbDesde.Items.Add("Buenos Aires");//Asigno IDs
            cmbDesde.Items.Add("La Pampa");
            cmbDesde.Items.Add("Rio Negro");
            cmbDesde.Items.Add("Neuquen");
            cmbDesde.Items.Add("Chubut");
            cmbDesde.Items.Add("La Rioja");
            cmbDesde.Items.Add("Mendoza");
            cmbDesde.Items.Add("Tierra del Fuego");
            cmbDesde.Items.Add("San Juan");
            cmbDesde.Items.Add("Santa Cruz");
            cmbDesde.Items.Add("Jujuy");
            cmbDesde.Items.Add("Salta");
            cmbDesde.Items.Add("Formosa");
            cmbDesde.Items.Add("Chaco");
            cmbDesde.Items.Add("Corrientes");
            cmbDesde.Items.Add("Misiones");
            cmbDesde.Items.Add("Santa Fe");
            cmbDesde.Items.Add("Santiago Del Estero");
            cmbDesde.Items.Add("Tucuman");
            cmbDesde.Items.Add("Catamarca");


            cmbHasta.Items.Add("Buenos Aires");
            cmbHasta.Items.Add("La Pampa");
            cmbHasta.Items.Add("Rio Negro");
            cmbHasta.Items.Add("Neuquen");
            cmbHasta.Items.Add("Chubut");
            cmbHasta.Items.Add("La Rioja");
            cmbHasta.Items.Add("Mendoza");
            cmbHasta.Items.Add("Tierra del Fuego");
            cmbHasta.Items.Add("San Juan");
            cmbHasta.Items.Add("Santa Cruz");
            cmbHasta.Items.Add("Jujuy");
            cmbHasta.Items.Add("Salta");
            cmbHasta.Items.Add("Formosa");
            cmbHasta.Items.Add("Chaco");
            cmbHasta.Items.Add("Corrientes");
            cmbHasta.Items.Add("Misiones");
            cmbHasta.Items.Add("Santa Fe");
            cmbHasta.Items.Add("Santiago Del Estero");
            cmbHasta.Items.Add("Tucuman");
            cmbHasta.Items.Add("Catamarca");

            ActualizarAdyacencias();
            //actualizo viewer
            viewer.Graph = graph;
            splitContainer1.Panel2.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(viewer);
            splitContainer1.Panel2.ResumeLayout();
        } 
        

        private string GetRandomAlphaNumeric()
       {
            return Path.GetRandomFileName().Replace(".", "").Substring(0, 8);
       }

        private void AddRandom_Click(object sender, EventArgs e)
        {
            AniadirRandom();
        }

        private void txtNombreConexion_TextChanged(object sender, EventArgs e)
        {

        }
        private void QuitarTodo()
        {
            for (int i = 0; i < listaAdy.Count; i++)
            {
                graph.RemoveNode(graph.FindNode(listaAdy.ElementAt(i).Item1));
                cmbDesde.Items.Remove(listaAdy.ElementAt(i).Item1);
                cmbHasta.Items.Remove(listaAdy.ElementAt(i).Item1);
            }
            ActualizarAdyacencias();
            viewer.Graph = graph;
            splitContainer1.Panel2.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.Panel2.Controls.Add(viewer);
            splitContainer1.Panel2.ResumeLayout();
            listaAdy.Clear();
            

        }
        private void btnquitartodo_Click(object sender, EventArgs e)
        {
            QuitarTodo();
        }

        private void cmbDesde_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbHasta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreNodo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}