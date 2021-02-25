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
using System.Media;
namespace Adventure

{
    //Bilal Zeineddine
    //February 25, 2021
    //Adventure Game 
    public partial class adventureForm : Form
    {
        int scene = 1;
        public adventureForm()
        {
            InitializeComponent();
        }

        private void adventureForm_KeyDown(object sender, KeyEventArgs e)
        {
            SoundPlayer sceneSound;
            if (e.KeyCode == Keys.M)  //red button press
            {

                //Set up what scene you are sent to if the M key(red button) is pressed
                if (scene == 1) { scene = 3; }
                else if (scene == 2) { scene = 1; }
                else if (scene == 3) { scene = 17; }
                else if (scene == 4) { scene = 6; }
                else if (scene == 5) { scene = 6; }
                else if (scene == 6)
                {
                    //70% of scene 8, 30% of scene 7
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 7) { scene = 8; }

                    else { scene = 7; }
                }
                else if (scene == 7) { scene = 1; }
                else if (scene == 8) { scene = 9; }
                else if (scene == 9)
                {
                    //50% of scene 11, 50% of scene 12
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 5) { scene = 11; }

                    else { scene = 12; }
                }
                else if (scene == 10) { scene = 22; }
                else if (scene == 11) { scene = 14; }
                else if (scene == 12) { scene = 1; }
                else if (scene == 13) { scene = 1; }
                else if (scene == 14) { scene = 16; }
                else if (scene == 16) { scene = 1; }
                else if (scene == 17)
                {
                    //90% of scene 20, 10% of scene 19
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 9) { scene = 20; }

                    else { scene = 19; }
                }

                else if (scene == 18) { scene = 1; }
                else if (scene == 19) { scene = 1; }
                else if (scene == 20) { scene = 1; }
                else if (scene == 21) { scene = 1; }
                else if (scene == 22) { scene = 1; }
                else if (scene == 23)
                {
                    //90% of scene 20, 10% of scene 19
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 9) { scene = 20; }

