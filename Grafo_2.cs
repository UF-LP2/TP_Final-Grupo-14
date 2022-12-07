using Practica_TP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_final
{
    public class Grafo_2
    {
        public Graph<string> web { get; set; }
        public List<Node<string>> Lista_de_nodos { get; set; }
        public Grafo_2() {
            this.Lista_de_nodos= new List<Node<string>>();
            this.web = new Graph<string>();
        }
        public void cargar_nodos()
        {
            // Graph<string> web = new Graph<string>();
            // Graph<string> web = new Graph<string>();
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

            Lista_de_nodos.Add(com1);
            Lista_de_nodos.Add(com2);
            Lista_de_nodos.Add(com3);
            Lista_de_nodos.Add(com4);
            Lista_de_nodos.Add(com5);
            Lista_de_nodos.Add(com6);
            Lista_de_nodos.Add(com7);
            Lista_de_nodos.Add(com8);
            Lista_de_nodos.Add(com9);
            Lista_de_nodos.Add(com10);
            Lista_de_nodos.Add(com11);
            Lista_de_nodos.Add(com12);
            Lista_de_nodos.Add(com13);
            Lista_de_nodos.Add(com14);
            Lista_de_nodos.Add(com15);




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
            web.AddDirectedEdge(com4, avellaneda, 4.1);
            web.AddDirectedEdge(com4, lanus, 8.1);


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
            web.AddDirectedEdge(com8, lanus, 14.4);
            web.AddDirectedEdge(com8, lomas_de_zamora, 15.7);
            web.AddDirectedEdge(com8, la_matanza, 21.5);


            //comuna 9

            web.AddDirectedEdge(com9, com7, 7.9);
            web.AddDirectedEdge(com9, com8, 8.7);
            web.AddDirectedEdge(com9, com10, 4.9);
            web.AddDirectedEdge(com9, la_matanza, 43.9);
            web.AddDirectedEdge(com9, tres_de_febrero, 7.8);


            //comuna 10

            web.AddDirectedEdge(com10, com7, 8.7);
            web.AddDirectedEdge(com10, com9, 9.4);
            web.AddDirectedEdge(com10, com11, 2.7);
            web.AddDirectedEdge(com10, tres_de_febrero, 5.3);


            //comuna 11

            web.AddDirectedEdge(com11, com6, 8.7);
            web.AddDirectedEdge(com11, com7, 9.1);
            web.AddDirectedEdge(com11, com10, 3);
            web.AddDirectedEdge(com11, com12, 8.7);
            web.AddDirectedEdge(com11, com15, 7.9);
            web.AddDirectedEdge(com11, tres_de_febrero, 3.5);
            web.AddDirectedEdge(com11, san_martin, 5.5);


            //comuna 12

            web.AddDirectedEdge(com12, com11, 10.5);
            web.AddDirectedEdge(com12, com13, 3.9);
            web.AddDirectedEdge(com12, com15, 6.3);
            web.AddDirectedEdge(com12, san_martin, 5.8);
            web.AddDirectedEdge(com12, vicente_lopez, 6.4);



            //comuna 13

            web.AddDirectedEdge(com13, com12, 4.5);
            web.AddDirectedEdge(com13, com14, 4.6);
            web.AddDirectedEdge(com13, com15, 6);
            web.AddDirectedEdge(com13, vicente_lopez, 5);


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
        }

        public List<string> obtener_minima_distancia(List<string> lista_visitados, List<string> lista_barrios, Node<string> nodo_inicial)
        {
            //string cadena="";
           // List<string> lista_visitados = new List<string>();
         
            List<string> lista_caminos =web.Dijkstra(web, nodo_inicial, lista_visitados, lista_barrios);

            //Queue<string> miCola = new Queue<string>();

           

            return lista_caminos;
            /*foreach (string nodo in aux.tabla_distancias.Keys)
             {
                // textbox2.AppendText(Environment.NewLine);
                 //textbox2.AppendText(nodo);
                 //textbox2.AppendText(Environment.NewLine);
                 double aux2 = aux.tabla_distancias[nodo];
                 //string cadena2;
                 cadena2= "" + aux2.ToString();
                 textbox2.AppendText(cadena2);
                // miCola.Enqueue(nodo);
             }*/

        }
        
    }
}
