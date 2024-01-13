using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Práctica6
{
    public partial class Principal : Form
    {
        private List<int> m_Valores= new List<int>();
        private int m_Indice = 0;
        private Thread m_HiloA;
        private ManualResetEvent m_PararHiloA = new ManualResetEvent(false);
        private ManualResetEvent m_ParadoHiloA = new ManualResetEvent(false);
        private Thread m_HiloB;
        private ManualResetEvent m_PararHiloB = new ManualResetEvent(false);
        private ManualResetEvent m_ParadoHiloB = new ManualResetEvent(false);
        public Principal()
        {
            InitializeComponent();
        }

        private void bt_Ocultar_Click(object sender, EventArgs e)
        {
            PicB.Visible = !PicB.Visible;
            bt_Ocultar.Text = PicB.Visible ? "Ocultar Imagen" : "Mostrar Imagen"; 
        }

        private void NumUD_ValueChanged(object sender, EventArgs e)
        {
            ProB.Maximum = (int)NumUD.Value;
            Console.WriteLine("Valor máximo de la barra de progreso:\t" + ProB.Maximum);
        }

        private void mn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Iniciar_Click(object sender, EventArgs e)
        {
            bt_Iniciar.Enabled = false;
            NumUD.Enabled = false;
            ProB.Value = 0;
            m_Indice = 0;

            while (m_Valores.Count > 0)
                m_Valores.RemoveAt(0);

            m_HiloA = new Thread(ActualizarA);
            m_HiloB = new Thread(ActualizarB);
       
            m_HiloA.Start();
            m_HiloB.Start();            
        }

        private void Progresar()
        {
            m_Valores.Add(m_Indice);   //Sucesión de valores añadidos
            ActualizarBarraProgreso();
            m_Indice++;

            if(m_Indice >= ProB.Maximum)
            {
                Inicializar();
            }
        }

        private void Inicializar()
        {
            if (bt_Iniciar.InvokeRequired)
            {
                MethodInvoker delegado = new MethodInvoker(Inicializar);
                bt_Iniciar.Invoke(delegado);
            }
            else 
            {
                bt_Iniciar.Enabled = true;
                NumUD.Enabled = true;
            } 
        }

        private void ActualizarBarraProgreso()
        {
            if (ProB.InvokeRequired)
            {
                MethodInvoker delegado = new MethodInvoker(ActualizarBarraProgreso);
                ProB.Invoke(delegado);
            }
            else
                ProB.PerformStep();
        }
        private void ActualizarA() 
        {
            while(m_Indice <= ProB.Maximum) 
            {
                if (m_PararHiloA.WaitOne(0))   // Sin esperar se verifica si se ha activado la señal parar
                {
                                             // Luego, activa la señal "Parado"
                    m_ParadoHiloA.Set();    // 
                    break;                 // Sale del bucle
                }
                lock (ProB)
                {
                    Progresar();
                }
            }
            for (int i = 0; i < m_Valores.Count; i++)
                if (i != m_Valores[i])
                {
                    MessageBox.Show("valores[" + i + "] = " + m_Valores[i] +
                    " y debía valer " + i);
                    break;
                }
        }


        private void PararHiloA()
        {
            if (m_HiloA != null && m_HiloA.IsAlive)
            {
                m_PararHiloA.Set();
                while (m_HiloA.IsAlive)
                {
                    m_ParadoHiloA.WaitOne(200, false); // evitar una espera activa 
                    Application.DoEvents();           // procesar eventos pendientes 
                }
                MessageBox.Show("HiloA Parado");
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            PararHiloA();
            PararHiloB();
        }

        private void ActualizarB()
        {
            while (m_Indice <= ProB.Maximum)
            {
                if (m_PararHiloB.WaitOne(0))
                {
                                             // Luego, activa la señal "Parado"
                    m_ParadoHiloB.Set();    // 
                    break;                 // Sale del bucle
                }
                lock (ProB)
                {
                    Progresar();
                }
            }
        }

        private void PararHiloB()
        {
            if (m_HiloB != null && m_HiloB.IsAlive)
            {
                m_PararHiloB.Set();
                while (m_HiloB.IsAlive)
                {
                    m_ParadoHiloB.WaitOne(200, false); // evitar una espera activa 
                    Application.DoEvents();           // procesar eventos pendientes 
                }
                MessageBox.Show("HiloB Parado");
            }
        }

        private void mn_Detener_Click(object sender, EventArgs e)
        {
            PararHiloA();
            PararHiloB();
            m_PararHiloA.Reset();
            m_PararHiloB.Reset();
            bt_Iniciar.Enabled = true;
            NumUD.Enabled = true;
            ProB.Value = 0;
        }
    }
}
/*La elección entre Invoke y BeginInvoke depende de los requisitos específicos de tu aplicación. 
 * Si necesitas que el hilo actual espere a que se complete la operación en la interfaz de usuario 
 * antes de continuar, utiliza Invoke. Si prefieres que el hilo actual no se bloquee 
 * y continúe ejecutándose de manera independiente, puedes optar por BeginInvoke.*/