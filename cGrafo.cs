using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

// This is based on the graph implementation found at: https://msdn.microsoft.com/en-us/library/ms379574(v=vs.80).aspx
// But is updated to work in the latest C# and Net Core
namespace Practica_TP
{
    class Program
    {
        static void Main2(string[] args)
        {
            Graph<string> web = new Graph<string>();
            var com1 = web.AddNode("comuna 1");
            var com2 = web.AddNode("comuna 2");
            var com3 = web.AddNode("comuna 3");
            var com4 = web.AddNode("comuna 4");
            var com5 = web.AddNode("comuna 5");
            var com6 = web.AddNode("comuna 6");
            var com7 = web.AddNode("comuna 7");
            var com8 = web.AddNode("comuna 8");
            var com9 = web.AddNode("comuna 9");
            var com10 = web.AddNode("comuna 10");
            var com11 = web.AddNode("comuna 11");
            var com12 = web.AddNode("comuna 12");
            var com13 = web.AddNode("comuna 13");
            var com14 = web.AddNode("comuna 14");
            var com15 = web.AddNode("comuna 15");
            var avellaneda = web.AddNode("avellaneda");
            var lanus = web.AddNode("lanus");
            var lomas_de_zamora = web.AddNode("lomas de zamora");
            var la_matanza = web.AddNode("la matanza");
            var moron = web.AddNode("moron");
            var tres_de_febrero = web.AddNode("tres de febrero");
            var san_martin = web.AddNode("san martin");
            var vicente_lopez = web.AddNode("vicente lopez");
            var san_isidro = web.AddNode("san isidro");


            //pdf valores de distancia
            web.AddDirectedEdge(com1, com2, 4.5);
            web.AddDirectedEdge(com1, com3, 4.9);
            web.AddDirectedEdge(com1, com4, 7);



            //comuna 2 vecina con las siguientes comunas/partidos
            web.AddDirectedEdge(com2, com1, 6.3);
            web.AddDirectedEdge(com2, com3, 3.9);
            web.AddDirectedEdge(com2, com5, 4.6);
            web.AddDirectedEdge(com2, com14, 3.6);


            //comuna 3
            web.AddDirectedEdge(com3, com1, 3.9);
            web.AddDirectedEdge(com3, com2, 4.3);
            web.AddDirectedEdge(com3, com4, 4.9);
            web.AddDirectedEdge(com3, com5, 2.9);


            //comuna 4
            web.AddDirectedEdge(com4, com1, 6.4);
            web.AddDirectedEdge(com4, com3, 3.8);
            web.AddDirectedEdge(com4, com5, 6.3);
            web.AddDirectedEdge(com4, com7, 7.5);
            web.AddDirectedEdge(com4, com8, 8.3);


            // comuna 5
            web.AddDirectedEdge(com5, com2, 5.8);
            web.AddDirectedEdge(com5, com3, 2.6);
            web.AddDirectedEdge(com5, com4, 6.1);
            web.AddDirectedEdge(com5, com6, 3.2);
            web.AddDirectedEdge(com5, com7, 4.8);
            web.AddDirectedEdge(com5, com14, 10);
            web.AddDirectedEdge(com5, com15, 5.6);


            // comuna 6

            web.AddDirectedEdge(com6, com5, 2.9);
            web.AddDirectedEdge(com6, com7, 3);
            web.AddDirectedEdge(com6, com11, 8.8);
            web.AddDirectedEdge(com6, com15, 4.4);


            // comuna 7

            web.AddDirectedEdge(com7, com4, 7.6);
            web.AddDirectedEdge(com7, com5, 5.3);
            web.AddDirectedEdge(com7, com6, 3.2);
            web.AddDirectedEdge(com7, com8, 6.2);
            web.AddDirectedEdge(com7, com9, 7.8);
            web.AddDirectedEdge(com7, com10, 7.8);
            web.AddDirectedEdge(com7, com11, 14);

            //comuna 8

            web.AddDirectedEdge(com8, com4, 8.6);
            web.AddDirectedEdge(com8, com7, 6.1);
            web.AddDirectedEdge(com8, com9, 8.6);


            //comuna 9

            web.AddDirectedEdge(com9, com7, 7.9);
            web.AddDirectedEdge(com9, com8, 8.7);
            web.AddDirectedEdge(com9, com10, 4.9);


            //comuna 10

            web.AddDirectedEdge(com10, com7, 8.7);
            web.AddDirectedEdge(com10, com9, 9.4);
            web.AddDirectedEdge(com10, com11, 2.7);


            //comuna 11

            web.AddDirectedEdge(com11, com6, 8.7);
            web.AddDirectedEdge(com11, com7, 9.1);
            web.AddDirectedEdge(com11, com10, 3);
            web.AddDirectedEdge(com11, com12, 8.7);
            web.AddDirectedEdge(com11, com15, 7.9);


            //comuna 12

            web.AddDirectedEdge(com12, com11, 10.5);
            web.AddDirectedEdge(com12, com13, 3.9);
            web.AddDirectedEdge(com12, com15, 6.3);


            //comuna 13

            web.AddDirectedEdge(com13, com12, 4.5);
            web.AddDirectedEdge(com13, com14, 4.6);
            web.AddDirectedEdge(com13, com15, 6);


            //comuna 14

            web.AddDirectedEdge(com14, com2, 4.1);
            web.AddDirectedEdge(com14, com5, 5.4);
            web.AddDirectedEdge(com14, com13, 5.1);
            web.AddDirectedEdge(com14, com15, 4.8);


            //comuna 15

            web.AddDirectedEdge(com15, com5, 5.6);
            web.AddDirectedEdge(com15, com6, 4.4);
            web.AddDirectedEdge(com15, com11, 7.1);
            web.AddDirectedEdge(com15, com12, 6.9);
            web.AddDirectedEdge(com15, com13, 6.2);
            web.AddDirectedEdge(com15, com14, 5);


            //avellaneda

            web.AddDirectedEdge(avellaneda, com4, 4.4);
            web.AddDirectedEdge(avellaneda, lanus, 7);


            //lanus

            web.AddDirectedEdge(lanus, com4, 7.8);
            web.AddDirectedEdge(lanus, com8, 8.8);
            web.AddDirectedEdge(lanus, avellaneda, 6.6);
            web.AddDirectedEdge(lanus, lomas_de_zamora, 10.2);


            //lomas de zamora
            web.AddDirectedEdge(lomas_de_zamora, com8, 15);
            web.AddDirectedEdge(lomas_de_zamora, lanus, 9.7);
            web.AddDirectedEdge(lomas_de_zamora, la_matanza, 23.7);

            //la matanza

            web.AddDirectedEdge(la_matanza, com8, 17.3);
            web.AddDirectedEdge(la_matanza, com9, 5.9);
            web.AddDirectedEdge(la_matanza, lomas_de_zamora, 19.7);
            web.AddDirectedEdge(la_matanza, moron, 7.1);
            web.AddDirectedEdge(la_matanza, tres_de_febrero, 7.1);


            //moron
            web.AddDirectedEdge(moron, la_matanza, 6.9);
            web.AddDirectedEdge(moron, tres_de_febrero, 16.6);


            //tres de febrero
            web.AddDirectedEdge(tres_de_febrero, com9, 8.9);
            web.AddDirectedEdge(tres_de_febrero, com10, 5.1);
            web.AddDirectedEdge(tres_de_febrero, com11, 3.9);
            web.AddDirectedEdge(tres_de_febrero, la_matanza, 8.2);
            web.AddDirectedEdge(tres_de_febrero, moron, 14.4);
            web.AddDirectedEdge(tres_de_febrero, san_martin, 7.6);

            // san martin
            web.AddDirectedEdge(san_martin, com11, 5.9);
            web.AddDirectedEdge(san_martin, com12, 6);
            web.AddDirectedEdge(san_martin, tres_de_febrero, 7.5);
            web.AddDirectedEdge(san_martin, vicente_lopez, 11.3);
            web.AddDirectedEdge(san_martin, san_isidro, 20.8);


            //vicente lopez
            web.AddDirectedEdge(vicente_lopez, com12, 6.9);
            web.AddDirectedEdge(vicente_lopez, com13, 6.2);
            web.AddDirectedEdge(vicente_lopez, san_martin, 11.5);
            web.AddDirectedEdge(vicente_lopez, san_isidro, 17.3);


            //san isidro

            web.AddDirectedEdge(san_isidro, san_martin, 19.9);
            web.AddDirectedEdge(san_isidro, vicente_lopez, 16.6);

            
            //Console.WriteLine(com1.valor);
            //web.BuscarCamino(com1, com3);
            //web.BuscarCamino(com2, com7);

            web.Dijkstra(web, com4);
            //Console.WriteLine("C# Graph Example - Updated for latest C# Net Core");
        }
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
        public GraphNode(T value) : base(value) { valor = value; }
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

