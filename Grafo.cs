using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using tp_final;

// This is based on the graph implementation found at: https://msdn.microsoft.com/en-us/library/ms379574(v=vs.80).aspx
// But is updated to work in the latest C# and Net Core
namespace Practica_TP
{
    class Program
    {
        /*
        static void Main2(string[] args)
        {
            //Console.WriteLine(com1.valor);
            //web.BuscarCamino(com1, com3);
            //web.BuscarCamino(com2, com7);

            web.Dijkstra(web, com4);
            //Console.WriteLine("C# Graph Example - Updated for latest C# Net Core");
        }*/
    }

    public class Node<T>
    {
        public T data;
        private NodeList<T> neighbors = null;

        public Node() { }
        public Node(T data) { this.data = data; }
        public Node(T data, NodeList<T> neighbors)
        {
            this.data = data;
            this.neighbors = neighbors;
        }

        public T Value { get; set; }

        public NodeList<T> Neighbors { get; set; }

    }

    public class NodeList<T> : Collection<Node<T>>
    {
        public NodeList() : base() { }

        public NodeList(int initialSize)
        {
            for (int i = 0; i < initialSize; i++)
            {
                base.Items.Add(default(Node<T>));
            }
        }

        public Node<T> FindByValue(T value)
        {
            foreach (Node<T> node in Items)
            {
                if (node.data.Equals(value))
                {
                    return node;
                }
            }

            return null;
        }
    }

    public class GraphNode<T> : Node<T>
    {
        private List<double> costs;

        public T valor { get; set; }
        public GraphNode() : base() { }
        public GraphNode(T value) : base(value) { valor=value; }
        public GraphNode(T value, NodeList<T> neighbors) : base(value, neighbors) { }

        new public NodeList<T> Neighbors
        {
            get
            {
                if (base.Neighbors == null)
                    base.Neighbors = new NodeList<T>();

                return base.Neighbors;
            }
        }

        public List<double> Costs
        {
            get
            {
                if (costs == null)
                    costs = new List<double>();

                return costs;
            }
        }

    }

    public class Graph<T> : IEnumerable<Node<T>>
    {
        private NodeList<T> nodeSet;

        public NodeList<T> Nodes { get; }

        public Graph() : this(null)
        {
            
        }
        public Graph(NodeList<T> nodeSet)
        {
            if (nodeSet == null)
            {
                this.nodeSet = new NodeList<T>();
            }
            else
            {
                this.nodeSet = nodeSet;
            }
        }

        public void AddNode(GraphNode<T> node)
        {
            nodeSet.Add(node);
        }

        public GraphNode<T> AddNode(T value)
        {
            GraphNode<T> nodo = new GraphNode<T>(value);
            nodeSet.Add(nodo);
            return nodo;

        }

        public void AddDirectedEdge(GraphNode<T> from, GraphNode<T> to, double cost)
        {
            from.Neighbors.Add(to);
            from.Costs.Add(cost);
        }

        public void AddUndirectedEdge(GraphNode<T> from, GraphNode<T> to, double cost)
        {
            AddDirectedEdge(from, to, cost); //This was duplicated so just call the existing value

            to.Neighbors.Add(to);
            to.Costs.Add(cost);
        }

        public bool contains(T value)
        {
            return nodeSet.FindByValue(value) != null;
        }

        public bool Remove(T value)
        {
            // Remove node from nodeset
            GraphNode<T> nodeToRemove = (GraphNode<T>)nodeSet.FindByValue(value);
            if (nodeToRemove == null)
            {
                // wasnt found
                return false;
            }

            // was found
            nodeSet.Remove(nodeToRemove);

            // enumerate through each node in nodeSet, removing edges to this node
            foreach (GraphNode<T> gnode in nodeSet)
            {
                int index = gnode.Neighbors.IndexOf(nodeToRemove);
                if (index != -1)
                {
                    gnode.Neighbors.RemoveAt(index);
                    gnode.Costs.RemoveAt(index);
                }
            }

            return true;
        }

        public int Count
        {
            get { return nodeSet.Count; }
        }

