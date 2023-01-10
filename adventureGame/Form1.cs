using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//Sofia Sanchez Rivera
//October 2022
//Create a night dance game

namespace adventureGame
{
    public partial class DanceNight : Form
    {
        // Tracks what page of the story the user is at
        int page = 1;

        public DanceNight()
        {
            InitializeComponent();

            // Display initial message and options
            outputLabel.Text = "You have a high school dance.";
            option1Label.Text = "Go to the dance";
            option2Label.Text = "Stay at home";
            pictureBox1.Image = Properties.Resources.dance;


            //Make invisible option3Button
            option3Button.Visible = false;
            option3Label.Visible = false;
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            // Make visible and invisible option3Button
            option3Button.Visible = true;
            option3Label.Visible = true;

            string gotothedance;
            gotothedance = "Go to the dance";
            if (option1Label.Text != gotothedance)
            {
                option3Button.Visible = false;
                option3Label.Visible = false;
            }

            /// Check what page we are currently on, and then flip
            /// to the page you need to go to if you selected option 1
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 1;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 11;
            }
            else if (page == 8)
            {
                page = 13;
            }
            else if (page == 9)
            {
                page = 15;
            }
            else if (page == 10)
            {
                page = 17;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 1;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 1;
            }
            if (page == 15)
            {
                page = 19;
            }
            else if (page == 16)
            {
                page = 21;
            }
            else if (page == 17)
            {
                page = 23;
            }
            else if (page == 18)
            {
                page = 25;
            }
            else if (page == 19)
            {
                Random randGen = new Random();
                int chance = randGen.Next(1, 101);

                if (chance < 30)
                {
                    page = 27;
                }
                else
                {
                    page = 28;
                }
            }
            else if (page == 20)
            {
                page = 30;
            }
            else if (page == 21)
            {
                page = 32;
            }
            else if (page == 22)
            {
                page = 34;
            }
            else if (page == 23)
            {
                page = 1;
            }
            else if (page == 24)
            {
                page = 1;
            }
            else if (page == 25)
            {
                page = 1;
            }
            else if (page == 26)
            {
                page = 1;
            }
            else if (page == 27)
            {
                page = 1;
            }
            else if (page == 28)
            {
                page = 1;
            }
            else if (page == 29)
            {
                page = 1;
            }
            else if (page == 30)
            {
                page = 1;
            }
            else if (page == 31)
            {
                page = 1;
            }
            else if (page == 32)
            {
                page = 1;
            }
            else if (page == 33)
            {
                page = 1;
            }
            else if (page == 34)
            {
                page = 1;
            }
            else if (page == 35)
            {
                page = 1;
            }

            /// Display text and game options to screen based on the 
            /// current page
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You have a high school dance.";
                    option1Label.Text = "Go to the dance";
                    option2Label.Text = "Stay at home";

                    pictureBox1.Image = Properties.Resources.dance;
                    SoundPlayer Vals = new SoundPlayer(Properties.Resources.Vals);
                    Vals.Play();
                    break;
                case 2:
                    outputLabel.Text = "Three guys ask you to be their dance partner";
                    option1Label.Text = "Josh";
                    option2Label.Text = "Cole";
                    option3Label.Text = "Ryan";

                    pictureBox1.Image = Properties.Resources.boys;
                    SoundPlayer one = new SoundPlayer(Properties.Resources.one);
                    one.Play();
                    break;
                case 3:
                    outputLabel.Text = "You lay on your bed and fall asleep. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.sleep;
                    SoundPlayer two = new SoundPlayer(Properties.Resources.two);
                    two.Play();
                    break;
                case 4:
                    outputLabel.Text = "He asks you what colour your dress will be so he can match his tie. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer three = new SoundPlayer(Properties.Resources.three);
                    three.Play();
                    pictureBox1.Image = Properties.Resources.pinkblue;
                    break;
                case 5:
                    outputLabel.Text = "Tells you it was all a bet to make fun of you with his friends. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer four = new SoundPlayer(Properties.Resources.four);
                    four.Play();
                    pictureBox1.Image = Properties.Resources.laugh;
                    break;
                case 6:
                    outputLabel.Text = "He gives you a hug and ask you if you want to hang out with him tonight. Do you accept?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer five = new SoundPlayer(Properties.Resources.five);
                    five.Play();
                    pictureBox1.Image = Properties.Resources.hug;
                    break;
                case 7:
                    outputLabel.Text = "You go to the dance with a pink dress and Josh wears a pink tie. What do you want to do in the dance?";
                    option1Label.Text = "Go talking outside";
                    option2Label.Text = "Dance";

