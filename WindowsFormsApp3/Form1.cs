using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form

    {
        ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int n = Convert.ToInt32(textBox1.Text);
                label2.Text = cliente.operation(n).ToString();
                        

            }
            catch(FaultException<ServiceReference1.ArgumentFault> aex)
            {
                label2.Text = "Msj Argument: " + aex.Detail.Message;
                

            }
            catch (FaultException<ServiceReference1.InvalidOperationFault> iox)
            {
                label2.Text = "Msj InvalidOperation: " + iox.Detail.Message;
            }
            catch (Exception ex)
            {
                label2.Text = "Error desconocido: " + ex.Message;
            }

        }
    }
}