        public IEnumerator<Node<T>> GetEnumerator()
        {
            return nodeSet.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void BuscarCamino(GraphNode<T> nodo_inicial, GraphNode<T> nodo_final){
            Hashtable tabla_hash = new Hashtable();
            if (!this.contains(nodo_inicial.valor) && !this.contains(nodo_final.valor))
            {
                Console.WriteLine("No contiene valor.");
            }
            else
            {
                Console.WriteLine("El nodo contiene valor.");
                CaminoAux(nodo_inicial, nodo_final, tabla_hash);
            }
                

        
        }

        public void CaminoAux(Node<T> nodo_inicial, Node<T> nodo_final, Hashtable tabla_hash)
        {
            Console.WriteLine(tabla_hash.ContainsKey(nodo_inicial.data));
            tabla_hash.Add(nodo_inicial.data, true);

            Console.WriteLine(nodo_inicial.data);
            if (nodo_inicial.data.Equals(nodo_final.data))
            {
                Console.WriteLine("Llegue a destino: " + nodo_inicial.data );
            }
            else
                foreach (Node<T> vecino in nodo_inicial.Neighbors)
                {
                    if (!tabla_hash.ContainsKey(vecino.data))
                    {
                        CaminoAux(vecino, nodo_final, tabla_hash);
                    }
                    else
                        Console.WriteLine("Nodo visitado ahora: " + vecino.data);

                }

        }

        public double get_peso_arco(Node<string> nodo_inicial, Node<string> nodo_destino)
        {
            int i = 0;
            foreach(Node<string> vecino in nodo_inicial.Neighbors)
            {
                if (vecino.data.Equals(nodo_destino.data))
                {
                    break;
                }
                else
                    i++;

            }
            GraphNode<string> auxiliar_cast = (GraphNode<string>)nodo_inicial;
            Console.WriteLine("Estoy en: " + nodo_inicial.data + " Quiero ir a: " + nodo_destino.data);
            Console.WriteLine("Obtengo peso de arco: " + auxiliar_cast.Costs[i]);
            //Console.WriteLine();
            return auxiliar_cast.Costs[i];
        }
        public Node<T> get_nodo(string aux)
        {
            foreach(Node<T> nodo_aux in this.nodeSet)
            {
                if (nodo_aux.data.Equals(aux))
                    return nodo_aux;
            }
            return null;
        }

        public List<string> Dijkstra(Graph<string> grafo, Node<string> nodo_inicial, List<string> visitados, List<string> barrios)
        {
            Console.WriteLine(nodo_inicial.data);
            List<string> caminos = new List<String>();
            Stack<String> pila = new Stack<String>();
            Dictionary<string, double> tabla_distancias = new Dictionary<string, double>();
            Dictionary<string, string> tabla_padre = new Dictionary<string, string>();
            Dictionary<string, bool> tabla_visitados = new Dictionary<string, bool>();
            PriorityQueue<Node<string>, double> cola_prioridad = new PriorityQueue<Node<string>, double>();


            foreach (Node<string> nodo in grafo.nodeSet)
            {
                Console.WriteLine(nodo.data);

                tabla_distancias.Add(nodo.data, Double.PositiveInfinity);
                tabla_padre.Add(nodo.data, null);
                tabla_visitados.Add(nodo.data, false);
            }

            tabla_distancias[nodo_inicial.data] = 0.0;

            // tabla_distancias.Add(nodo_inicial, 0);
            double aux = (double)tabla_distancias[nodo_inicial.data];
            // Console.WriteLine(tabla_distancias[nodo_inicial.data]);
            Console.WriteLine(aux);
            cola_prioridad.Enqueue(nodo_inicial, aux);

            while (cola_prioridad.Count > 0)
            {
                Node<string> nodo_u = cola_prioridad.Dequeue();
                tabla_visitados[nodo_u.data] = true;
                Console.WriteLine("Desencole el nodo: " + nodo_u.data);


                foreach (Node<string> vecino in nodo_u.Neighbors)
                {
                    //bool aux_visitados = (bool)tabla_visitados[vecino.data];
                    if (tabla_visitados[vecino.data] == false)
                    {
                        double aux_distancias_u = (double)tabla_distancias[nodo_u.data];
                        double aux_distancias_vecino = (double)tabla_distancias[vecino.data];

                        double peso_Arco = get_peso_arco(nodo_u, vecino);
                        if (aux_distancias_vecino > aux_distancias_u + peso_Arco)
                        {
                            Console.WriteLine("Actualizo");
                            tabla_distancias[vecino.data] = aux_distancias_u + peso_Arco;
                            tabla_padre[vecino.data] = nodo_u.data;
                            cola_prioridad.Enqueue(vecino, aux_distancias_u + peso_Arco);
                        }

                        Console.WriteLine("No visite al nodo. ");

                    }
                }
            }
            PriorityQueue<string, double> cola_prioridad2 = new PriorityQueue<string, double>();
            foreach (string distancia in tabla_distancias.Keys)
            {
                if (!distancia.Equals(nodo_inicial.data))
                {
                    Console.WriteLine("Comuna : " + distancia);
                    Console.WriteLine("Distancia : " + tabla_distancias[distancia]);
                    cola_prioridad2.Enqueue(distancia, tabla_distancias[distancia]);
                }

            }

            PriorityQueue<string, double> cola_prioridad3 = new PriorityQueue<string, double>();
            foreach (string barrio in barrios)
            {
                if(!barrio.Equals(nodo_inicial.data))
                    cola_prioridad3.Enqueue(barrio, tabla_distancias[barrio]);

            }
            string comuna_aux = cola_prioridad3.Dequeue();
            caminos.Add(comuna_aux);
            string padre = tabla_padre[comuna_aux];
            caminos.Add(padre);
            while (!padre.Equals(nodo_inicial.data) && padre!=null )
            {
                comuna_aux = padre;
                padre = tabla_padre[comuna_aux];
                caminos.Add(padre);
                Console.WriteLine("padre : " + padre);
            }

            foreach(string camino in caminos)
            {
                pila.Push(camino);
                
            }
           
            caminos = new List<string>();
            while (pila.Count > 0)
            {
                caminos.Add(pila.Pop());
            }
            return caminos;





        }

    }

