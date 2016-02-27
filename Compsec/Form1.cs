using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Compsec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        

            /*Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE");
            String name = textBox2.Text;
            try
            {
                key.CreateSubKey(textBox1.Text);
                key.SetValue(name,textBox2.Text);
            }
            catch
            {
                MessageBox.Show("Couldnot ");

            }
             */

           // string var1 = textBox1.Text;


            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("SOFTWARE\\Quiz1");
          //  key.SetValue(var1, "Isabella");
            key.Close();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            string var1 = textBox1.Text;
            Microsoft.Win32.RegistryKey key;
            key = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("SOFTWARE\\Quiz1",true);
            key.SetValue(var1, "This is a settings generated from the app");
            key.Close();    
        }

        

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Quiz1"))
                {

                    if (key != null)
                    {

                        Object o = key.GetValue("Application Settings");
                        if (o != null)
                        {
                            MessageBox.Show(o.ToString());
                            Version version = new Version(o as String);
                        }
                    }
                }

            }
            catch
            {

            }
            
            
        }
        
    }
}
