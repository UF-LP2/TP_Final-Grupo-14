using csvfiles;
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

        
        TextBox textbox1 = new TextBox();
        textbox1.Multiline = true;
        //  textbox1.Text = "hola";
        textbox1.AcceptsReturn = true;
        textbox1.AcceptsTab = true;
        textbox1.Dock = System.Windows.Forms.DockStyle.Fill;
        textbox1.Multiline = true;
        textbox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        // 
        // Form1
        // 
        this.ClientSize = new System.Drawing.Size(284, 264);
        this.Controls.Add(textbox1);
        this.Text = "TextBox Example";
        this.ResumeLayout(false);
        this.PerformLayout();


        foreach (Pedido pedido in Pedidos)
        {
            pedido.volumen = pedido.ancho / 100 * pedido.alto / 100 * pedido.largo / 100;
            pedido.volumen_casteado = (int)pedido.volumen + 1;


            textbox1.AppendText(pedido.producto);
            textbox1.AppendText(Environment.NewLine);

            pedido.peso_casteado = (int)pedido.peso + 1;
            if (pedido.prioridad == 1)
            {
                lista_normal.Add(pedido);
            }
            else if (pedido.prioridad == 2)
            {
                lista_diferida.Add(pedido);
            }
            else if (pedido.prioridad == 3)
            {
                lista_express.Add(pedido);
            }

            Label mylab = new Label();
            mylab.Text = pedido.producto;

            //mylab.Location = new Point(222, 90);
        }

        
        cFurgon furgon_a_cargar = new cFurgon();
        furgon_a_cargar.pedidos = cMochila.KnapSack(lista_normal.ToArray(), 10);

        cCamioneta camioneta_a_cargar = new cCamioneta();
        camioneta_a_cargar.pedidos=cMochila.KnapSack(lista_normal.ToArray(), 3);

        cFurgoneta furgoneta_a_cargar = new cFurgoneta();
        furgoneta_a_cargar.pedidos= cMochila.KnapSack(lista_normal.ToArray(), 17);
    }
}
