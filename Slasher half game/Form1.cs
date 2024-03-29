﻿using System;
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

               if (scene == 20) { scene = 22; }
                //cut wood or set up chairs
                else if (scene == 21) { scene = 22; }
               else if (scene == 22) { scene = 30; }
                else if (scene == 23) { scene = 30; }
                //60/40 chance of escaping and living
                
                else if (scene == 26) { scene = 27; }
                
                else if (scene == 27) { scene = 21; }
            
         
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
                    else if (scene == 33)
                    {

                     
                        if (randValue > 50) { scene = 35; }
                        else { scene = 34; }
                    }
                    else scene = 37;

                }
       
               // else if (scene == 40) { scene = 0; }
               
            }

            else if (e.KeyCode == Keys.B)  //blue button press
            {
                if (scene == 18) { scene = 25; }
                else if (scene == 20) { scene = 23; }
                else if (scene == 22) { scene = 33; }
                else if (scene == 23) { scene = 33; }
             
                else if (scene == 26) {
                    
                  scene = 28; }
                else if (scene == 28) { scene = 29; }
                else if (scene == 29) { scene = 37; }
                else if (scene == 32) {
                    double randValue = randGen.Next(1, 101);
                    if (randValue > 10) { scene = 38; }
                    else { scene = 39;  }
                    }
            
              
               

                //else if (scene == 40) { scene = 41; }
            }

            switch (scene)
            {
                case 20:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You guys were hungry!  James also remembers to fill the car up with gas, it was almost empty. The rush hour traffic is almost past and you make it to the cottage in 2 hours. ";
                    carGas = true;

                    Refresh();
                    Thread.Sleep(4000);

                    gameLabel.Text = "You see the sun going down and decide to have a fire. ";
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    questionLabel.Visible = true;
                    questionLabel.Text = "You decide to have a camp fire later in the night, how do you want to help set up? chop some wood or set up the Muskoka chairs.";
                 
                    leftPictureBox.BackgroundImage = Properties.Resources.axe;
                    middlePictureBox.BackgroundImage = Properties.Resources.chairs;
                    break;
           
                case 22:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You look for the ax, and it seems to be missing from the wood shed. so you have to use the rotten wood from last year.";

                    Refresh();
                    Thread.Sleep(4000);

                    gameLabel.Text = "You guys start the camp fire all is good for a while... then there are some noises.  Could that be who stole the ax?";
                    questionLabel.Visible = true;
                    questionLabel.Text = "Do you want to split up and help James look for his great grandfathers Vietnamese hatchet? Yes / No ";
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    //leftPictureBox.BackgroundImage = Properties.Resources.yesas;
                    //middlePictureBox.BackgroundImage = Properties.Resources.non;
                    break;
                case 23:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                   gameLabel.Text = "All of the chairs seem to be broken.  It  looks like  someone has been sleeping on them...  So you settle for the crappier sun faded lawn chairs.";
                    Refresh();
                    Thread.Sleep(4000);
                    gameLabel.Text = "You guys start the camp fire all is good for a while... then there are some noises.  Could that be who stole the ax?";
                    questionLabel.Visible = true;
                    questionLabel.Text = "Do you want to split up and help James look for his great grandfathers Vietnamese hatchet? Yes / No ";
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    //leftPictureBox.BackgroundImage = Properties.Resources.yesas;
                    //middlePictureBox.BackgroundImage = Properties.Resources.non;
                    break;
                case 25:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "The bank accounts can handle a little less spending anyways, you will also get there sooner! ....You slowly get through the rush hour traffic, making it to the cottage in about 3 hours.";

                    Refresh();
                    Thread.Sleep(4000);

                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    gameLabel.Text = "As you pull up to the cottage a warning light in the car flashes telling you you are about to run out of fuel. James says there is a can of gas in the shed..";
                    questionLabel.Visible = true;
                    questionLabel.Text = "Fill up the gas for when you leave or do it later?";
                    leftPictureBox.BackgroundImage = Properties.Resources.Gas_can;
                    middlePictureBox.BackgroundImage = Properties.Resources.cottage;
                    break;
                case 27:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You go to the shed and grab the can of gas with James and come and fill the car up with gas. You go down and unlock the cottage and begin to grab dinner, since lunch has passed and it is getting late..James points out a muddy footprint on the deck, and says someone must've been checking out the cottage.";
                    carGas = true;
                    questionLabel.Visible = true;
                    questionLabel.Text = "The sun is starting to set, do you want to have a campfire or go for a walk?";
                    break;
                case 28:
                    leftPictureBox.Visible = true;
                    middlePictureBox.Visible = true;
                    gameLabel.Text = "You go down and unlock the cottage and begin to grab dinner, since lunch has passed and it is getting late..";

                    Refresh();
                    Thread.Sleep(4000);
                    carGas = true;
                    gameLabel.Text = "James points out a muddy footprint on the deck, and says someone must've been checking out the cottage.";
                    questionLabel.Text = "The sun is starting to set, do you want to have a campfire or go for a walk?";
                    break;
                case 29:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You and James decide to go for a walk. The sun is setting so you will have to be quick.... As you and James walk through the forest you hear loud chopping noises further down the path, you guys think it's the rumored killer. ";
                    break;
                case 30:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You Left and James goes right, there is a loud russel a crack and your head hurts.";
                    Thread.Sleep(300);
                    Refresh();
                    double randValue = randGen.Next(1, 101);
                    if (randValue <= 60)
                    {

                        leftPictureBox.Visible = true;
                        middlePictureBox.Visible = true;
                        gameLabel.Text = "After passing out, you come to in James' wood shed, you're tied up you use your pocket knife to get out.  James is tied up as well, the guy with the ax is gone.";
                        questionLabel.Text = "Do you save James. Yes/No";
                        questionLabel.Visible = true;
                        //leftPictureBox.BackgroundImage = Properties.Resources.yesas;
                        //middlePictureBox.BackgroundImage = Properties.Resources.non;
                        Thread.Sleep(3000);
                        Refresh();
                    } else if (randValue > 60) {
                        gameLabel.Text = "Ouch that had to hurt. You are never heard from again and your body is never found";
                        Thread.Sleep(3000);
                        Refresh();
                        scene = 40;
                        
                    }
                    break;
                case 31:
                    questionLabel.Visible = false;
                    gameLabel.Text = "The car will not start, the killer gets you and James'... you got the stupid ending.";
                    break;
                case 33:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You stay back at the fire, all seems good.";

                    Refresh();
                    Thread.Sleep(3000);
                   
                    double randValue2 = randGen.Next(1, 101);
                    if (randValue2 < 50)
                    {
                        leftPictureBox.Visible = false;
                        middlePictureBox.Visible = false;
                        questionLabel.Visible = false;
                        gameLabel.Text = "He comes back about twenty minutes later with the hatchet, turns out it was raccoon family that was living in the shed, and the father made off with it when you guys arrived... You got the happy ending";

                        
                        Thread.Sleep(3000);
                        Refresh();

                        scene = 40;
                    }
                    else if (randValue2 > 50)
                    {
                        leftPictureBox.Visible = false;
                        middlePictureBox.Visible = false;
                        questionLabel.Visible = false;
                        gameLabel.Text = "You call the police, they come and find him killed with the ax, you're blamed for his murder.  Why didn't you go search with him?... You got the blame game ending";

                        Refresh();
                        Thread.Sleep(4000);

                        scene = 40;
                    }
                    //50/50 hes alive
                    break;
                case 36:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You guys run to James' car get in and drive off.... you got the good ending";


                    Refresh();
                    Thread.Sleep(4000);

                    scene = 40;
                    break;
                case 37:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "The 'Killer' comes back towards you guys, it's James' uncle George?  He though you guys were breaking into the cottage. All of you go back to the camp fire and have a good vacation...You got the cool ending!";

                    Refresh();
                    Thread.Sleep(4000);

                    scene = 40;
                    break;
                case 38:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "Turns out the killer was your ex boy friend and was just out for you, James is alive and well, you were never seen again.... You got the karma ending!";

                    Refresh();
                    Thread.Sleep(4000);

                    scene = 40;
                    break;
                case 39:
                    leftPictureBox.Visible = false;
                    middlePictureBox.Visible = false;
                    questionLabel.Visible = false;
                    gameLabel.Text = "You're alive, for some reason, and have life threatening injuries.  Way to pay a friend back for a holiday.  ...You got the jerk ending.";

                    Refresh();
                    Thread.Sleep(4000);

                    scene = 40;
                    break;
                case 40:
                    //test ending scene, button has to be pushed for some reason
                    Refresh();
                    Thread.Sleep(500);
                    this.Close();
                    break;

            }
        }


            private void Label1_Click(object sender, EventArgs e)
            {

            }
        }
    }


