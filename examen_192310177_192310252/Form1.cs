using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen_192310177_192310252
{
    public partial class Form1 : Form
    {
        Graphics papel;
        int Ancho = 592;
        int Alto = 479;
        //592, 479

        public Form1()
        {
            InitializeComponent();
            papel = pictureBox1.CreateGraphics();

        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Dibujo_Figura ObjF = new Dibujo_Figura();
            ObjF.DibujarF(ref papel, Alto, Ancho);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
