using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınav_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSeç_Click(object sender, EventArgs e)
        {
           if (rbTek.Checked)
            {
                for(int i = 1; i < 10; i += 2)
                {
                    lstSayilar.Items.Add(i.ToString());
                }
            }
            else
            {
                for(int i=0; i < 10; i += 2)
                {
                    lstSayilar.Items.Add(i.ToString());
                }
            }
               
            
                
            }
           
        }
    }

