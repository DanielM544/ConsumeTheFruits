using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace ConsumeTheFruits
{
    class Fruit
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image fruitImage;//variable for the planet's image
        public Rectangle fruitRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Fruit(int spacing)
        {
            x = spacing;

            y = 10;
            width = 20;
            height = 20;
            //planetImage contains the plane1.png image
            fruitImage = Properties.Resources.fruit1;
            fruitRec = new Rectangle(x, y, width, height);
        }
        // Methods for the Planet class
        public void DrawFruit(Graphics g)
        {
            fruitRec = new Rectangle(x, y, width, height);
            g.DrawImage(fruitImage, fruitRec);
        }
        public void MoveFruit()
        {

            fruitRec.Location = new Point(x, y);
        }

    }
}
