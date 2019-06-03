using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace Pomodoro_Baur
{
    public partial class Cuadro_Principal : Form
    {
        public int i = 0 , alltimeA = 1500 , alltimeB = 300 ;
        bool pomodoro = true;
        string direccionA;
        
        public Cuadro_Principal()
        {
            InitializeComponent();
        }
        public void Alarma()
        {
            SoundPlayer inicia = new SoundPlayer();
            inicia.SoundLocation = direccionA;
            inicia.Play();
        }

        private void BA_Alarma_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.DefaultExt = "wav";
            buscar.Filter = "Archivos wav (*.wav) |*.wav";

            if (buscar.ShowDialog() == DialogResult.OK)
            {
               // l_pista.Text = buscar.FileName;
                //string namePista = buscar.FileName;
                string caracter = "\\";
                short salida = 0;
                for ( short i = 0; i < (buscar.FileName.Length-3); i++ )
                {
                    string paso = buscar.FileName.Substring(i , 1);
                    if (paso == caracter)
                    {
                        salida = i ;
                    }
                }
                salida++;
                string name = buscar.FileName.Substring( salida, (buscar.FileName.Length-salida-4));
                l_pista.Text = name;
                this.direccionA = buscar.FileName;

                B_Star.Enabled = true ;
            }
        }

        private void B_Star_Click(object sender, EventArgs e)
        {
            b_Pause.Enabled = true ;
            b_borrar.Enabled = true;
            t_Cronometro.Enabled = true;
            l_status.Text = "Tiempo restante.";
        }

        private void B_Pause_Click(object sender, EventArgs e)
        {
            t_Cronometro.Stop();
            l_status.Text = "En pausa, da click en iniciar.";
        }

        private void B_borrar_Click(object sender, EventArgs e)
        {
            t_Cronometro.Stop();
            l_time.Text = "25:00";
            b_Pause.Enabled = false;
            i = 0;
            l_status.Text = "Da click en Iniciar.";
        }

        private void T_Cronometro_Tick(object sender, EventArgs e)
        {
            i++;

            if ( pomodoro )
            {
                int paso = (alltimeA - i);
                if (paso < 60)
                {
                    l_time.Text = paso.ToString("00:00");
                }
                else if (paso == 0 )
                {
                    l_time.Text = "00:00";
                    this.pomodoro = false;
                    this.WindowState = FormWindowState.Normal;
                    this.i = 0;
                    //this.MaximizeBox = true ;
                    Alarma();
                }
                else
                {
                    l_time.Text = (paso / 60).ToString("00") + ":" + (paso % 60).ToString("00");
                }
            }else
            {
                int paso = (alltimeB - i);
                if (paso < 60)
                {
                    l_time.Text = paso.ToString("00:00");
                }
                else if (paso == 0 )
                {
                    l_time.Text = "00:00";
                    this.pomodoro = true;
                    this.i = 0;
                    //Alarma();

                }
                else
                {
                    l_time.Text = (paso / 60).ToString("00") + ":" + (paso % 60).ToString("00");
                }
            }

        }
    }
}
