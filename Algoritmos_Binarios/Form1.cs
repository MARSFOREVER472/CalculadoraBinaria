namespace Algoritmos_Binarios
{
    public partial class Form1 : Form
    {
        // VAMOS A CREAR VARIABLES PARA EL FORMULARIO DE MANERA DINÁMICA AQUÍ!!!!...

        int[] valoresBinarios = { 1, 2, 4, 8, 16, 32, 64, 128, 256 }; // VALORES BINARIOS POR CADA 8 BYTES.
        Random aleatorio = new Random(); // VARIABLE ALEATORIA.
        List<ComboBox> cajasDeValoresBinarios = new List<ComboBox>(); // VALORES BINARIOS EN CADA CUADRO.
        int total; // VALOR TOTAL BINARIO.
        int preguntaNumerica; // NÚMERO POR PREGUNTAS.
        Label totalTexto = new Label(); // CANTIDAD TOTAL MEDIANTE CADENA DE TEXTO.
        Label pregunta = new Label(); // PREGUNTA MEDIANTE CADENA DE TEXTO.
        Label encabezado = new Label(); // ENCABEZADO DEL FORMULARIO MEDIANTE CADENA DE TEXTO.

        public Form1()
        {
            InitializeComponent();
        }

        public void CargarJuego()
        {
            Array.Reverse(valoresBinarios); // LOS VALORES BINARIOS DENTRO DE UN ARREGLO ESTARÁN AL REVÉS.

            preguntaNumerica = 12; // LA CANTIDAD DE PREGUNTAS SERÁN MÁXIMO 12 DE ELLAS.

            this.BackColor = Color.FromArgb(64, 64, 64); // EL COLOR DE FONDO PARA CADA CUADRO VA A SER AL AZAR.
            this.Size = new Size(600, 383);

            // AÑADIENDO ENCABEZADO DE TEXTO DINÁMICAMENTE...

            encabezado.Text = " ***** CALCULADORA BINARIA ***** " + Environment.NewLine + " ***** DE 64 BITS *****";
            encabezado.AutoSize = false; // EL TAMAÑO DEL ENCABEZADO SERÁ DE MANERA ESTÁTICA.
            encabezado.Width = this.ClientSize.Width; // ANCHO DEL ENCABEZADO POR DEFECTO HACIA AL CLIENTE.
            encabezado.Height = 70; // ALTURA DEL ENCABEZADO.
            encabezado.TextAlign = ContentAlignment.MiddleCenter; // ENCABEZADO DE TEXTO CENTRADO.
            encabezado.ForeColor = Color.DarkRed; // COLOR DEL ENCABEZADO DE TEXTO.
            encabezado.Font = new Font("Arial", 20); // TAMAÑO Y FUENTE DE TEXTO PARA EL ENCABEZADO.
            this.Controls.Add(encabezado); // AÑADIENDO ENCABEZADO A LA INTERFAZ.

            // ...FIN DEL ENCABEZADO!
        }
    }
}