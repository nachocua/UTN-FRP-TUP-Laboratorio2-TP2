using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class VentanaGraficos : Form
    {
       
        //private int[] barras = { 100, 50, 25 };
        private int[] barras;

        private int[] personasPorHabitacion = { 88, 3, 4, 15, 20 };
        private string[] personalsLabel = { "2P", "3P", "4P", "5P", "6+P" };
        private string[] propiedades = { "Casa por dia", "Casa fin de semana", "Hotel" };
        

        private int anchoPanel = 500;
        private int altoPanel = 400;
        private int entrePanel = 80;
        private int constanteAltura = 4;

        // coordenadas panel
        private int xPanel = 50;
        private int yPanel = 30;
        private int yLabel;

        int YlabelAclaracion = 480;

        int fontSm = 10;
        int fontextraSm = 8;

        // Colores
        private Color[] coloresFavoritos = new Color[]
       {
            Color.FromArgb(190, 199, 180),    //  X11 Gray
            Color.FromArgb(222, 226, 217),    // Gainsboro
            Color.FromArgb(242, 203, 187),    // BabyPink
            Color.FromArgb(159, 164, 207),    // Blue Bell
       };
        //public Color[] Colores  = { Color.Blue, Color.Black, Color.Yellow };

        public VentanaGraficos(int[] propiedades )
        {
            InitializeComponent();
            InitializeUI();
            barras = propiedades;
        }

        private void InitializeUI()
        {
            // Panel Grafico de Barras
            Panel panelBarras = new Panel();
            panelBarras.Size = new Size(anchoPanel, altoPanel);
            panelBarras.Location = new Point(xPanel, yPanel);
            panelBarras.BackColor = Color.White;  // Fondo blanco para el panel
            Controls.Add(panelBarras);

            // Panel Grafico de Sectores
            Panel panelSectores = new Panel();
            panelSectores.Size = new Size(anchoPanel, altoPanel);
            panelSectores.Location = new Point(anchoPanel + entrePanel, yPanel);
            panelSectores.BackColor = Color.White;  // Fondo blanco para el panel
            Controls.Add(panelSectores);

            // Suscribirse al evento Paint del panel
            panelBarras.Paint += DrawingPanel1_Paint;
            panelSectores.Paint += DrawingPanel2_Paint;
            // Redibujar el panel para que se ejecute el evento Paint
            panelBarras.Invalidate();
        }


        private void DrawingPanel1_Paint(object sender, PaintEventArgs e)
        {      // Grafico de barras

            // Obtener el objeto Graphics para el panel
            Graphics g = e.Graphics;
            int xGrafico = 100;
            int yGrafico = 400;
            int anchoGrafico = 50;

            int x = 80;
            int y = 410;
            yLabel = yPanel + altoPanel + 3; // Coordenada Y de todos los label de Propiedad

            //// Dibujar una línea negra horizontal en el medio del formulario
            /* Pen pen = new Pen(Color.Black, 1);*/ // Grosor de 1 (puedes ajustar según sea necesario)
                                                    //int yLinea = y + 1;  // Posición vertical en el medio
                                                    //g.DrawLine(pen, x, yLinea, this.ClientSize.Width, yLinea);
                                                    //g.DrawLine(pen, x, 0, x, this.ClientSize.Height); // linea vertical

            // Dibujar una línea horizontal
            Pen penHorizontal = new Pen(Color.Black, 1);  // Puedes ajustar el grosor según tus necesidades
            int yPenHorizontal = altoPanel / 2;  // Posición vertical de la línea
            int startX = x;  // Punto de inicio horizontal
            int endX = 500;   // Punto de fin horizontal

            // Label Escala 50
            Label esc50 = new Label();
            esc50.Text = "50";
            esc50.Size = new Size(28, 18);
            esc50.Font = new Font("Arial", 10, FontStyle.Bold);
            // Establecer la posición del Label
            esc50.Location = new Point(x + 10, yPenHorizontal + 20);

            // Agregar el Label al formulario
            Controls.Add(esc50);
            esc50.BringToFront();
            g.DrawLine(penHorizontal, startX, yPenHorizontal, endX, yPenHorizontal);

            // Label Escala 20
            int yPenHorizontal2 = altoPanel * 80 / 100;  // Posición vertical de la línea
            g.DrawLine(penHorizontal, startX, yPenHorizontal2, endX, yPenHorizontal2);
            Label esc10 = new Label();
            esc10.Text = "20";
            esc10.Size = new Size(28, 18);
            esc10.Font = new Font("Arial", 10, FontStyle.Bold);

            // Establecer la posición del Label
            esc10.Location = new Point(x + 10, yPenHorizontal2 + 20);
            // Agregar el Label al formulario
            Controls.Add(esc10);
            esc10.BringToFront();

            // Label Escala 100
            int yPenHorizontal3 = altoPanel * 20 / 100;  // Posición vertical de la línea
            g.DrawLine(penHorizontal, startX, yPenHorizontal3, endX, yPenHorizontal3);
            Label esc90 = new Label();
            esc90.Text = "80";
            esc90.Size = new Size(28, 18);
            esc90.Font = new Font("Arial", 10, FontStyle.Bold);

            // Establecer la posición del Label
            esc90.Location = new Point(x + 10, yPenHorizontal3 + 20);
            // Agregar el Label al formulario
            Controls.Add(esc90);
            esc90.BringToFront();

           
            // ********** Grafico de Barras  **********

            int fontSize = 10;
            int n = 0;
            int xlabelGraficos = xGrafico + 65;

            
           
             // Label Aclaracion
            Label aclaracionP = new Label();
            aclaracionP.Text = "P = Personas por habitacion de Hotel";
            aclaracionP.Size = new Size(280, 18);
            aclaracionP.Font = new Font("Arial", 9, FontStyle.Bold);
            aclaracionP.Location = new Point(150, YlabelAclaracion);
            Controls.Add(aclaracionP);
            aclaracionP.BringToFront();

            foreach (var item in personasPorHabitacion)
            {             
                int yEscala = yGrafico - (item * constanteAltura);
                if (yEscala < 15)
                {
                    yEscala = 15;
                }

                Rectangle rect = new Rectangle(xGrafico, yEscala, anchoGrafico, item * constanteAltura);
                g.FillRectangle(Brushes.MediumSlateBlue, rect);
                // g.DrawRectangle(Pens.Black, rect);

                // Label Personas
                Label propiedad = new Label();
                propiedad.Text = personalsLabel[n];
                propiedad.Size = new Size(40, 60);
                propiedad.Font = new Font("Arial", fontSm, FontStyle.Bold);
                //Establecer la posición del Label
                propiedad.Location = new Point(xlabelGraficos, yLabel);
                //Agregar el Label al formulario
                Controls.Add(propiedad);

                // Label Numero para cada Barra
                Label numerosBarra = new Label();
                numerosBarra.Size = new Size(26, 13);
                numerosBarra.Font = new Font("Arial", fontSize, FontStyle.Bold);
                numerosBarra.BackColor = Color.White;
                numerosBarra.Text = item.ToString("00");

                numerosBarra.Location = new Point(xGrafico + 65, yEscala + 14);
                Controls.Add(numerosBarra);
                numerosBarra.BringToFront();

                xGrafico += anchoGrafico + 30;
                n++;
                xlabelGraficos = xlabelGraficos + 80;
            }
        }


        private void DrawingPanel2_Paint(object sender, PaintEventArgs e)
        {   // Calcular la suma de los elementos del arreglo
            float suma = barras.Sum();
            //yLabel = yPanel + altoPanel;

            // ********** Grafico de Sectores  **********
            Graphics g = e.Graphics;

            //int w = anchoPanel ;
            //int h = altoPanel ;

            int w = 380;
            int h = 380;

            #region margenes
            float m = 20;
            #endregion

            #region area cliente
            float wc = w - 2 * m;
            float hc = h - 2 * m;
            #endregion

            #region centro
            //float x0 = wc / 2 + m + 20 ;
            //float y0 = hc / 2 + m;

            float x0 = wc / 2 + m + 20 + 55;
            float y0 = hc / 2 + m + 10;
            #endregion

            float ang0 = 0;
            int n = 0;
            int xNum = 650;
            int xincremento = 260;

            // Label Aclaracion
            Label aclaracionP = new Label();
            aclaracionP.Text = "Porcentaje en total de Reservas";
            aclaracionP.Size = new Size(280, 18);
            aclaracionP.Font = new Font("Arial", 9, FontStyle.Bold);
            aclaracionP.Location = new Point(700, YlabelAclaracion);
            Controls.Add(aclaracionP);
            aclaracionP.BringToFront();

            foreach (float valor in barras)
            {
                float sector = (valor / suma) * 360;
                Brush brush = new SolidBrush(coloresFavoritos[n]);
                g.FillPie(brush, x0 - w / 2, y0 - hc / 2, wc, hc, ang0, sector);
                ang0 += sector;

                if (n > 0) xNum = xNum - 100;

                // Crear un Panel que actúe como un cuadrado
                Panel cuadradoPanel = new Panel();
                cuadradoPanel.Size = new System.Drawing.Size(16, 16); // Establecer el tamaño para hacer un cuadrado
                cuadradoPanel.Location = new System.Drawing.Point(xNum - 20, 434); // Establecer la posición en el formulario
                cuadradoPanel.BackColor = coloresFavoritos[n]; // Establecer el color 
                Controls.Add(cuadradoPanel);
                cuadradoPanel.BringToFront();

                // Labels De Sectores
                Label num = new Label();
                num.Text = propiedades[n];
                num.Size = new Size(96, 60);
                num.Font = new Font("Arial", fontSm, FontStyle.Bold);

                // Posición del Label
                num.Location = new Point(xNum, yLabel);
                // Agregar el Label al formulario
                Controls.Add(num);
                n++;
                xNum = xNum + xincremento;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
