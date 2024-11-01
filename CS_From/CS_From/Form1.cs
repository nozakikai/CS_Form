using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_From
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            { 
                    TestButton testButton = new TestButton(i,i%3 * 100, i/3 *100, 100, 100);
                    Controls.Add(testButton);
                
               


            }
            //TestButton testButton = new TestButton(400,40,100,100);
            // Controls.Add(testButton);
            //
            //TestButton testButton2 = new TestButton(15,15,15,15);
            // Controls.Add(testButton2);
            //
            // TestButton testButton3 = new TestButton(20, 20,20, 20);
            // Controls.Add(testButton3);
            //
            // TestButton testButton4 = new TestButton(30, 30, 30,30);
            // Controls.Add(testButton4);
            //
            // TestButton testButton5 = new TestButton(60, 20, 30, 30);
            // Controls.Add(testButton5);
            //
            // TestButton testButton6 = new TestButton(80, 20, 30, 30);
            // Controls.Add(testButton6);
            //
            // TestButton testButton7 = new TestButton(100, 20, 110, 40);
            // Controls.Add(testButton7);
            //
            // TestButton testButton8 = new TestButton(60, 120, 55, 40);
            // Controls.Add(testButton8);
            //
            // TestButton testButton9 = new TestButton(140, 100, 50, 40);
            // Controls.Add(testButton9);
            //
            // TestButton testButton10 = new TestButton(200, 120, 50, 40);
            // Controls.Add(testButton10);
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
