namespace Algoritmos_Binarios
{
    public partial class Form1 : Form
    {
        // VAMOS A CREAR VARIABLES PARA EL FORMULARIO DE MANERA DIN�MICA AQU�!!!!...

        int[] valoresBinarios = { 1, 2, 4, 8, 16, 32, 64, 128, 256 }; // VALORES BINARIOS POR CADA 8 BYTES.
        Random aleatorio = new Random(); // VARIABLE ALEATORIA.
        List<ComboBox> cajasDeValoresBinarios = new List<ComboBox>(); // VALORES BINARIOS EN CADA CUADRO.
        int total; // VALOR TOTAL BINARIO.
        int preguntaNumerica; // N�MERO POR PREGUNTAS.
        Label totalTexto = new Label(); // CANTIDAD TOTAL MEDIANTE CADENA DE TEXTO.
        Label pregunta = new Label(); // PREGUNTA MEDIANTE CADENA DE TEXTO.
        Label encabezado = new Label(); // ENCABEZADO DEL FORMULARIO MEDIANTE CADENA DE TEXTO.

        public Form1()
        {
            InitializeComponent();
        }

        public void CargarJuego()
        {
            Array.Reverse(valoresBinarios); // LOS VALORES BINARIOS DENTRO DE UN ARREGLO ESTAR�N AL REV�S.

            preguntaNumerica = 12; // LA CANTIDAD DE PREGUNTAS SER�N M�XIMO 12 DE ELLAS.

            this.BackColor = Color.FromArgb(64, 64, 64); // EL COLOR DE FONDO PARA CADA CUADRO VA A SER AL AZAR.
            this.Size = new Size(600, 383);

            // A�ADIENDO ENCABEZADO DE TEXTO DIN�MICAMENTE...

            encabezado.Text = " ***** CALCULADORA BINARIA ***** " + Environment.NewLine + " ***** DE 64 BITS *****";
            encabezado.AutoSize = false; // EL TAMA�O DEL ENCABEZADO SER� DE MANERA EST�TICA.
            encabezado.Width = this.ClientSize.Width; // ANCHO DEL ENCABEZADO POR DEFECTO HACIA AL CLIENTE.
            encabezado.Height = 70; // ALTURA DEL ENCABEZADO.
            encabezado.TextAlign = ContentAlignment.MiddleCenter; // ENCABEZADO DE TEXTO CENTRADO.
            encabezado.ForeColor = Color.DarkRed; // COLOR DEL ENCABEZADO DE TEXTO.
            encabezado.Font = new Font("Arial", 20); // TAMA�O Y FUENTE DE TEXTO PARA EL ENCABEZADO.
            this.Controls.Add(encabezado); // A�ADIENDO ENCABEZADO A LA INTERFAZ.

            // ...FIN DEL ENCABEZADO!

            // A�ADIENDO TEXTO PARA LA CANTIDAD TOTAL DIN�MICAMENTE...

            totalTexto.Text = "Cantidad total: " + total;
            totalTexto.AutoSize = false; // EL TAMA�O DE TEXTO SER� MANUAL.
            totalTexto.Width = this.ClientSize.Width; // ANCHO DE ESTE TEXTO POR DEFECTO.
            totalTexto.Height = 50; // LA ALTURA DEL TEXTO ES DE 50.
            totalTexto.TextAlign = ContentAlignment.MiddleCenter; // ALIENAMIENTO DE ESTE TEXTO EN EL CENTRO DE LA INTERFAZ.
            totalTexto.ForeColor = Color.DarkOrange; // EL COLOR DEL TEXTO SER� NARANJA.
            totalTexto.Font = new Font("Arial", 20); // TAMA�O Y FUENTE DE ESTE TEXTO.
            totalTexto.Top = 230; // ESTE TEXTO SE UBICA A 230 DE ALTURA.
            this.Controls.Add(totalTexto); // A�ADE ESTE TEXTO TRAS COMPLETAR ESTE PROCEDIMIENTO.


            // ...FIN DE ESTE APARTADO!

            // APARTADO 3: AGREGAR LAS CASILLAS A DICHO N�MERO BINARIO A CONVERTIR...

            // VARIABLES A DISTANCIAR MEDIANTE POSICIONES...

            int x = 30; // POSICI�N DE DICHO COMPONENTE EN X.
            int y = 120; // POSICI�N DE DICHO COMPONENTE EN Y.

            // CREAREMOS UN CICLO "for" PARA AGREGAR CADA CASILLA (EN TOTAL SON 8 DE �STAS) CON SUS RESPECTIVOS ATRIBUTOS...

            for (int i = 0; i < 9; i++)
            {
                ComboBox casilla = new ComboBox(); // COMPONENTE ASOCIADO A CADA CASILLA.

                casilla.Width = 50; // ANCHO DE LA CASILLA.
                casilla.Items.Add("0"); // PRIMER N�MERO BINARIO, SUPONGA QUE EST� EN FALSO.
                casilla.Items.Add("1"); // SEGUNDO N�MERO BINARIO, SUPONGA QUE EST� EN VERDADERO.
                casilla.SelectedIndex = 0; // �NDICE POR DEFECTO PARA CADA CASILLA.
                casilla.Font = new Font("Arial", 16); // FUENTE Y TAMA�O DE TEXTO PARA EL INTERIOR DE CADA CASILLA.
                casilla.DropDownStyle = ComboBoxStyle.DropDownList; // BOTONES DE CASILLA PARA AJUSTAR AL MAYOR O AL MENOR VALOR.
                casilla.Tag = valoresBinarios[i].ToString(); // ETIQUETA DE VALORES A LAS CASILLAS.
                casilla.Left = x; // CASILLAS ORIENTADAS HORIZONTALMENTE.
                casilla.Top = y; // CASILLAS ORIENTADAS VERTICALMENTE.
                casilla.FlatStyle = FlatStyle.Flat; // APARIENCIA DE CADA CASILLA POR DEFECTO.
                casilla.SelectionChangeCommitted += Casilla_Eleccion; // CONSEJO: CREAR ESTE M�TODO ASOCIADO AL VALOR YA DECLARADO EN ESTA L�NEA DE C�DIGO.
                cajasDeValoresBinarios.Add(casilla);

                // ...FIN DE EDICI�N DE LAS CASILLAS!!!!

                // ANTES DE CERRAR EL CICLO, AGREGAREMOS M�S VARIABLES A LA INTERFAZ DIN�MICAMENTE...

                Label etiquetaValores = new Label(); // ETIQUETA DE VALORES.
                etiquetaValores.Text = valoresBinarios[i].ToString(); // TEXTO MEDIANTE VALORES BINARIOS POR CASILLA.
                etiquetaValores.Font = new Font("Arial", 16); // TAMA�O Y FUENTE DE TEXTO HACIA LOS VALORES BINARIOS.
                etiquetaValores.Location = new Point(x, y - 32); // UBICACI�N DE LOS VALORES BINARIOS POR CASILLAS.
                etiquetaValores.AutoSize = false; // LA ETIQUETA DE VALORES BINARIOS TENDR�N UN TAMA�O EST�TICO POR DEFECTO.
                etiquetaValores.Width = 50; // ANCHO DE LOS VALORES BINARIOS.
                etiquetaValores.Height = 30; // ALTURA DE LOS VALORES BINARIOS.

                Color barniz = Color.FromArgb(aleatorio.Next(200, 255), aleatorio.Next(150, 255), aleatorio.Next(150, 255)); // COLORES DE VALORES BINARIOS SER�N ALEATORIOS.

                etiquetaValores.BackColor = barniz; // EL COLOR DE FONDO DE CADA VALOR DEPENDE DEL BARNIZ.
                etiquetaValores.ForeColor = Color.Black; // EL COLOR DE CUALQUIER VALOR BINARIO SIEMPRE SER� NEGRO.
                etiquetaValores.TextAlign = ContentAlignment.MiddleCenter; // LA ORIENTACI�N DE LOS VALORES BINARIOS SIEMPRE SER� CENTRADO MEDIANTE SIMETR�A PUNTUAL POR CADA CASILLA DE VALORES BINARIOS.
                casilla.BackColor = barniz; // EL COLOR DE CADA CASILLA DEPENDER� DEL BARNIZ YA DECLARADO ANTERIORMENTE.

                // FINALMENTE, SE VAN A�ADIENDO ESTAS VARIABLES UNA VEZ QUE SE DECLARARON VARIAS CARACTER�STICAS ASOCIADAS A ELLAS...

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