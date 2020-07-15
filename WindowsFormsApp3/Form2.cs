using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
            MessageBox.Show(cliente.intCounter().ToString());
            MessageBox.Show(cliente.intCounter().ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {

            ServiceReference2.Service2Client cliente1 = new ServiceReference2.Service2Client();
            MessageBox.Show(cliente1.intCountersession().ToString());
           // MessageBox.Show(cliente1.intCountersession().ToString());           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ServiceReference3.Service3Client cliente2 = new ServiceReference3.Service3Client();
            //contador++;
            MessageBox.Show(cliente2.contadorSingle().ToString());
        }
    }
}
