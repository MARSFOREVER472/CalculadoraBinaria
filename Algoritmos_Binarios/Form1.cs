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

            // AÑADIENDO TEXTO PARA LA CANTIDAD TOTAL DINÁMICAMENTE...

            totalTexto.Text = "Cantidad total: " + total;
            totalTexto.AutoSize = false; // EL TAMAÑO DE TEXTO SERÁ MANUAL.
            totalTexto.Width = this.ClientSize.Width; // ANCHO DE ESTE TEXTO POR DEFECTO.
            totalTexto.Height = 50; // LA ALTURA DEL TEXTO ES DE 50.
            totalTexto.TextAlign = ContentAlignment.MiddleCenter; // ALIENAMIENTO DE ESTE TEXTO EN EL CENTRO DE LA INTERFAZ.
            totalTexto.ForeColor = Color.DarkOrange; // EL COLOR DEL TEXTO SERÁ NARANJA.
            totalTexto.Font = new Font("Arial", 20); // TAMAÑO Y FUENTE DE ESTE TEXTO.
            totalTexto.Top = 230; // ESTE TEXTO SE UBICA A 230 DE ALTURA.
            this.Controls.Add(totalTexto); // AÑADE ESTE TEXTO TRAS COMPLETAR ESTE PROCEDIMIENTO.


            // ...FIN DE ESTE APARTADO!

            // APARTADO 3: AGREGAR LAS CASILLAS A DICHO NÚMERO BINARIO A CONVERTIR...

            // VARIABLES A DISTANCIAR MEDIANTE POSICIONES...

            int x = 30; // POSICIÓN DE DICHO COMPONENTE EN X.
            int y = 120; // POSICIÓN DE DICHO COMPONENTE EN Y.

            // CREAREMOS UN CICLO "for" PARA AGREGAR CADA CASILLA (EN TOTAL SON 8 DE ÉSTAS) CON SUS RESPECTIVOS ATRIBUTOS...

            for (int i = 0; i < 9; i++)
            {
                ComboBox casilla = new ComboBox(); // COMPONENTE ASOCIADO A CADA CASILLA.

                casilla.Width = 50; // ANCHO DE LA CASILLA.
                casilla.Items.Add("0"); // PRIMER NÚMERO BINARIO, SUPONGA QUE ESTÁ EN FALSO.
                casilla.Items.Add("1"); // SEGUNDO NÚMERO BINARIO, SUPONGA QUE ESTÁ EN VERDADERO.
                casilla.SelectedIndex = 0; // ÍNDICE POR DEFECTO PARA CADA CASILLA.
                casilla.Font = new Font("Arial", 16); // FUENTE Y TAMAÑO DE TEXTO PARA EL INTERIOR DE CADA CASILLA.
                casilla.DropDownStyle = ComboBoxStyle.DropDownList; // BOTONES DE CASILLA PARA AJUSTAR AL MAYOR O AL MENOR VALOR.
                casilla.Tag = valoresBinarios[i].ToString(); // ETIQUETA DE VALORES A LAS CASILLAS.
                casilla.Left = x; // CASILLAS ORIENTADAS HORIZONTALMENTE.
                casilla.Top = y; // CASILLAS ORIENTADAS VERTICALMENTE.
                casilla.FlatStyle = FlatStyle.Flat; // APARIENCIA DE CADA CASILLA POR DEFECTO.
                casilla.SelectionChangeCommitted += Casilla_Eleccion; // CONSEJO: CREAR ESTE MÉTODO ASOCIADO AL VALOR YA DECLARADO EN ESTA LÍNEA DE CÓDIGO.
                cajasDeValoresBinarios.Add(casilla);

                // ...FIN DE EDICIÓN DE LAS CASILLAS!!!!

                // ANTES DE CERRAR EL CICLO, AGREGAREMOS MÁS VARIABLES A LA INTERFAZ DINÁMICAMENTE...

                Label etiquetaValores = new Label(); // ETIQUETA DE VALORES.
                etiquetaValores.Text = valoresBinarios[i].ToString(); // TEXTO MEDIANTE VALORES BINARIOS POR CASILLA.
                etiquetaValores.Font = new Font("Arial", 16); // TAMAÑO Y FUENTE DE TEXTO HACIA LOS VALORES BINARIOS.
                etiquetaValores.Location = new Point(x, y - 32); // UBICACIÓN DE LOS VALORES BINARIOS POR CASILLAS.
                etiquetaValores.AutoSize = false; // LA ETIQUETA DE VALORES BINARIOS TENDRÁN UN TAMAÑO ESTÁTICO POR DEFECTO.
                etiquetaValores.Width = 50; // ANCHO DE LOS VALORES BINARIOS.
                etiquetaValores.Height = 30; // ALTURA DE LOS VALORES BINARIOS.

                Color barniz = Color.FromArgb(aleatorio.Next(200, 255), aleatorio.Next(150, 255), aleatorio.Next(150, 255)); // COLORES DE VALORES BINARIOS SERÁN ALEATORIOS.

                etiquetaValores.BackColor = barniz; // EL COLOR DE FONDO DE CADA VALOR DEPENDE DEL BARNIZ.
                etiquetaValores.ForeColor = Color.Black; // EL COLOR DE CUALQUIER VALOR BINARIO SIEMPRE SERÁ NEGRO.
                etiquetaValores.TextAlign = ContentAlignment.MiddleCenter; // LA ORIENTACIÓN DE LOS VALORES BINARIOS SIEMPRE SERÁ CENTRADO MEDIANTE SIMETRÍA PUNTUAL POR CADA CASILLA DE VALORES BINARIOS.
                casilla.BackColor = barniz; // EL COLOR DE CADA CASILLA DEPENDERÁ DEL BARNIZ YA DECLARADO ANTERIORMENTE.

                // FINALMENTE, SE VAN AÑADIENDO ESTAS VARIABLES UNA VEZ QUE SE DECLARARON VARIAS CARACTERÍSTICAS ASOCIADAS A ELLAS...

                this.Controls.Add(casilla);
                this.Controls.Add(etiquetaValores);

                // ...FIN DE ESTE CICLO!!!
            }

            // ...FIN DE ESTE APARTADO!!!!!
        }

        private void Casilla_Eleccion(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }
    }
}