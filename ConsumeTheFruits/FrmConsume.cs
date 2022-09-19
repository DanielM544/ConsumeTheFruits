﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumeTheFruits
{
    public partial class FrmConsume : Form
    {
        Graphics g; //declare a graphics object called g

        // declare space for an array of 7 objects called Fruit 
        Fruit[] fruit = new Fruit[10];
        Dino dino = new Dino();
        Random yspeed = new Random();
        bool left, right;
        string move;


        public FrmConsume()
        {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
            {
                int x = 40 + (i * 75);
                fruit[i] = new Fruit(x);

            }

        }

        private void FrmConsume_Load(object sender, EventArgs e)
        {

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 10; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                fruit[i].y += rndmspeed;
                dino.DrawDino(g);
                fruit[i].DrawFruit(g);

            }


        }

        private void TmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                fruit[i].MoveFruit();

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (fruit[i].y >= PnlGame.Height)
                {
                    fruit[i].y = 30;
                }

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }

        private void PnlGame_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmConsume_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }

        }

        private void FrmConsume_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void TmrDino_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                dino.MoveDino(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                dino.MoveDino(move);
            }

        }

        private void True(object sender, PreviewKeyDownEventArgs e)
        {

        }
    }
}