                    SoundPlayer six = new SoundPlayer(Properties.Resources.six);
                    six.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 8:
                    outputLabel.Text = "Yo go to the dance with a blue dress and Josh wears a Blue tie. What do you want to do in the dance?";
                    option1Label.Text = "Drink something";
                    option2Label.Text = "Dance";

                    SoundPlayer seven = new SoundPlayer(Properties.Resources.seven);
                    seven.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 9:
                    outputLabel.Text = "He asks you which plan you want to do";
                    option1Label.Text = "Watch a movie";
                    option2Label.Text = "Go for an icecream";

                    SoundPlayer eight = new SoundPlayer(Properties.Resources.eight);
                    eight.Play();
                    pictureBox1.Image = Properties.Resources.netflixicream;
                    break;
                case 10:
                    outputLabel.Text = "You apologise for not going but you need to decide your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer nine = new SoundPlayer(Properties.Resources.nine);
                    nine.Play();
                    pictureBox1.Image = Properties.Resources.pinkblue;
                    break;
                case 11:
                    outputLabel.Text = "You spend all night talking with Josh under the stars. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer ten = new SoundPlayer(Properties.Resources.ten);
                    ten.Play();
                    pictureBox1.Image = Properties.Resources.stars;
                    break;
                case 12:
                    outputLabel.Text = "You spend all the night dancing with Josh and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer eleven = new SoundPlayer(Properties.Resources.eleven);
                    eleven.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 13:
                    outputLabel.Text = "You drink Sprite and just chill all night. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";


                    SoundPlayer twelve = new SoundPlayer(Properties.Resources.twelve);
                    twelve.Play();
                    pictureBox1.Image = Properties.Resources.sprite;
                    break;
                case 14:
                    outputLabel.Text = "You dance all night and have fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _14 = new SoundPlayer(Properties.Resources._14);
                    _14.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 15:
                    outputLabel.Text = "You watch a terror movie and next day you go to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    pictureBox1.Image = Properties.Resources.movie;
                    SoundPlayer _15 = new SoundPlayer(Properties.Resources._15);
                    _15.Play();
                    break;
                case 16:
                    outputLabel.Text = "You walk around and he asks you which is your favourite icecream flavour. Vanilla or chocolate?";
                    option1Label.Text = "Vanilla";
                    option2Label.Text = "Chocolate";

                    SoundPlayer _16 = new SoundPlayer(Properties.Resources._16);
                    _16.Play();
                    pictureBox1.Image = Properties.Resources.icecream;
                    break;
                case 17:
                    outputLabel.Text = "You go to the dance with a pink dress and Ryan wears a blue tie. What do you want to do there?";
                    option1Label.Text = "Eat";
                    option2Label.Text = "Dance";

                    SoundPlayer _34 = new SoundPlayer(Properties.Resources._34);
                    _34.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 18:
                    outputLabel.Text = "You go to the dance with a blue dress and Ryan dress a blue tie. What do you want to do there?";
                    option1Label.Text = "Meet Ryan's friends";
                    option2Label.Text = "Meet your friends";

                    SoundPlayer _18 = new SoundPlayer(Properties.Resources._18);
                    _18.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 19:
                    outputLabel.Text = "You go to the dance with a pink dress and Ryan wears a pink tie. What do you want to do in the dance?";
                    option1Label.Text = "Play cornhole";
                    option2Label.Text = "Dance";

                    SoundPlayer _19 = new SoundPlayer(Properties.Resources._19);
                    _19.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 20:
                    outputLabel.Text = "You go to the dance with a blue dress and Ryan wears a blue tie. What do you want to do in the dance?";
                    option1Label.Text = "Sing with Ryan";
                    option2Label.Text = "Dance";

