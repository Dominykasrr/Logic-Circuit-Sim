using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circuit_Simulator
{
    public partial class Form1 : Form
    {
        List<int> i = new List<int>();
        int e;
        public Form1()
        {
            InitializeComponent();
        }

            // I wanna find a point
        void makeConnection()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
        }
        private void OnMouseClick(MouseEventArgs e) 
        {
             FindConnection(e.X, e.Y);
            
        }
        private void FindConnection(int X,int Y)
        {

        }
        
    }
}