    /*public List<string>Dijkstra(Graph<string> grafo, Node<string> nodo_inicial, List<string> visitados)
    {
        Console.WriteLine(nodo_inicial.data);
        List<string> caminos = new List<String>();
        Stack<String> pila = new Stack<String>();
        Dictionary<string, double> tabla_distancias = new Dictionary<string, double>();
        Dictionary<string, string> tabla_padre = new Dictionary<string, string>();
        Dictionary<string, bool> tabla_visitados = new Dictionary<string, bool>();
        PriorityQueue<Node<string>, double> cola_prioridad = new PriorityQueue<Node<string>, double>();


        foreach (Node<string> nodo in grafo.nodeSet)
        {
            Console.WriteLine(nodo.data);

            tabla_distancias.Add(nodo.data, Double.PositiveInfinity);
            tabla_padre.Add(nodo.data, null);
            tabla_visitados.Add(nodo.data, false);
        }

        tabla_distancias[nodo_inicial.data] = 0.0;

        // tabla_distancias.Add(nodo_inicial, 0);
        double aux = (double)tabla_distancias[nodo_inicial.data];
        // Console.WriteLine(tabla_distancias[nodo_inicial.data]);
        Console.WriteLine(aux);
        cola_prioridad.Enqueue(nodo_inicial, aux);

        while (cola_prioridad.Count > 0)
        {
            Node<string> nodo_u = cola_prioridad.Dequeue();
            tabla_visitados[nodo_u.data] = true;
            Console.WriteLine("Desencole el nodo: " + nodo_u.data);


            foreach (Node<string> vecino in nodo_u.Neighbors)
            {
                //bool aux_visitados = (bool)tabla_visitados[vecino.data];
                if (tabla_visitados[vecino.data] == false)
                {
                    double aux_distancias_u = (double)tabla_distancias[nodo_u.data];
                    double aux_distancias_vecino = (double)tabla_distancias[vecino.data];

                    double peso_Arco = get_peso_arco(nodo_u, vecino);
                    if (aux_distancias_vecino > aux_distancias_u + peso_Arco)
                    {
                        Console.WriteLine("Actualizo");
                        tabla_distancias[vecino.data] = aux_distancias_u + peso_Arco;
                        tabla_padre[vecino.data] = nodo_u.data;
                        cola_prioridad.Enqueue(vecino, aux_distancias_u + peso_Arco);
                    }

                    Console.WriteLine("No visite al nodo. ");

                }
            }
        }
        PriorityQueue<string, double> cola_prioridad2 = new PriorityQueue<string, double>();
        foreach (string distancia in tabla_distancias.Keys)
        {
            if (!distancia.Equals(nodo_inicial.data))
            {
                Console.WriteLine("Comuna : " + distancia);
                Console.WriteLine("Distancia : " + tabla_distancias[distancia]);
                cola_prioridad2.Enqueue(distancia, tabla_distancias[distancia]);
            }

        }
        String comuna_aux = cola_prioridad2.Dequeue();
        while (visitados.Contains(comuna_aux) && cola_prioridad2.Count > 0)
        {
            comuna_aux = cola_prioridad2.Dequeue();
        }
        //pila.Push(comuna_aux);
        caminos.Add(comuna_aux);
        Console.WriteLine("Minima distancia : " + comuna_aux);
        string padre = tabla_padre[comuna_aux];
        //pila.Push(padre);
        caminos.Add(padre);


        Console.WriteLine("padre : " + padre);
        while (!nodo_inicial.data.Equals(padre))
        {
            comuna_aux = padre;
            padre = tabla_padre[comuna_aux];
            //pila.Push(padre);
            caminos.Add(padre);
            Console.WriteLine("padre : " + padre);

        }*/