                    SoundPlayer _20 = new SoundPlayer(Properties.Resources._20);
                    _20.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 21:
                    outputLabel.Text = "He buys you a vanilla icecream and then you leave to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer _21 = new SoundPlayer(Properties.Resources._21);
                    _21.Play();
                    pictureBox1.Image = Properties.Resources.vanilla;
                    break;
                case 22:
                    outputLabel.Text = "He buys you a chocolate icecream and then you leave to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer _22 = new SoundPlayer(Properties.Resources._22);
                    _22.Play();
                    pictureBox1.Image = Properties.Resources.chocolate;
                    break;
                case 23:
                    outputLabel.Text = "You try new foods and have such a great time!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _23 = new SoundPlayer(Properties.Resources._23);
                    _23.Play();
                    pictureBox1.Image = Properties.Resources.food;
                    break;
                case 24:
                    outputLabel.Text = "You dance all night with Ryan until the end of the night. So fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _24 = new SoundPlayer(Properties.Resources._24);
                    _24.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 25:
                    outputLabel.Text = "He presents you to his best friend Jack and his girlfriend Malori and you four have a great couple date dancing all night!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _25 = new SoundPlayer(Properties.Resources._25);
                    _25.Play();
                    pictureBox1.Image = Properties.Resources.date;
                    break;
                case 26:
                    outputLabel.Text = "You present him to your two best friends Addie and Claire and you spend the night dancing and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _26 = new SoundPlayer(Properties.Resources._26);
                    _26.Play();
                    pictureBox1.Image = Properties.Resources.girls;
                    break;
                case 27:
                    outputLabel.Text = "You lose but you still have fun dancing all night. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer error = new SoundPlayer(Properties.Resources.error);
                    error.Play();
                    pictureBox1.Image = Properties.Resources.lose;
                    break;
                case 28:
                    outputLabel.Text = "Everyone is so surprised you won and spend the rest of the night dancing. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _27 = new SoundPlayer(Properties.Resources._27);
                    _27.Play();
                    pictureBox1.Image = Properties.Resources.win;
                    break;
                case 29:
                    outputLabel.Text = "You spend all night dancing with Ryan and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _28 = new SoundPlayer(Properties.Resources._28);
                    _28.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 30:
                    outputLabel.Text = "You sing all your favourite songs with Ryan all night!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _29 = new SoundPlayer(Properties.Resources._29);
                    _29.Play();
                    pictureBox1.Image = Properties.Resources.sing;
                    break;
                case 31:
                    outputLabel.Text = "You spend all night dancing with Ryan and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _30 = new SoundPlayer(Properties.Resources._30);
                    _30.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 32:
                    outputLabel.Text = "You go to the dance with a pink dress and he  wears a pink tie. You drove to the dance in a pink limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _31 = new SoundPlayer(Properties.Resources._31);
                    _31.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 33:
                    outputLabel.Text = "You go to the dance with a blue dress and he wears a blue tie. You drove to the dance in a blue limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _32 = new SoundPlayer(Properties.Resources._32);
                    _32.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 34:
                    outputLabel.Text = "You go to the dance with a pink dress and he  wears a pink tie. You drove to the dance in a pink limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _33 = new SoundPlayer(Properties.Resources._33);
                    _33.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 35:
                    outputLabel.Text = "You go to the dance with a blue dress and he wears a blue tie. You drove to the dance in a blue limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _35 = new SoundPlayer(Properties.Resources._35);
                    _35.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    SoundPlayer Vals2 = new SoundPlayer(Properties.Resources.Vals2);
                    Vals2.Play();
                    pictureBox1.Image = Properties.Resources.thanks;

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void option2button_Click(object sender, EventArgs e)
        {
            // Make invisible option3Button
            string gotothedance;
            gotothedance = "Go to the dance";
            if (option1Label.Text != gotothedance)
            {
                option3Button.Visible = false;
                option3Label.Visible = false;
            }

            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 2
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 99;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 10;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 14;
            }
            else if (page == 9)
            {
                page = 16;
            }
            else if (page == 10)
            {
                page = 18;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 99;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 99;
            }
            else if (page == 15)
            {
                page = 20;
            }
            else if (page == 16)
            {
                page = 22;
            }
            else if (page == 17)
            {
                page = 24;
            }
            else if (page == 18)
            {
                page = 26;
            }
            else if (page == 19)
            {
                page = 29;
            }
            else if (page == 20)
            {
                page = 31;
            }
            else if (page == 21)
            {
                page = 33;
            }
            else if (page == 22)
            {
                page = 35;
            }
            else if (page == 23)
            {
                page = 99;
            }
            else if (page == 24)
            {
                page = 99;
            }
            else if (page == 25)
            {
                page = 99;
            }
            else if (page == 26)
            {
                page = 99;
            }
            else if (page == 27)
            {
                page = 99;
            }
            else if (page == 28)
            {
                page = 99;
            }
            else if (page == 29)
            {
                page = 99;
            }
            else if (page == 30)
            {
                page = 99;
            }
            else if (page == 31)
            {
                page = 99;
            }
            else if (page == 32)
            {
                page = 99;
            }
            else if (page == 33)
            {
                page = 99;
            }
            else if (page == 34)
            {
                page = 99;
            }
            else if (page == 35)
            {
                page = 99;
            }

