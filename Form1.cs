using csvfiles;
using Practica_TP;



/*
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        var csv_ = new csvfiles._csv();
        List<Pedido> Pedidos = csv_.read_csv();

        List<Pedido> lista_normal = new List<Pedido>();
        List<Pedido> lista_diferida = new List<Pedido>();
        List<Pedido> lista_express = new List<Pedido>();
        //  cFurgon furgon;


        textbox1.Multiline = true;
        //  textbox1.Text = "hola";
        this.Controls.Add(textbox1);

        textbox2.Multiline = true;
        //  textbox1.Text = "hola";
        this.Controls.Add(textbox2);

        foreach (Pedido pedido in Pedidos)
        {
            pedido.volumen = pedido.ancho / 100 * pedido.alto / 100 * pedido.largo / 100;
            pedido.volumen_casteado = (int)pedido.volumen + 1;


            // textbox1.AppendText(pedido.producto);
            // textbox1.AppendText(Environment.NewLine);

            pedido.peso_casteado = (int)pedido.peso + 1;
            if (pedido.prioridad == 1)
            {
                lista_normal.Add(pedido);//48 horas
            }
            else if (pedido.prioridad == 2)
            {
                lista_diferida.Add(pedido);//72 horas
            }
            else if (pedido.prioridad == 3)
            {
                lista_express.Add(pedido);//24 horas
            }

            Label mylab = new Label();
            mylab.Text = pedido.producto;

            //mylab.Location = new Point(222, 90);
        }


        cFurgoneta furgoneta = new cFurgoneta();
        cFurgon furgon = new cFurgon();
        cCamioneta camioneta = new cCamioneta();

        textbox1.AppendText(Environment.NewLine);
        ///////////////////////////////////////
        textbox1.AppendText("Lista express: ");
        textbox1.AppendText("Cargando furgon");
        furgon.pedidos = cMochila.KnapSack(lista_express.ToArray(), 10, 4900);
        foreach (Pedido pedidos in furgon.pedidos)
        {
            textbox1.AppendText(pedidos.producto);
            textbox1.AppendText(Environment.NewLine);
            lista_express.Remove(pedidos);
        }
        textbox1.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_express)
        {
            textbox1.AppendText(pedidos.producto);
            textbox1.AppendText(Environment.NewLine);

        }
        textbox1.AppendText("-----------------------------");

        textbox1.AppendText("Cargando furgoneta");
        furgoneta.pedidos = cMochila.KnapSack(lista_express.ToArray(), 17, 5000);
        foreach (Pedido pedidos in furgoneta.pedidos)
        {

            textbox1.AppendText(pedidos.producto);
            textbox1.AppendText(Environment.NewLine);
            lista_express.Remove(pedidos);
        }
        textbox1.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_express)
        {
            textbox1.AppendText(pedidos.producto);
            textbox1.AppendText(Environment.NewLine);

        }
        textbox1.AppendText("-----------------------------");


        textbox1.AppendText("Cargando camioneta");
        camioneta.pedidos = cMochila.KnapSack(lista_express.ToArray(), 3, 2500);
        foreach (Pedido pedidos in camioneta.pedidos)
        {

            textbox1.AppendText(pedidos.producto);
            textbox1.AppendText(Environment.NewLine);
            lista_normal.Remove(pedidos);
        }
        textbox1.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_express)
        {
            textbox1.AppendText(pedidos.producto);
            textbox1.AppendText(Environment.NewLine);


        }

        furgon.Encontrar_Camino(textbox1);
        textbox1.AppendText("furgoneta:");
        furgoneta.Encontrar_Camino(textbox1);
        textbox1.AppendText("camioneta:");
        camioneta.Encontrar_Camino(textbox1);



        textbox2.AppendText("Lista pedidos normal");
        textbox2.AppendText("Cargando furgon");
        furgon.pedidos = cMochila.KnapSack(lista_normal.ToArray(), 10, 4900);
        foreach (Pedido pedidos in furgon.pedidos)
        {
            textbox2.AppendText(pedidos.producto);
            textbox2.AppendText(Environment.NewLine);
            lista_normal.Remove(pedidos);
        }
        textbox2.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_normal)
        {
            textbox2.AppendText(pedidos.producto);
            textbox2.AppendText(Environment.NewLine);

        }
        textbox2.AppendText("-----------------------------");

        textbox2.AppendText("Cargando furgoneta");
        furgoneta.pedidos = cMochila.KnapSack(lista_normal.ToArray(), 17, 5000);
        foreach (Pedido pedidos in furgoneta.pedidos)
        {

            textbox2.AppendText(pedidos.producto);
            textbox2.AppendText(Environment.NewLine);
            lista_normal.Remove(pedidos);
        }
        textbox2.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_normal)
        {
            textbox2.AppendText(pedidos.producto);
            textbox2.AppendText(Environment.NewLine);

        }
        textbox2.AppendText("-----------------------------");


        textbox2.AppendText("Cargando camioneta");
        camioneta.pedidos = cMochila.KnapSack(lista_normal.ToArray(), 3, 2500);
        foreach (Pedido pedidos in camioneta.pedidos)
        {

            textbox2.AppendText(pedidos.producto);
            textbox2.AppendText(Environment.NewLine);
            lista_normal.Remove(pedidos);
        }
        textbox2.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_normal)
        {
            textbox2.AppendText(pedidos.producto);
            textbox2.AppendText(Environment.NewLine);

        }
        textbox2.AppendText("-----------------------------");
        textbox2.AppendText("Furgon:");

        furgon.Encontrar_Camino(textbox2);
        textbox2.AppendText("furgoneta:");
        furgoneta.Encontrar_Camino(textbox2);
        textbox2.AppendText("camioneta:");
        camioneta.Encontrar_Camino(textbox2);
        */






        ////////////////////////////////////////////////////
        ///textbox1.AppendText(Environment.NewLine);
        ///////////////////////////////////////
       /* textbox3.AppendText("Lista diferido: ");
        textbox3.AppendText("Cargando furgon");
        furgon.pedidos = cMochila.KnapSack(lista_express.ToArray(), 10, 4900);
        foreach (Pedido pedidos in furgon.pedidos)
        {
            textbox3.AppendText(pedidos.producto);
            textbox3.AppendText(Environment.NewLine);
            lista_express.Remove(pedidos);
        }
        textbox3.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_express)
        {
            textbox3.AppendText(pedidos.producto);
            textbox3.AppendText(Environment.NewLine);

        }
        textbox3.AppendText("-----------------------------");

        textbox3.AppendText("Cargando furgoneta");
        furgoneta.pedidos = cMochila.KnapSack(lista_express.ToArray(), 17, 5000);
        foreach (Pedido pedidos in furgoneta.pedidos)
        {

            textbox3.AppendText(pedidos.producto);
            textbox3.AppendText(Environment.NewLine);
            lista_express.Remove(pedidos);
        }
        textbox3.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_express)
        {
            textbox3.AppendText(pedidos.producto);
            textbox3.AppendText(Environment.NewLine);

        }
        textbox3.AppendText("-----------------------------");


        textbox3.AppendText("Cargando camioneta");
        camioneta.pedidos = cMochila.KnapSack(lista_express.ToArray(), 3, 2500);
        foreach (Pedido pedidos in camioneta.pedidos)
        {

            textbox3.AppendText(pedidos.producto);
            textbox3.AppendText(Environment.NewLine);
            lista_normal.Remove(pedidos);
        }

        textbox3.AppendText("-----------------------------");
        foreach (Pedido pedidos in lista_express)
        {
            textbox3.AppendText(pedidos.producto);
            textbox3.AppendText(Environment.NewLine);


        }

        furgon.Encontrar_Camino(textbox3);
        textbox3.AppendText("furgoneta:");
        furgoneta.Encontrar_Camino(textbox1);
        textbox3.AppendText("camioneta:");
        camioneta.Encontrar_Camino(textbox1);
       */
      /*  void InitializeComponent()
        {
            this.textbox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textbox2.AcceptsReturn = true;
            this.textbox2.AcceptsTab = true;
            this.textbox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox2.Multiline = true;
            this.textbox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(50, 100);
            this.Controls.Add(this.textbox2);
            this.Text = "TextBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();
            ///////////////////////////////////////////////////////
            ///

            this.textbox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textbox3.AcceptsReturn = true;
            this.textbox3.AcceptsTab = true;
            this.textbox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox3.Multiline = true;
            this.textbox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(50, 150);
            this.Controls.Add(this.textbox3);
            this.Text = "TextBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();

            this.textbox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textbox3.AcceptsReturn = true;
            this.textbox3.AcceptsTab = true;
            this.textbox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textbox3.Multiline = true;
            this.textbox3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            //
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(50, 150);
            this.Controls.Add(this.textbox3);
            this.Text = "TextBox Example";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
      */