        public Graph() : this(null) { }
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

        public void BuscarCamino(GraphNode<T> nodo_inicial, GraphNode<T> nodo_final)
        {
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
                Console.WriteLine("Llegue a destino: " + nodo_inicial.data);
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

        public double get_peso_arco(Node<T> nodo_inicial, Node<T> nodo_destino)
        {
            int i = 0;
            foreach (Node<T> vecino in nodo_inicial.Neighbors)
            {
                if (vecino.data.Equals(nodo_destino.data))
                {
                    break;
                }
                else
                    i++;

            }
            GraphNode<T> auxiliar_cast = (GraphNode<T>)nodo_inicial;
            Console.WriteLine("Estoy en: " + nodo_inicial.data + " Quiero ir a: " + nodo_destino.data);
            Console.WriteLine("Obtengo peso de arco: " + auxiliar_cast.Costs[i]);
            //Console.WriteLine();
            return auxiliar_cast.Costs[i];
        }

        public void Dijkstra(Graph<T> grafo, Node<T> nodo_inicial)
        {
            Hashtable tabla_distancias = new Hashtable();
            Hashtable tabla_padre = new Hashtable();
            Hashtable tabla_visitados = new Hashtable();
            PriorityQueue<Node<T>, double> cola_prioridad = new PriorityQueue<Node<T>, double>();


            foreach (Node<T> nodo in grafo.ToList())
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
                Node<T> nodo_u = cola_prioridad.Dequeue();
                tabla_visitados[nodo_u.data] = true;
                Console.WriteLine("Desencole el nodo: " + nodo_u.data);


                foreach (Node<T> vecino in nodo_u.Neighbors)
                {
                    bool aux_visitados = (bool)tabla_visitados[vecino.data];
                    if (aux_visitados == false)
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

                        //Console.WriteLine("No visite al nodo. ");
                    }
                }
            }

        }

    }

}