            /// Display text and game options to screen based on the 
            /// current page
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You have a high school dance.";
                    option1Label.Text = "Go to the dance";
                    option2Label.Text = "Stay at home";

                    pictureBox1.Image = Properties.Resources.dance;
                    SoundPlayer Vals = new SoundPlayer(Properties.Resources.Vals);
                    Vals.Play();
                    break;
                case 2:
                    outputLabel.Text = "Three guys ask you to be their dance partner";
                    option1Label.Text = "Josh";
                    option2Label.Text = "Cole";
                    option3Label.Text = "Ryan";

                    pictureBox1.Image = Properties.Resources.boys;
                    SoundPlayer one = new SoundPlayer(Properties.Resources.one);
                    one.Play();
                    break;
                case 3:
                    outputLabel.Text = "You lay on your bed and fall asleep. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.sleep;
                    SoundPlayer two = new SoundPlayer(Properties.Resources.two);
                    two.Play();
                    break;
                case 4:
                    outputLabel.Text = "He asks you what colour your dress will be so he can match his tie. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer three = new SoundPlayer(Properties.Resources.three);
                    three.Play();
                    pictureBox1.Image = Properties.Resources.pinkblue;
                    break;
                case 5:
                    outputLabel.Text = "Tells you it was all a bet to make fun of you with his friends. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer four = new SoundPlayer(Properties.Resources.four);
                    four.Play();
                    pictureBox1.Image = Properties.Resources.laugh;
                    break;
                case 6:
                    outputLabel.Text = "He gives you a hug and ask you if you want to hang out with him tonight. Do you accept?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer five = new SoundPlayer(Properties.Resources.five);
                    five.Play();
                    pictureBox1.Image = Properties.Resources.hug;
                    break;
                case 7:
                    outputLabel.Text = "You go to the dance with a pink dress and Josh wears a pink tie. What do you want to do in the dance?";
                    option1Label.Text = "Go talking outside";
                    option2Label.Text = "Dance";

                    SoundPlayer six = new SoundPlayer(Properties.Resources.six);
                    six.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 8:
                    outputLabel.Text = "Yo go to the dance with a blue dress and Josh wears a Blue tie. What do you want to do in the dance?";
                    option1Label.Text = "Drink something";
                    option2Label.Text = "Dance";

                    SoundPlayer seven = new SoundPlayer(Properties.Resources.seven);
                    seven.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 9:
                    outputLabel.Text = "He asks you which plan you want to do";
                    option1Label.Text = "Watch a movie";
                    option2Label.Text = "Go for an icecream";

                    SoundPlayer eight = new SoundPlayer(Properties.Resources.eight);
                    eight.Play();
                    pictureBox1.Image = Properties.Resources.netflixicream;
                    break;
                case 10:
                    outputLabel.Text = "You apologise for not going but you need to decide your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer nine = new SoundPlayer(Properties.Resources.nine);
                    nine.Play();
                    pictureBox1.Image = Properties.Resources.pinkblue;
                    break;
                case 11:
                    outputLabel.Text = "You spend all night talking with Josh under the stars. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer ten = new SoundPlayer(Properties.Resources.ten);
                    ten.Play();
                    pictureBox1.Image = Properties.Resources.stars;
                    break;
                case 12:
                    outputLabel.Text = "You spend all the night dancing with Josh and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer eleven = new SoundPlayer(Properties.Resources.eleven);
                    eleven.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 13:
                    outputLabel.Text = "You drink Sprite and just chill all night. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";