namespace tp_final; 

public partial class Form1 : Form
{
public Form1()
{
    InitializeComponent();
    var csv_ = new csvfiles._csv();
    List<Pedido> Pedidos = csv_.read_csv();

    List<Pedido> lista_normal = new List<Pedido>();
    List<Pedido> lista_diferida = new List<Pedido>();
    List<Pedido> lista_express = new List<Pedido>();
    //  cFurgon furgon;


    textbox1.Multiline = true;
    //  textbox1.Text = "hola";
    this.Controls.Add(textbox1);

    textbox2.Multiline = true;
    //  textbox1.Text = "hola";
    this.Controls.Add(textbox2);

    foreach (Pedido pedido in Pedidos)
    {
        pedido.volumen = pedido.ancho / 100 * pedido.alto / 100 * pedido.largo / 100;
        pedido.volumen_casteado = (int)pedido.volumen + 1;


        // textbox1.AppendText(pedido.producto);
        // textbox1.AppendText(Environment.NewLine);

        pedido.peso_casteado = (int)pedido.peso + 1;
        if (pedido.prioridad == 1)
        {
            lista_normal.Add(pedido);//48 horas
        }
        else if (pedido.prioridad == 2)
        {
            lista_diferida.Add(pedido);//72 horas
        }
        else if (pedido.prioridad == 3)
        {
            lista_express.Add(pedido);//24 horas
        }

        Label mylab = new Label();
        mylab.Text = pedido.producto;

        //mylab.Location = new Point(222, 90);
    }


    cFurgoneta furgoneta = new cFurgoneta();
    cFurgon furgon = new cFurgon();
    cCamioneta camioneta = new cCamioneta();

    textbox2.AppendText("Cargando furgon");
    furgon.pedidos = cMochila.KnapSack(lista_normal.ToArray(), 10, 4900);
    foreach (Pedido pedidos in furgon.pedidos)
    {
        textbox2.AppendText(pedidos.producto);
        textbox2.AppendText(Environment.NewLine);
        lista_normal.Remove(pedidos);
    }
    textbox2.AppendText("-----------------------------");
    foreach (Pedido pedidos in lista_normal)
    {
        textbox2.AppendText(pedidos.producto);
        textbox2.AppendText(Environment.NewLine);

    }
    textbox2.AppendText("-----------------------------");

    textbox2.AppendText("Cargando furgoneta");
    furgoneta.pedidos = cMochila.KnapSack(lista_normal.ToArray(), 17, 5000);
    foreach (Pedido pedidos in furgoneta.pedidos)
    {

        textbox2.AppendText(pedidos.producto);
        textbox2.AppendText(Environment.NewLine);
        lista_normal.Remove(pedidos);
    }
    textbox2.AppendText("-----------------------------");
    foreach (Pedido pedidos in lista_normal)
    {
        textbox2.AppendText(pedidos.producto);
        textbox2.AppendText(Environment.NewLine);

    }
    textbox2.AppendText("-----------------------------");


    textbox2.AppendText("Cargando camioneta");
    camioneta.pedidos = cMochila.KnapSack(lista_normal.ToArray(), 3, 2500);
    foreach (Pedido pedidos in camioneta.pedidos)
    {

        textbox2.AppendText(pedidos.producto);
        textbox2.AppendText(Environment.NewLine);
        lista_normal.Remove(pedidos);
    }
    textbox2.AppendText("-----------------------------");
    foreach (Pedido pedidos in lista_normal)
    {
        textbox2.AppendText(pedidos.producto);
        textbox2.AppendText(Environment.NewLine);

    }
    textbox2.AppendText("-----------------------------");
    textbox2.AppendText("Furgon:");

    furgon.Encontrar_Camino(textbox2);
    textbox2.AppendText("furgoneta:");
    furgoneta.Encontrar_Camino(textbox2);
    textbox2.AppendText("camioneta:");
    camioneta.Encontrar_Camino(textbox2);



    textbox1.AppendText(Environment.NewLine);
    ///////////////////////////////////////
    textbox1.AppendText("Lista express: ");
    textbox1.AppendText("Cargando furgon");
    furgon.pedidos = cMochila.KnapSack(lista_express.ToArray(), 10, 4900);
    foreach (Pedido pedidos in furgon.pedidos)
    {
        textbox1.AppendText(pedidos.producto);
        textbox1.AppendText(Environment.NewLine);
        lista_express.Remove(pedidos);
    }
    textbox1.AppendText("-----------------------------");
    foreach (Pedido pedidos in lista_express)
    {
        textbox1.AppendText(pedidos.producto);
        textbox1.AppendText(Environment.NewLine);

    }
    textbox1.AppendText("-----------------------------");

    textbox1.AppendText("Cargando furgoneta");
    furgoneta.pedidos = cMochila.KnapSack(lista_express.ToArray(), 17, 5000);
    foreach (Pedido pedidos in furgoneta.pedidos)
    {

        textbox1.AppendText(pedidos.producto);
        textbox1.AppendText(Environment.NewLine);
        lista_express.Remove(pedidos);
    }
    textbox1.AppendText("-----------------------------");
    foreach (Pedido pedidos in lista_express)
    {
        textbox1.AppendText(pedidos.producto);
        textbox1.AppendText(Environment.NewLine);

    }
    textbox1.AppendText("-----------------------------");


    textbox1.AppendText("Cargando camioneta");
    camioneta.pedidos = cMochila.KnapSack(lista_express.ToArray(), 3, 2500);
    foreach (Pedido pedidos in camioneta.pedidos)
    {

        textbox1.AppendText(pedidos.producto);
        textbox1.AppendText(Environment.NewLine);
        lista_normal.Remove(pedidos);
    }
    textbox1.AppendText("-----------------------------");
    foreach (Pedido pedidos in lista_express)
    {
        textbox1.AppendText(pedidos.producto);
        textbox1.AppendText(Environment.NewLine);


    }

    furgon.Encontrar_Camino(textbox1);
    textbox1.AppendText("furgoneta:");
    furgoneta.Encontrar_Camino(textbox1);
    textbox1.AppendText("camioneta:");
    camioneta.Encontrar_Camino(textbox1);

    void InitializeComponent()
    {
        this.textbox2 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textbox2.AcceptsReturn = true;
        this.textbox2.AcceptsTab = true;
        this.textbox2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textbox2.Multiline = true;
        this.textbox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(50, 100);
        this.Controls.Add(this.textbox2);
        this.Text = "TextBox Example";
        this.ResumeLayout(false);
        this.PerformLayout();
        ///////////////////////////////////////////////////////
        ///

        this.textbox1 = new System.Windows.Forms.TextBox();
        this.SuspendLayout();
        // 
        // textBox1
        // 
        this.textbox1.AcceptsReturn = true;
        this.textbox1.AcceptsTab = true;
        this.textbox1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.textbox1.Multiline = true;
        this.textbox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(50, 150);
        this.Controls.Add(this.textbox1);
        this.Text = "TextBox Example";
        this.ResumeLayout(false);
        this.PerformLayout();
    }
}
};