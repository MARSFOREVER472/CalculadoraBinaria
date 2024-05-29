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
    }
}