                    SoundPlayer twelve = new SoundPlayer(Properties.Resources.twelve);
                    twelve.Play();
                    pictureBox1.Image = Properties.Resources.sprite;
                    break;
                case 14:
                    outputLabel.Text = "You dance all night and have fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _14 = new SoundPlayer(Properties.Resources._14);
                    _14.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 15:
                    outputLabel.Text = "You watch a terror movie and next day you go to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    pictureBox1.Image = Properties.Resources.movie;
                    SoundPlayer _15 = new SoundPlayer(Properties.Resources._15);
                    _15.Play();
                    break;
                case 16:
                    outputLabel.Text = "You walk around and he asks you which is your favourite icecream flavour. Vanilla or chocolate?";
                    option1Label.Text = "Vanilla";
                    option2Label.Text = "Chocolate";

                    SoundPlayer _16 = new SoundPlayer(Properties.Resources._16);
                    _16.Play();
                    pictureBox1.Image = Properties.Resources.icecream;
                    break;
                case 17:
                    outputLabel.Text = "You go to the dance with a pink dress and Ryan wears a blue tie. What do you want to do there?";
                    option1Label.Text = "Eat";
                    option2Label.Text = "Dance";

                    SoundPlayer _34 = new SoundPlayer(Properties.Resources._34);
                    _34.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 18:
                    outputLabel.Text = "You go to the dance with a blue dress and Ryan dress a blue tie. What do you want to do there?";
                    option1Label.Text = "Meet Ryan's friends";
                    option2Label.Text = "Meet your friends";

                    SoundPlayer _18 = new SoundPlayer(Properties.Resources._18);
                    _18.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 19:
                    outputLabel.Text = "You go to the dance with a pink dress and Ryan wears a pink tie. What do you want to do in the dance?";
                    option1Label.Text = "Play cornhole";
                    option2Label.Text = "Dance";

                    SoundPlayer _19 = new SoundPlayer(Properties.Resources._19);
                    _19.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 20:
                    outputLabel.Text = "You go to the dance with a blue dress and Ryan wears a blue tie. What do you want to do in the dance?";
                    option1Label.Text = "Sing with Ryan";
                    option2Label.Text = "Dance";

