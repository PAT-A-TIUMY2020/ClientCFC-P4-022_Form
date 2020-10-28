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
using ServiceMtk_P1_20180140022;

namespace ClientCFC_P4_022_Form
{
    public partial class Form1 : Form
    {

        BasicHttpBinding bind = new BasicHttpBinding();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();
            try
            {
                int val1 = Int32.Parse(textBox1.Text);
                int val2 = Int32.Parse(textBox2.Text);
                string selectedItem = comboBox1.Items[comboBox1.SelectedIndex].ToString();
                Console.WriteLine(selectedItem);

                double result = 0;

                switch (selectedItem)
                {
                    case "+":
                        result = obj.Tambah(val1, val2);
                        break;
                    case "-":
                        result = obj.Kurang(val1, val2);
                        break;
                    case "*":
                        result = obj.Kali(val1, val2);
                        break;
                    case ":":
                        result = obj.Bagi(val1, val2);
                        break;
                }

                label4.Text = result.ToString();

            }
            catch { };
        }
    }
}