    /*  while (pila.Count > 0)
      {
          caminos.Add(pila.Pop());
      }*/

    /* int i;
     for (i = 0; i < caminos.Count; i++)
     {
         Console.WriteLine("Recorro : " + caminos[i]);
     }

     return caminos;*/



}

            /* public Tablas Dijkstra(Graph<string> grafo, Node<string> nodo_inicial)
             {
                 Dictionary<string, double> tabla_distancias = new Dictionary<string, double>();
                 Hashtable tabla_padre = new Hashtable();
                 Dictionary <string, bool> tabla_visitados = new Dictionary<string, bool>();
                 PriorityQueue<Node<string>, double> cola_prioridad = new PriorityQueue<Node<string>, double>();


                 foreach (Node<string> nodo in grafo.ToList())
                 {
                     tabla_distancias.Add(nodo.data, Double.PositiveInfinity);
                     tabla_padre.Add(nodo.data, null);
                     tabla_visitados.Add(nodo.data, false);
                 }
                 tabla_distancias[nodo_inicial.data] = 0.0;
                 // tabla_distancias.Add(nodo_inicial, 0);
                 double aux = (double)tabla_distancias[nodo_inicial.data];
                 // Console.WriteLine(tabla_distancias[nodo_inicial.data]);
                 Console.WriteLine(aux);
                 cola_prioridad.Enqueue(nodo_inicial, aux);

                 while (cola_prioridad.Count > 0)
                 {
                     Node<string> nodo_u = cola_prioridad.Dequeue();
                     tabla_visitados[nodo_u.data] = true;
                     Console.WriteLine("Desencole el nodo: " + nodo_u.data);


                     foreach (Node<string> vecino in nodo_u.Neighbors)
                     {
                         //bool aux_visitados = (bool)tabla_visitados[vecino.data];
                         if (tabla_visitados[vecino.data] ==false)
                         {
                             double aux_distancias_u = (double)tabla_distancias[nodo_u.data];
                             double aux_distancias_vecino = (double)tabla_distancias[vecino.data];

                             double peso_Arco = get_peso_arco(nodo_u, vecino);
                             if (aux_distancias_vecino > aux_distancias_u+ peso_Arco)
                             {
                                 Console.WriteLine("Actualizo");
                                 tabla_distancias[vecino.data] = aux_distancias_u + peso_Arco;
                                 tabla_padre[vecino.data] = nodo_u.data;
                                 cola_prioridad.Enqueue(vecino, aux_distancias_u+peso_Arco);
                             }

                             //Console.WriteLine("No visite al nodo. ");
                         }
                     }
                 }
                 Tablas nueva_tabla = new Tablas();

                 nueva_tabla.tabla_distancias = tabla_distancias;
                 nueva_tabla.tabla_padre = tabla_padre;
                 return nueva_tabla;
             }

         }*/