                    SoundPlayer _20 = new SoundPlayer(Properties.Resources._20);
                    _20.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 21:
                    outputLabel.Text = "He buys you a vanilla icecream and then you leave to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer _21 = new SoundPlayer(Properties.Resources._21);
                    _21.Play();
                    pictureBox1.Image = Properties.Resources.vanilla;
                    break;
                case 22:
                    outputLabel.Text = "He buys you a chocolate icecream and then you leave to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer _22 = new SoundPlayer(Properties.Resources._22);
                    _22.Play();
                    pictureBox1.Image = Properties.Resources.chocolate;
                    break;
                case 23:
                    outputLabel.Text = "You try new foods and have such a great time!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _23 = new SoundPlayer(Properties.Resources._23);
                    _23.Play();
                    pictureBox1.Image = Properties.Resources.food;
                    break;
                case 24:
                    outputLabel.Text = "You dance all night with Ryan until the end of the night. So fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _24 = new SoundPlayer(Properties.Resources._24);
                    _24.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 25:
                    outputLabel.Text = "He presents you to his best friend Jack and his girlfriend Malori and you four have a great couple date dancing all night!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _25 = new SoundPlayer(Properties.Resources._25);
                    _25.Play();
                    pictureBox1.Image = Properties.Resources.date;
                    break;
                case 26:
                    outputLabel.Text = "You present him to your two best friends Addie and Claire and you spend the night dancing and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _26 = new SoundPlayer(Properties.Resources._26);
                    _26.Play();
                    pictureBox1.Image = Properties.Resources.girls;
                    break;
                case 27:
                    outputLabel.Text = "You lose but you still have fun dancing all night. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer error = new SoundPlayer(Properties.Resources.error);
                    error.Play();
                    pictureBox1.Image = Properties.Resources.lose;
                    break;
                case 28:
                    outputLabel.Text = "Everyone is so surprised you won and spend the rest of the night dancing. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _27 = new SoundPlayer(Properties.Resources._27);
                    _27.Play();
                    pictureBox1.Image = Properties.Resources.win;
                    break;
                case 29:
                    outputLabel.Text = "You spend all night dancing with Ryan and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _28 = new SoundPlayer(Properties.Resources._28);
                    _28.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 30:
                    outputLabel.Text = "You sing all your favourite songs with Ryan all night!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _29 = new SoundPlayer(Properties.Resources._29);
                    _29.Play();
                    pictureBox1.Image = Properties.Resources.sing;
                    break;
                case 31:
                    outputLabel.Text = "You spend all night dancing with Ryan and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _30 = new SoundPlayer(Properties.Resources._30);
                    _30.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 32:
                    outputLabel.Text = "You go to the dance with a pink dress and he  wears a pink tie. You drove to the dance in a pink limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _31 = new SoundPlayer(Properties.Resources._31);
                    _31.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 33:
                    outputLabel.Text = "You go to the dance with a blue dress and he wears a blue tie. You drove to the dance in a blue limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _32 = new SoundPlayer(Properties.Resources._32);
                    _32.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 34:
                    outputLabel.Text = "You go to the dance with a pink dress and he  wears a pink tie. You drove to the dance in a pink limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _33 = new SoundPlayer(Properties.Resources._33);
                    _33.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 35:
                    outputLabel.Text = "You go to the dance with a blue dress and he wears a blue tie. You drove to the dance in a blue limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _35 = new SoundPlayer(Properties.Resources._35);
                    _35.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    SoundPlayer Vals2 = new SoundPlayer(Properties.Resources.Vals2);
                    Vals2.Play();
                    pictureBox1.Image = Properties.Resources.thanks;

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }

