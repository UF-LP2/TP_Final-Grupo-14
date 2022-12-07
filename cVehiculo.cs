using Practica_TP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class cVehiculo
    {
        public readonly uint ID;
        protected float velocidadMedia;
        protected float anchoMax;
        protected float largoMax;
        protected float altoMax;
        public int pesoMax { get; set; }
        public float volumenMax { get; set; }
        public int pesoActual { get; set; }
        public float volumenActual { get; set; }
        public int nodosRecorridos { get; set; }
        public List<Pedido> pedidos { get; set; }
        public List<string> lista_barrios { get; set; }
        public Grafo_2 grafo_aux2 { get; set; }
        //public bool flagCombustible { get; set; }
        //protected cCombustible combustible;
        public static uint maxID = 0;

        /// <summary>
        /// Constructor principal para inicializar los vehiculos
        /// </summary>
        /// <param name="anchoMax">Ancho maximo del vehiculo</param>
        /// <param name="largoMax">Largo maximo del vehiculo</param>
        /// <param name="altoMax">Alto maximo del vehiculo</param>
        /// <param name="pesoMax">Peso maximo del vehiculo</param>
        public cVehiculo(float anchoMax, float largoMax, float altoMax, int pesoMax)
        {
            ID = maxID++;
            this.anchoMax = anchoMax;
            this.largoMax = largoMax;
            this.altoMax = altoMax;
            this.pesoMax = pesoMax;
            this.volumenMax = altoMax * largoMax * anchoMax;
            //     this.combustible = new cCombustible();
            this.pedidos = new List<Pedido>();
            this.lista_barrios = new List<string>();
            this.grafo_aux2 = new Grafo_2();
            grafo_aux2.cargar_nodos();

            //this.flagCombustible = false;
        }

        public void Set_Lista_Barrios()
        {
            int i;
            for (i = 0; i < this.pedidos.Count; i++)
            {
                string barrio = pedidos[i].barrio;
                if (!lista_barrios.Contains(barrio))//sino contiene
                {
                    lista_barrios.Add(barrio);
                }
            }
        }

        public void Encontrar_Camino(TextBox textbox2)
        {
            List<string> lista_visitados = new List<string>();
            Set_Lista_Barrios();

            Node<string> nodo_inicial_1=grafo_aux2.web.get_nodo("comuna 9");
            lista_visitados.Add("comuna 9");
            while (lista_barrios.Count > 0)
            {
                List<string> lista_recorrer = grafo_aux2.obtener_minima_distancia(lista_visitados, lista_barrios, nodo_inicial_1);
                
                textbox2.AppendText("Nodo inicial es: " + nodo_inicial_1.data);
                textbox2.AppendText(Environment.NewLine);
               // textbox2.AppendText(lista_recorrer[0]);
                //textbox2.AppendText(Environment.NewLine);
                foreach (string nodo in lista_recorrer)
                {
                    lista_barrios.Remove(nodo);
                    lista_visitados.Add(nodo);
                   textbox2.AppendText(nodo);
                    textbox2.AppendText(Environment.NewLine);
                    nodo_inicial_1 = grafo_aux2.web.get_nodo(nodo);
                }
            }
            

            foreach (string nodo in lista_barrios)
            {
                textbox2.AppendText(nodo);
                textbox2.AppendText(Environment.NewLine);
            }

            textbox2.AppendText("recorriendo minima distancia");
            textbox2.AppendText(Environment.NewLine);

            /*string camino = null;
            List<string> lista_aux=new List<string>();

            while (lista_barrios.Count > 0)
            {

                while (!lista_barrios.Contains(camino))
                {
                    lista_aux = grafo_aux2.obtener_minima_distancia(lista_visitados);
                    camino = lista_aux[0];
                }


                foreach (string camino2 in lista_aux)
                {

                        lista_barrios.Remove(camino2);
                        lista_visitados.Add(camino2);
                        textbox2.AppendText("Imprimo" + camino2);
                        textbox2.AppendText(Environment.NewLine);


                }
            }*/





            /// <summary>
            /// Algoritmo que permite repartir los pedidos de la lista interna del vehiculo, y ademas limpiar los elementos 
            /// cargados previamente de la lista total
            /// </summary>
            /// <param name="pedidosTotal">Lista de pedidos TOTAL</param>
            /* public void repartirPedidos(List<cPedido> pedidosTotal)
             {
                 int i;
                 this.flagCombustible = false;
                 for (i = 0; i < pedidos.Count; i++)
                 {
                     this.nodosRecorridos++;
                     if (combustible.getActual(this) != 0)
                     {
                         this.pedidos.Remove(pedidos[i]);
                     }
                     else
                     {
                         this.flagCombustible = true;
                         this.combustible.actual = 100;
                     }
                 }
                 // reseteo count a 0
                 this.pedidos.Clear();
                 i = 0;
                 while (pedidosTotal[i].cargado == true)
                 {
                     pedidosTotal.Remove(pedidosTotal[i]);
                     i++;
                 }
             }



         }*/
        }
    }
}