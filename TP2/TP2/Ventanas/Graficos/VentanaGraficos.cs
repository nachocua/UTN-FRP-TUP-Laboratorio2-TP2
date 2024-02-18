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
        //  personasPorHabitacion = { 58, 3, 49, 15, 20 };
        private int[] sectores = new int[2]; // datos para grafico sectores
        private int[] personasPorHabitacion;        

        private string[] personasPorHabLabel = { "2P", "3P", "4P", "5P", "6+P" };
        private string[] propiedades = { "Hotel", "Casas" };
        private string[] labelsEscala = { "80", "50", "20"};

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
            //Color.FromArgb(222, 226, 217),    // Gainsboro
            Color.FromArgb(242, 203, 187),    // BabyPink
            Color.FromArgb(159, 164, 207),    // Blue Bell
        };
        //public Color[] Colores  = { Color.Blue, Color.Black, Color.Yellow };

        public VentanaGraficos(int[] barras , int[] CantidadPorTipoPropiedad)
        {
            InitializeComponent();
            InitializeUI();
            personasPorHabitacion = barras; // "2P", "3P", "4P", "5P", "6+P"
            sectores = CantidadPorTipoPropiedad; // cant de casas y hotel para grafico Sectores            
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
            
            Graphics g = e.Graphics;
            int xGrafico = 100;
            int yGrafico = 400;
            int anchoGrafico = 50;
            int x = 80;
            int y = 410;
            yLabel = yPanel + altoPanel + 3; // Coordenada Y de todos los label de Propiedad

            // Variables para Linea horizontal Escala
            Pen penHorizontal = new Pen(Color.Black, 1);  // Puedes ajustar el grosor según tus necesidades
            int yPenHorizontal = altoPanel / 2;  // Posición vertical de la línea
            int startX = x;  // Punto de inicio horizontal
            int endX = 500;   // Punto de fin horizontal          
                     
            // ********** Grafico de Barras  **********

            int fontSize = 10;
            int n = 0;
            int xlabelGraficos = xGrafico + 65;
            int yLineaEscala = 0;
            int xStartLinea = 50;
            int xEndLinea = 450;
            Font Arial = new Font("Arial", fontSize, FontStyle.Bold);

            // Label Aclaracion
            Label aclaracionP = new Label();
            aclaracionP.Text = "P = Personas por habitacion ";
            aclaracionP.Size = new Size(280, 18);
            aclaracionP.Font = Arial;
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
                propiedad.Text = personasPorHabLabel[n];
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

                if (n < 3)
                {
                    // Labels Escala
                    int yLineaHorizontal3 = altoPanel * Convert.ToInt32(labelsEscala[2-n]) / 100;  // Posición vertical de Label escala
                    Label escala = new Label();
                    escala.BackColor = Color.White;
                    escala.Text = labelsEscala[n];
                    escala.Size = new Size(28, 18);
                    escala.Font = Arial;
                    escala.Location = new Point( x+ 10, yLineaHorizontal3 + 20);
                    Controls.Add(escala);
                    escala.BringToFront() ;

                    // Line Horizontal Escala   //g.DrawLine(pen, startingPoint, endPoint);
                    g.DrawLine(penHorizontal, startX, yLineaHorizontal3, endX, yLineaHorizontal3);// Posición vertical de la línea
                }
                
                xGrafico += anchoGrafico + 30;
                n++;
                xlabelGraficos = xlabelGraficos + 80;
            }
        }


        private void DrawingPanel2_Paint(object sender, PaintEventArgs e)
        {   // Calcular la suma de los elementos del arreglo
            float suma = sectores.Sum();
            //yLabel = yPanel + altoPanel;

            // ********** Grafico de Sectores  **********
            Graphics g = e.Graphics;
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
            int xNum = 720; // posicion x del primer label de sectores
            int xincremento = 260;
            float sector;
            float sectorPocentaje;

            // Label Aclaracion
            Label aclaracionP = new Label();
            aclaracionP.Text = "Porcentaje en total de Reservas" + " " + suma.ToString();
            aclaracionP.Size = new Size(280, 18);
            aclaracionP.Font = new Font("Arial", 9, FontStyle.Bold);
            aclaracionP.Location = new Point(700, YlabelAclaracion);
            Controls.Add(aclaracionP);
            aclaracionP.BringToFront();

            foreach (float valor in sectores)
            {
                if (suma == 0)
                {
                     sector = 0;
                    sectorPocentaje = 0;
                }
                else
                {
                     sector = (valor / suma) * 360;
                    sectorPocentaje = (valor / suma) * 100;
                }
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
                num.Text = propiedades[n] + " " + valor.ToString("00") + " - " + sectorPocentaje.ToString("00") + "%";
                num.Size = new Size(120, 60);
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
