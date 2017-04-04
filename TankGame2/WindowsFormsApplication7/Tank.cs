using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication7
{
    class Tank
    {
        public int x = 10, y = 10, len = 100, w = 100, h = 100, r;
        public int x1 = 60, y1 = 60, x2 = 125, y2 = 60;
        public enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT
        }
        public Direction direction = Direction.RIGHT;
        

        public void Up(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Red), x, y, w, h);
            g.DrawLine(new Pen(Color.Black), x1, y1, x2, y2);

        }
        

        public void Left(Graphics g)
        {

        }

        public void Right(Graphics g)
        {

        }
    }
}
