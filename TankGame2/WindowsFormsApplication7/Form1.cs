using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        Tank tank = new Tank();
      
     
        
        public Form1()
        {
            InitializeComponent();
      
        }
        
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           tank.Up(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tank.direction == Tank.Direction.DOWN)
            {
                tank.y += 10;
                tank.y1 += 10;
                tank.y2 += 10;
               
            }
            if (tank.direction == Tank.Direction.RIGHT)
            {
                tank.x += 10;
                tank.x1 += 10;
                tank.x2 += 10;
                
            }
            if (tank.direction == Tank.Direction.LEFT)
            {
                tank.x -= 10;
                tank.x1 -= 10;
                tank.x2 -= 10;

            }
            if (tank.direction == Tank.Direction.UP)
            {
                tank.y -= 10;
                tank.y1 -= 10;
                tank.y2 -= 10;

            }
            Refresh();
        }
        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                tank.direction = Tank.Direction.DOWN;
                tank.x2 = tank.x1;
                tank.y2 = tank.y1 + 65;
            }
            if (e.KeyCode == Keys.D)
            {
                tank.direction = Tank.Direction.RIGHT;
                tank.x2 = tank.x1 + 65;
                tank.y2 = tank.y1;
            }
            if (e.KeyCode == Keys.A)
            {
                tank.direction = Tank.Direction.LEFT;
                tank.x2 = tank.x1 - 65;
                tank.y2 = tank.y1;
            }
            if (e.KeyCode == Keys.W)
            {
                tank.direction = Tank.Direction.UP;
                tank.x2 = tank.x1;
                tank.y2 = tank.y1 - 65;
            }
        }
       

       
    }
}
