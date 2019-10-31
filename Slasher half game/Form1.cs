using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Slasher_half_game
{
    public partial class Form1 : Form
    {
        Random randGen = new Random();
        bool carGas = false;
        int scene = 20;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

           
            if (e.KeyCode == Keys.M)       //red button press
            {

                if (scene == 20)
                {

                    scene = 21;
                    carGas = true;
                }
                //cut wood or set up chairs
                else if (scene == 21) { scene = 22; }
                //statrting campfire, some noises
                else if (scene == 22) { scene = 24; }
                //else if (scene == 23) { scene = 24; }
                else if (scene == 24) { scene = 30; }
                //60/40 chance of escaping and living
                // else if (scene == 25) { scene = 26; }
                else if (scene == 26) { scene = 27; }
                else if (scene == 27)
                {
                    carGas = true;
                    scene = 28;
                }
                else if (scene == 28) { scene = 21; }
                //else if (scene == 28) { scene = 29; }
                else if (scene == 30)
                {
                    double randValue = randGen.Next(1, 101);
                    if (randValue <= 60)
                    {
                        scene = 32;
                    }
                    else scene = 0;
                }
                else if (scene == 31) { scene = 40; }
                else if (scene == 32)
                {

                    double randValue = randGen.Next(1, 101);
                    if (randValue <= 50)
                    {
                        if (carGas == true)
                        { scene = 36; }
                        else { scene = 31; }
                    }
                    else scene = 37;

                }
                else if (scene == 36) { scene = 40; }
                else if (scene == 37) { scene = 40; }
                else if (scene == 40) { scene = 0; }
                //else if (scene == 40) { scene = 41; }
            }

            else if (e.KeyCode == Keys.B)  //blue button press
            {

            }
            switch (scene)
            {
                case 20:
                    outputLabel.Text = "You guys were hungry!  James also remembers to fill the car up with gas, it was almost empty. The rush hour traffic is almost past and you make it to the cottage in 2 hours. ";
                    break;
                case 21:
                    outputLabel.Text = "You see the sun going down and decide to have a fire. ";
                    outputLabel.Text += "You decide to have a camp fire later in the night, how do you want to help set up? chop some wood or set up the Muskoka chairs.";
                    leftPictureBox.BackgroundImage = Properties.Resources.axe;
                    middlePictureBox.BackgroundImage = Properties.Resources.chairs;
                    break;
                case 22:
                    outputLabel.Text = "You look for the ax, and it seems to be missing from the wood shed. so you  have to use the rotten wood from last year.";
                    break;

            }
        }


            private void Label1_Click(object sender, EventArgs e)
            {

            }
        }
    }


