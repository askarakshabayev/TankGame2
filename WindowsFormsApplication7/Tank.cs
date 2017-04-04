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
        Pen pen;
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

            g.DrawRectangle(pen, x - len / 2, y - len / 2, len, len);
            g.DrawEllipse(pen, x - r / 2, y - r / 2, r, r);
            g.DrawRectangle(pen, x - w / 2, y - h, w, h);
        }


        public void Down(Graphics g)
        {

        }

        public void Left(Graphics g)
        {
            g.DrawRectangle(new Pen(Color.Red), x - len / 2, y - len / 2, len, len);
            g.DrawEllipse(new Pen(Color.Red), x - r / 2, y - r / 2, r, r);
            g.DrawRectangle(new Pen(Color.Red), x - h, y - w / 2, h, w);
        }
        public void Right(Graphics g)
        {

        }
    }
}