        private void option3button_Click(object sender, EventArgs e)
        {
            // Make invisible option3Button
            string gotothedance;
            gotothedance = "Go to the dance";
            if (option1Label.Text != gotothedance)
            {
                option3Button.Visible = false;
                option3Label.Visible = false;
            }

            ///check what page we are currently on, and then flip
            ///to the page you need to go to if you selected option 3
            if (page == 2)
            {
                page = 6;
            }

            /// Display text and game options to screen based on the 
            /// current page
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You have a high school dance.";
                    option1Label.Text = "Go to the dance";
                    option2Label.Text = "Stay at home";

                    pictureBox1.Image = Properties.Resources.dance;
                    SoundPlayer Vals = new SoundPlayer(Properties.Resources.Vals);
                    Vals.Play();
                    break;
                case 2:
                    outputLabel.Text = "Three guys ask you to be their dance partner";
                    option1Label.Text = "Josh";
                    option2Label.Text = "Cole";
                    option3Label.Text = "Ryan";

                    pictureBox1.Image = Properties.Resources.boys;
                    SoundPlayer one = new SoundPlayer(Properties.Resources.one);
                    one.Play();
                    break;
                case 3:
                    outputLabel.Text = "You lay on your bed and fall asleep. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    pictureBox1.Image = Properties.Resources.sleep;
                    SoundPlayer two = new SoundPlayer(Properties.Resources.two);
                    two.Play();
                    break;
                case 4:
                    outputLabel.Text = "He asks you what colour your dress will be so he can match his tie. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer three = new SoundPlayer(Properties.Resources.three);
                    three.Play();
                    pictureBox1.Image = Properties.Resources.pinkblue;
                    break;
                case 5:
                    outputLabel.Text = "Tells you it was all a bet to make fun of you with his friends. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer four = new SoundPlayer(Properties.Resources.four);
                    four.Play();
                    pictureBox1.Image = Properties.Resources.laugh;
                    break;
                case 6:
                    outputLabel.Text = "He gives you a hug and ask you if you want to hang out with him tonight. Do you accept?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer five = new SoundPlayer(Properties.Resources.five);
                    five.Play();
                    pictureBox1.Image = Properties.Resources.hug;
                    break;
                case 7:
                    outputLabel.Text = "You go to the dance with a pink dress and Josh wears a pink tie. What do you want to do in the dance?";
                    option1Label.Text = "Go talking outside";
                    option2Label.Text = "Dance";

                    SoundPlayer six = new SoundPlayer(Properties.Resources.six);
                    six.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 8:
                    outputLabel.Text = "Yo go to the dance with a blue dress and Josh wears a Blue tie. What do you want to do in the dance?";
                    option1Label.Text = "Drink something";
                    option2Label.Text = "Dance";

                    SoundPlayer seven = new SoundPlayer(Properties.Resources.seven);
                    seven.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 9:
                    outputLabel.Text = "He asks you which plan you want to do";
                    option1Label.Text = "Watch a movie";
                    option2Label.Text = "Go for an icecream";

                    SoundPlayer eight = new SoundPlayer(Properties.Resources.eight);
                    eight.Play();
                    pictureBox1.Image = Properties.Resources.netflixicream;
                    break;
                case 10:
                    outputLabel.Text = "You apologise for not going but you need to decide your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer nine = new SoundPlayer(Properties.Resources.nine);
                    nine.Play();
                    pictureBox1.Image = Properties.Resources.pinkblue;
                    break;
                case 11:
                    outputLabel.Text = "You spend all night talking with Josh under the stars. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer ten = new SoundPlayer(Properties.Resources.ten);
                    ten.Play();
                    pictureBox1.Image = Properties.Resources.stars;
                    break;
                case 12:
                    outputLabel.Text = "You spend all the night dancing with Josh and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer eleven = new SoundPlayer(Properties.Resources.eleven);
                    eleven.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 13:
                    outputLabel.Text = "You drink Sprite and just chill all night. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";


                    SoundPlayer twelve = new SoundPlayer(Properties.Resources.twelve);
                    twelve.Play();
                    pictureBox1.Image = Properties.Resources.sprite;
                    break;
                case 14:
                    outputLabel.Text = "You dance all night and have fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _14 = new SoundPlayer(Properties.Resources._14);
                    _14.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 15:
                    outputLabel.Text = "You watch a terror movie and next day you go to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    pictureBox1.Image = Properties.Resources.movie;
                    SoundPlayer _15 = new SoundPlayer(Properties.Resources._15);
                    _15.Play();
                    break;
                case 16:
                    outputLabel.Text = "You walk around and he asks you which is your favourite icecream flavour. Vanilla or chocolate?";
                    option1Label.Text = "Vanilla";
                    option2Label.Text = "Chocolate";

                    SoundPlayer _16 = new SoundPlayer(Properties.Resources._16);
                    _16.Play();
                    pictureBox1.Image = Properties.Resources.icecream;
                    break;
                case 17:
                    outputLabel.Text = "You go to the dance with a pink dress and Ryan wears a blue tie. What do you want to do there?";
                    option1Label.Text = "Eat";
                    option2Label.Text = "Dance";

                    SoundPlayer _34 = new SoundPlayer(Properties.Resources._34);
                    _34.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 18:
                    outputLabel.Text = "You go to the dance with a blue dress and Ryan dress a blue tie. What do you want to do there?";
                    option1Label.Text = "Meet Ryan's friends";
                    option2Label.Text = "Meet your friends";

                    SoundPlayer _18 = new SoundPlayer(Properties.Resources._18);
                    _18.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 19:
                    outputLabel.Text = "You go to the dance with a pink dress and Ryan wears a pink tie. What do you want to do in the dance?";
                    option1Label.Text = "Play cornhole";
                    option2Label.Text = "Dance";

                    SoundPlayer _19 = new SoundPlayer(Properties.Resources._19);
                    _19.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 20:
                    outputLabel.Text = "You go to the dance with a blue dress and Ryan wears a blue tie. What do you want to do in the dance?";
                    option1Label.Text = "Sing with Ryan";
                    option2Label.Text = "Dance";

                    SoundPlayer _20 = new SoundPlayer(Properties.Resources._20);
                    _20.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 21:
                    outputLabel.Text = "He buys you a vanilla icecream and then you leave to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer _21 = new SoundPlayer(Properties.Resources._21);
                    _21.Play();
                    pictureBox1.Image = Properties.Resources.vanilla;
                    break;
                case 22:
                    outputLabel.Text = "He buys you a chocolate icecream and then you leave to buy your dress. Pink or blue?";
                    option1Label.Text = "Pink";
                    option2Label.Text = "Blue";

                    SoundPlayer _22 = new SoundPlayer(Properties.Resources._22);
                    _22.Play();
                    pictureBox1.Image = Properties.Resources.chocolate;
                    break;
                case 23:
                    outputLabel.Text = "You try new foods and have such a great time!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _23 = new SoundPlayer(Properties.Resources._23);
                    _23.Play();
                    pictureBox1.Image = Properties.Resources.food;
                    break;
                case 24:
                    outputLabel.Text = "You dance all night with Ryan until the end of the night. So fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _24 = new SoundPlayer(Properties.Resources._24);
                    _24.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 25:
                    outputLabel.Text = "He presents you to his best friend Jack and his girlfriend Malori and you four have a great couple date dancing all night!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _25 = new SoundPlayer(Properties.Resources._25);
                    _25.Play();
                    pictureBox1.Image = Properties.Resources.date;
                    break;
                case 26:
                    outputLabel.Text = "You present him to your two best friends Addie and Claire and you spend the night dancing and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _26 = new SoundPlayer(Properties.Resources._26);
                    _26.Play();
                    pictureBox1.Image = Properties.Resources.girls;
                    break;
                case 27:
                    outputLabel.Text = "You lose but you still have fun dancing all night. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer error = new SoundPlayer(Properties.Resources.error);
                    error.Play();
                    pictureBox1.Image = Properties.Resources.lose;
                    break;
                case 28:
                    outputLabel.Text = "Everyone is so surprised you won and spend the rest of the night dancing. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _27 = new SoundPlayer(Properties.Resources._27);
                    _27.Play();
                    pictureBox1.Image = Properties.Resources.win;
                    break;
                case 29:
                    outputLabel.Text = "You spend all night dancing with Ryan and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _28 = new SoundPlayer(Properties.Resources._28);
                    _28.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 30:
                    outputLabel.Text = "You sing all your favourite songs with Ryan all night!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _29 = new SoundPlayer(Properties.Resources._29);
                    _29.Play();
                    pictureBox1.Image = Properties.Resources.sing;
                    break;
                case 31:
                    outputLabel.Text = "You spend all night dancing with Ryan and having fun!!! Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _30 = new SoundPlayer(Properties.Resources._30);
                    _30.Play();
                    pictureBox1.Image = Properties.Resources.dancing;
                    break;
                case 32:
                    outputLabel.Text = "You go to the dance with a pink dress and he  wears a pink tie. You drove to the dance in a pink limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _31 = new SoundPlayer(Properties.Resources._31);
                    _31.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 33:
                    outputLabel.Text = "You go to the dance with a blue dress and he wears a blue tie. You drove to the dance in a blue limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _32 = new SoundPlayer(Properties.Resources._32);
                    _32.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 34:
                    outputLabel.Text = "You go to the dance with a pink dress and he  wears a pink tie. You drove to the dance in a pink limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _33 = new SoundPlayer(Properties.Resources._33);
                    _33.Play();
                    pictureBox1.Image = Properties.Resources.pink;
                    break;
                case 35:
                    outputLabel.Text = "You go to the dance with a blue dress and he wears a blue tie. You drove to the dance in a blue limusine. Play again?";
                    option1Label.Text = "Yes";
                    option2Label.Text = "No";

                    SoundPlayer _35 = new SoundPlayer(Properties.Resources._35);
                    _35.Play();
                    pictureBox1.Image = Properties.Resources.blue;
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing";
                    option1Label.Text = "";
                    option2Label.Text = "";

                    SoundPlayer Vals2 = new SoundPlayer(Properties.Resources.Vals2);
                    Vals2.Play();
                    pictureBox1.Image = Properties.Resources.thanks;
                    break;

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