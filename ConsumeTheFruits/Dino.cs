using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ConsumeTheFruits
{
    class Dino
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image dino;//variable for the planet's image

        public Rectangle dinoRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Dino()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            dino = Properties.Resources.dino1;
            dinoRec = new Rectangle(x, y, width, height);
        }
        //methods
        public void DrawDino(Graphics g)
        {

            g.DrawImage(dino, dinoRec);
        }

    }
}
