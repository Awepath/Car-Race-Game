using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Car_Race_Game
{
    public partial class Form1 : Form
    {

    

        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int moveLocked = 0;
        int speed = 10;
        int scoreInt = 0;

     
        public void randomLocation()
        {
            car_1.Left = rnd.Next(0, 284);
            car_1.Top = rnd.Next(700, 750);
            

            int carImage = rnd.Next(2, 6);
            switch (carImage)
            {
                case 1:
                    car_1.Image = Properties.Resources.car_02;
                    break;
                case 2:
                    car_1.Image = Properties.Resources.car_03;
                    break;
                case 3:
                    car_1.Image = Properties.Resources.car_04;
                    break;
                case 4:
                    car_1.Image = Properties.Resources.car_05;
                    break;
                case 5:
                    car_1.Image = Properties.Resources.car_06;
                    break;
               
                default:
                    break;

            }
        }


        public void randomLocation_2()
        {
            car_3.Left = rnd.Next(0, 284);
            car_3.Top = rnd.Next(700, 750);
            
            int carImage = rnd.Next(2, 6);
            switch (carImage)
            {
                case 1:
                    car_3.Image = Properties.Resources.car_02;
                    break;
                case 2:
                    car_3.Image = Properties.Resources.car_03;
                    break;
                case 3:
                    car_3.Image = Properties.Resources.car_04;
                    break;
                case 4:
                    car_3.Image = Properties.Resources.car_05;
                    break;
                case 5:
                    car_3.Image = Properties.Resources.car_06;
                    break;

                default:
                    break;

            }
        }



        private void default_Settings_Tick(object sender, EventArgs e)
        {
            if (car_1.Bottom < panel1.Top)
            {
                randomLocation();
                scoreInt = scoreInt + Int32.Parse(level.Text);
                score.Text = scoreInt.ToString();

            }
            if (car_3.Bottom < panel1.Top)
            {
                randomLocation_2();
                scoreInt = scoreInt + Int32.Parse(level.Text);
                score.Text = scoreInt.ToString();
            }

            car_1.Top = car_1.Top - speed;
            car_3.Top = car_3.Top - speed;
        }

        private void car_1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
             
            
        }

        private void move_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
          

      


          
            
            

          
        }

        private void crash_Tick(object sender, EventArgs e)
        {
            if (car_2.Bounds.IntersectsWith(car_1.Bounds) || car_2.Bounds.IntersectsWith(car_3.Bounds))
            {
                crash.Enabled = false;
                default_Settings.Enabled = false;
                update.Enabled = false;
                moveLocked = 1;
                MessageBox.Show("Game Over, If you click to 'OK', Game will start again in 3 seconds", "You crashed!");
                randomLocation_2();
                randomLocation();
                startAgain.Enabled = true;
              

            

            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void start_Tick(object sender, EventArgs e)
        {
            randomLocation_2();
            start.Enabled = false;
            car_3.Visible = true;
        }

        private void update_Tick(object sender, EventArgs e)
        {
            speed = speed + 1;
            if (speed > 15 & speed <= 20)
            {
                level.Text = "2";     
            }
            else if (speed > 20 && speed <= 25) 
            {
                level.Text = "3";
            }
            else if (speed > 25 && speed <= 30)
            {
                level.Text = "4";
            }
            else if (speed > 30 && speed <= 35)
            {
                level.Text = "5";
            }
           else if (speed > 35)
            {
                level.Text = "6";
                update.Enabled = false;
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (moveLocked == 0)
            {

                if (e.KeyChar == 81 || e.KeyChar == 113)
                {

                    if (car_2.Location.X > 0)
                    {
                        car_2.Left = car_2.Left - (speed / 2);
                    }


                }


                if (e.KeyChar == 69 || e.KeyChar == 101)
                {

                    if (car_2.Location.X < 282)
                    {

                        car_2.Left = car_2.Left + (speed / 2);
                    }

                }
            }
        }

        private void mouse_Tick(object sender, EventArgs e)
        {
        
        }

        private void mouseX_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
           

          
          
        }

        private void startAgain_Tick(object sender, EventArgs e)
        {
            
            speed = 10;
            scoreInt = 0;
            score.Text = "0";
            level.Text = "1";
            default_Settings.Enabled = true;
            moveLocked = 0;
            randomLocation();
            car_3.Visible = false;
            start.Enabled = true;
            crash.Enabled = true;
            update.Enabled = true;
            this.KeyPreview = true;
            startAgain.Enabled = false;
        }
    }
}