                    else { scene = 19; }
                }

            }
            //If the B key(blue button) is pressed, which scene does it take you to
            else if (e.KeyCode == Keys.B)
            {
                if (scene == 1) { scene = 2; }
                else if (scene == 2)
                {
                    { scene = 99; }
                }
                else if (scene == 3)
                {

                    scene = 4;
                    greenButton.Visible = true;
                }
                else if (scene == 4) { scene = 5; }
                else if (scene == 5) { scene = 9; }
                else if (scene == 6)
                {
                    //70% of scene 8, 30% of scene 7
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 7) { scene = 8; }

                    else { scene = 7; }
                }
                else if (scene == 7)
                {
                    { scene = 99; }
                }
                else if (scene == 8) { scene = 5; }
                else if (scene == 9) { scene = 10; }
                else if (scene == 10) { scene = 21; }
                else if (scene == 11) { scene = 13; }
                else if (scene == 12) //For each death scene, disable the scene pic and send you to case 99
                {
                    { scene = 99; }
                }
                else if (scene == 13)
                {
                    { scene = 99; }
                }
                else if (scene == 14) { scene = 15; }
                else if (scene == 15)
                {
                    { scene = 99; }
                }
                else if (scene == 16)
                {
                    { scene = 99; }
                }
                else if (scene == 17) { scene = 18; }
                else if (scene == 18)
                {
                    { scene = 99; }
                }
                else if (scene == 19)
                {
                    { scene = 99; }
                }
                else if (scene == 20)
                {
                    { scene = 99; }
                }
                else if (scene == 21)
                {
                    { scene = 99; }
                }
                else if (scene == 22)
                {
                    { scene = 99; }
                }
                else if (scene == 23)
                {
                    //90% of scene 20, 10% of scene 19
                    Random randGen = new Random();
                    int value = randGen.Next(1, 11);

                    if (value <= 9) { scene = 20; }

                    else { scene = 19; }
                }


            }
            else if (e.KeyCode == Keys.Space)
            //If the green button is visible, it is accesible with space key. What scene are you sent to if this key is pressed
            {
                if (scene == 4) { scene = 9; }
                if (scene == 5) { scene = 9; }
            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {

                case 1:
                    sceneSound = new SoundPlayer(Properties.Resources.rain);
                    sceneSound.Play();
                    outputLabel.Text = "You are out for a late night walk when you hear a strange sound from an alley. Investigate?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources._2689916322_01a2e102a1_b;
                    break;
                case 2:
                    sceneSound = new SoundPlayer(Properties.Resources.thunder);
                    sceneSound.Play();
                    outputLabel.Text = "You get stuck by lightning and die from severe burns. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.lightning;
                    break;
                case 3:
                    sceneSound = new SoundPlayer(Properties.Resources.suspense);
                    sceneSound.Play();
                    outputLabel.Text = "Three masked men spot you and dash. Chase after them?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.masked;
                    break;
                case 4:
                    sceneSound = new SoundPlayer(Properties.Resources.store);
                    sceneSound.Play();
                    outputLabel.Text = "You decide to stop in a shop for a quick drink. Which shop?";
                    redLabel.Text = "Jane and Finch Zone";
                    blueLabel.Text = "Wastemans Convenience";
                    greenLabel.Text = "CJs Corner Store";
                    scenePic.BackgroundImage = Properties.Resources.convenience;
                    greenDescription.Visible = true;
                    break;
                case 5:
                    sceneSound = new SoundPlayer(Properties.Resources.storeclosed);
                    sceneSound.Play();
                    outputLabel.Text = "The shop is closed. Maybe try somewhere else?";
                    redLabel.Text = "Jane and Finch";
                    blueLabel.Text = "CJs";
                    scenePic.BackgroundImage = Properties.Resources.closed;
                    blueButton.Visible = false;
                    blueLabel.Text = "";
                    greenDescription.Visible = true;
                    blueDescription.Visible = false;
                    break;
                case 6:
                    sceneSound = new SoundPlayer(Properties.Resources.driveby);
                    sceneSound.Play();
                    outputLabel.Text = "Quick! A drive by shooting! Duck!";
                    blueButton.Visible = false;
                    greenButton.Visible = false;
                    redLabel.Text = "Advance";
                    blueLabel.Text = "";
                    greenLabel.Text = "";
                    scenePic.BackgroundImage = Properties.Resources.drive;
                    greenDescription.Visible = false;
                    blueDescription.Visible = false;
                    break;
                case 7:
                    sceneSound = new SoundPlayer(Properties.Resources.flatline);
                    sceneSound.Play();
                    outputLabel.Text = "You get shot and die from blood loss. Try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.bones;
                    blueButton.Visible = true;
                    break;
                case 8:
                    sceneSound = new SoundPlayer(Properties.Resources.sigh);
                    sceneSound.Play();
                    outputLabel.Text = "Phew, that was close. Maybe try another store...";
                    redLabel.Text = "Cj's";
                    blueLabel.Text = "Wastemans";
                    blueButton.Visible = true;
                    scenePic.BackgroundImage = Properties.Resources.convenience;
                    blueDescription.Visible = true;
                    break;
                case 9:
                    sceneSound = new SoundPlayer(Properties.Resources.store);
                    sceneSound.Play();
                    outputLabel.Text = "You stop in the shop and tell the cashier about the men you saw. Ask him for help?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    greenLabel.Text = "";
                    greenButton.Visible = false;
                    scenePic.BackgroundImage = Properties.Resources.cashier;
                    greenDescription.Visible = false;
                    blueButton.Visible = true;
                    blueDescription.Visible = true;
                    break;
                case 10:
                    sceneSound = new SoundPlayer(Properties.Resources.tick);
                    sceneSound.Play();
                    outputLabel.Text = "You tackle the task on your own. Turn right or left?";
                    redLabel.Text = "Left";
                    blueLabel.Text = "Right";
                    scenePic.BackgroundImage = Properties.Resources.left_right;
                    break;
                case 11:
                    sceneSound = new SoundPlayer(Properties.Resources.tick);
                    sceneSound.Play();
                    outputLabel.Text = "CJ agrees to help you. What do you use to chase down the men?";
                    redLabel.Text = "Motorcycle";
                    blueLabel.Text = "Toyota Corolla";
                    scenePic.BackgroundImage = Properties.Resources.toyota;
                    break;
                case 12:
                    sceneSound = new SoundPlayer(Properties.Resources.stabbing);
                    sceneSound.Play();
                    outputLabel.Text = "CJ suspects you of robbing his store and stabs you in a vital organ. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.stab;
                    break;
                case 13:
                    sceneSound = new SoundPlayer(Properties.Resources.nofuel);
                    sceneSound.Play();
                    outputLabel.Text = "No fuel! Its far too late, the suspicious men have escaped! Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.fuel;
                    break;
                case 14:
                    sceneSound = new SoundPlayer(Properties.Resources.motorbike);
                    sceneSound.Play();
                    outputLabel.Text = "You and CJ hop on the motorcycle and take off where you last saw the men. They have returned!";
                    redLabel.Text = "Reason with them";
                    blueLabel.Text = "Resort to violence";
                    scenePic.BackgroundImage = Properties.Resources.alley;
                    break;
                case 15:
                    sceneSound = new SoundPlayer(Properties.Resources.boo);
                    sceneSound.Play();
                    outputLabel.Text = "You defeat the men! Upon further inspection you discover that they werent criminals, they were feeding the homeless. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.neutral_face;
                    break;
                case 16:
                    sceneSound = new SoundPlayer(Properties.Resources.robbed);
                    sceneSound.Play();
                    outputLabel.Text = "They rob you for all of your possessions; the phone, the wallet, the motorcycle! Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.rob;
                    break;
                case 17:
                    sceneSound = new SoundPlayer(Properties.Resources.siren);
                    sceneSound.Play();
                    outputLabel.Text = "The police get involved and suspect you of the crime! Run or Comply with the officers?";
                    redLabel.Text = "Run!";
                    blueLabel.Text = "Comply!";
                    scenePic.BackgroundImage = Properties.Resources.cops;
                    break;
                case 18:
                    sceneSound = new SoundPlayer(Properties.Resources.arrested);
                    sceneSound.Play();
                    outputLabel.Text = "You are arrested on suspicion of a murder in the area. Maybe try to escape prison? Play Again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.bars;
                    break;
                case 19:
                    sceneSound = new SoundPlayer(Properties.Resources.awaken);
                    sceneSound.Play();
                    outputLabel.Text = "You wake up in your bed with a fever... was it all a dream? (Secret Ending!) Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.wakeup;
                    break;
                case 20:
                    sceneSound = new SoundPlayer(Properties.Resources.arrested);
                    sceneSound.Play();
                    outputLabel.Text = "Maybe it was the dodgy sushi, but the police stop you easily and your sentence is doubled due to your disobedience. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.sushi;
                    break;
                case 21:
                    sceneSound = new SoundPlayer(Properties.Resources.drake);
                    sceneSound.Play();
                    outputLabel.Text = "You turn right and come face to face with...Drake? He serinates you with his voice and you get married. Play again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.drake_married;
                    break;
                case 22:
                    sceneSound = new SoundPlayer(Properties.Resources.victory);
                    sceneSound.Play();
                    outputLabel.Text = "You turn left and get the jump on the men! They robbed an old lady but confess and return the items. You're a hero! Try again?";
                    redLabel.Text = "Yes";
                    blueLabel.Text = "No";
                    scenePic.BackgroundImage = Properties.Resources.grandma;
                    break;
                //Case 99 is the death scene, display a thank you message and close the program after 2 seconds. Flash the side labels and message.
                case 99:
                    sceneSound = new SoundPlayer(Properties.Resources.over);
                    sceneSound.Play();
                    outputLabel.Text = "Thanks for playing!";
                    redLabel.Text = "";
                    blueLabel.Text = "";
                    blueButton.Visible = false;
                    redButton.Visible = false;
                    blueDescription.Visible = false;
                    buttonDescription.Visible = false;
                    scenePic.BackgroundImage = Properties.Resources.end;
                    Refresh();
                    Thread.Sleep(500);
                    scenePic.Visible = false;
                    roadmansLabel.Visible = true;
                    adventureLabel.Visible = true;
                    Refresh();
                    Thread.Sleep(500);
                    scenePic.Visible = true;
                    roadmansLabel.Visible = false;
                    adventureLabel.Visible = false;
                    Refresh();
                    Thread.Sleep(500);
                    scenePic.Visible = false;
                    roadmansLabel.Visible = true;
                    adventureLabel.Visible = true;
                    Refresh();
                    Thread.Sleep(500);
                    scenePic.Visible = true;
                    roadmansLabel.Visible = false;
                    adventureLabel.Visible = false;
                    Refresh();
                    Thread.Sleep(500);
                    scenePic.Visible = false;
                    roadmansLabel.Visible = true;
                    adventureLabel.Visible = true;
                    Refresh();
                    Thread.Sleep(500);
                    scenePic.Visible = true;
                    roadmansLabel.Visible = false;
                    adventureLabel.Visible = false;
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }


    }
}
