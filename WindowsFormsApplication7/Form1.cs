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
      //  Graphics g;
     /*    void DrawTank(Tank tank)
        {
            g.DrawEllipse(new Pen(Color.Red), tank.x1, tank.y1, tank.x2, tank.y2);

        }*/
        public Form1()
        {
            InitializeComponent();
            tank.x1 = 10;
            tank.y1 = 100;
            tank.x2 = 100;
            tank.y2 = 100;
           // DrawTank(tank);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //MessageBox.Show(tank.x1 + " " + tank.y1);
            e.Graphics.DrawEllipse(new Pen(Color.Red), tank.x1, tank.y1, 100, 100);
           // tank.Up(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tank.direction == Tank.Direction.DOWN)
            {
                tank.y1 += 5;
            }
            else if (tank.direction == Tank.Direction.UP)
            { tank.y1 -= 5; }

            else if (tank.direction == Tank.Direction.LEFT)
            { tank.x1 -= 5; }
            else if (tank.direction == Tank.Direction.RIGHT)
            { tank.x1 += 5; }
            /*   switch (tank.direction)
               {
                   case tank.Up:

                  

               }*/
            Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                tank.direction = Tank.Direction.DOWN;
            }
            if (e.KeyCode == Keys.Up)
            {
                tank.direction = Tank.Direction.UP;
            }
            if (e.KeyCode == Keys.Right)
            {
                tank.direction = Tank.Direction.RIGHT;
            }
            if (e.KeyCode == Keys.Left)
            {
                tank.direction = Tank.Direction.LEFT;
            }
        }
    }
}
