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
        public int x, y, len, w, h, r;
        public int x1, y1, x2, y2;
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
            g.DrawEllipse(new Pen(Color.Red), x1, y1, x2, y2);

        }

        public void Down(Graphics g) {

        }

        public void Left(Graphics g)
        {

        }

        public void Right(Graphics g)
        {

        }
    }
}
