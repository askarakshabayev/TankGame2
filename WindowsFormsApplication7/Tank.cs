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
        public int x = 80, y = 80, len = 140, w = 20, h = 100, r = 30;
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
            g.DrawEllipse(new Pen(Color.Red), 10, 10, 100, 100);
        }

        public void Down(Graphics g)
        {
            g.DrawEllipse(new Pen(Color.Black), x - r / 2, y - r / 2, r, r);
            g.DrawRectangle(new Pen(Color.Black), x - len / 2, y - len / 2, len, len);
            g.DrawRectangle(new Pen(Color.Black), x - w / 2, y, w, h);
        }

        public void Left(Graphics g)
        {

        }

        public void Right(Graphics g)
        {

        }
    }
}
