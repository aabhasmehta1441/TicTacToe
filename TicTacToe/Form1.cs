using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> availablePlaces = new List<int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 9; i++)
            {
                availablePlaces.Add(i);
            }

            foreach (int x in availablePlaces) {
            }

        }

        public void setX(Button btn, int x) {
            //btn.Image = Properties.Resources.x;
            btn.Text = "X";
            
            btn.Enabled = false;

            if (availablePlaces.Contains(x))
            {
                availablePlaces.Remove(x);
                
                
            }
            checkWinnerX();
            if (availablePlaces.Count > 1)
            {
                compTurn();
            }
            else
            {
                if (availablePlaces.Count == 0) {
                    MessageBox.Show("Draw");
                    Close();
                }
            }

        }

        public void setO(Button btn, int x) {
            //btn.Image = Properties.Resources.o;
           btn.Text = "O";
            
            btn.Enabled = false;

            if (availablePlaces.Contains(x))
            {
                availablePlaces.Remove(x);
            }
            checkWinnerO();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setX(btn1, 1);
        }

        public void compTurn() {
            Random random = new Random();
            int x = random.Next(1, 10);


            if (availablePlaces.Contains(x))
            {
                compSelectButton(x);
            }
            else {
                x = random.Next(1, 10);

                while (!availablePlaces.Contains(x)) {
                    x = random.Next(1, 10);
                }

                compSelectButton(x);
            }

        }


        public void compSelectButton(int x) {
            switch (x)
            {
                case 1:
                    setO(btn1, x);
                    break;
                case 2:
                    setO(btn2, x);
                    break;
                case 3:
                    setO(btn3, x);
                    break;
                case 4:
                    setO(btn4, x);
                    break;
                case 5:
                    setO(btn5, x);
                    break;
                case 6:
                    setO(btn6, x);
                    break;
                case 7:
                    setO(btn7, x);
                    break;
                case 8:
                    setO(btn8, x);
                    break;
                case 9:
                    setO(btn9, x);
                    break;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            setX(btn5, 5);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            setX(btn2, 2);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            setX(btn3, 3);
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            setX(btn4, 4);
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            setX(btn6, 6);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            setX(btn7, 7);
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            setX(btn8, 8);
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            setX(btn9, 9);
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            setX(btn1, 1);
        }


        public void checkWinnerX() {

            if (btn1.Text.Equals("X") && btn2.Text.Equals("X") && btn3.Text.Equals("X")) {
                //---
                //
                //
                enhanceWinX(btn1, btn2, btn3);
                MessageBox.Show("You won!!");
                Close();
            }
            else if (btn1.Text.Equals("X") && btn4.Text.Equals("X") && btn7.Text.Equals("X")) {
                //-
                //-
                //-
                enhanceWinX(btn1, btn4, btn7);
                MessageBox.Show("You won!!");
                Close();
            }
            else if (btn1.Text.Equals("X") && btn5.Text.Equals("X") && btn9.Text.Equals("X"))
            {
                //-
                //  -
                //    -
                enhanceWinX(btn1, btn5, btn9);
                MessageBox.Show("You won!!");
                Close();
            }
            else if (btn3.Text.Equals("X") && btn6.Text.Equals("X") && btn9.Text.Equals("X"))
            {
                //   -
                //   -
                //   -
                enhanceWinX(btn3, btn6, btn9);
                MessageBox.Show("You won!!");
                Close();
            }
            else if (btn3.Text.Equals("X") && btn5.Text.Equals("X") && btn7.Text.Equals("X"))
            {
                //   -
                //  - 
                // -  
                enhanceWinX(btn3, btn5, btn7);
                MessageBox.Show("You won!!");
                Close();
            }
            else if (btn7.Text.Equals("X") && btn8.Text.Equals("X") && btn9.Text.Equals("X"))
            {
                //
                //
                // ---
                enhanceWinX(btn7, btn8, btn9);
                MessageBox.Show("You won!!");
                Close();
            }
            else if (btn4.Text.Equals("X") && btn5.Text.Equals("X") && btn6.Text.Equals("X"))
            {
                //   
                //---
                //   
                enhanceWinX(btn4, btn5, btn6);
                MessageBox.Show("You won!!");
                Close();
            }
            else if (btn2.Text.Equals("X") && btn5.Text.Equals("X") && btn8.Text.Equals("X"))
            {
                // - 
                // -
                // -  
                enhanceWinX(btn2, btn5, btn8);
                MessageBox.Show("You won!!");
                Close();
            }


        }


        public void enhanceWinX(Button b1,Button b2,Button b3) {

            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;

            b1.ForeColor = Color.Green;
            b2.ForeColor = Color.Green;
            b3.ForeColor = Color.Green;
        }

        public void enhanceLoseO(Button b1, Button b2, Button b3) {

            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;

            b1.ForeColor = Color.Red;
            b2.ForeColor = Color.Red;
            b3.ForeColor = Color.Red;

        }



        public void checkWinnerO(){
            if (btn1.Text.Equals("O") && btn2.Text.Equals("O") && btn3.Text.Equals("O"))
            {
                //---
                enhanceLoseO(btn1, btn2, btn3);
                MessageBox.Show("You lost!!");
                Close();
            }
            else if (btn1.Text.Equals("O") && btn4.Text.Equals("O") && btn7.Text.Equals("O"))
            {
                //-
                //-
                //-
                enhanceLoseO(btn1, btn4, btn7);
                MessageBox.Show("You lost!!");
                Close();
            }
            else if (btn1.Text.Equals("O") && btn5.Text.Equals("O") && btn9.Text.Equals("O"))
            {
                //-
                //  -
                //    -
                enhanceLoseO(btn1, btn5, btn9);
                MessageBox.Show("You lost!!");
                Close();
            }
            else if (btn3.Text.Equals("O") && btn6.Text.Equals("O") && btn9.Text.Equals("O"))
            {
                //   -
                //   -
                //   -
                enhanceLoseO(btn3, btn6, btn9);
                MessageBox.Show("You lost!!");
                Close();
            }
            else if (btn3.Text.Equals("O") && btn5.Text.Equals("O") && btn7.Text.Equals("O"))
            {
                //   -
                //  - 
                // -  
                enhanceLoseO(btn3, btn5, btn7);
                MessageBox.Show("You lost!!");
                Close();
            }
            else if (btn7.Text.Equals("O") && btn8.Text.Equals("O") && btn9.Text.Equals("O"))
            {
                //
                //
                // ---
                enhanceLoseO(btn7, btn8, btn9);
                MessageBox.Show("You lost!!");
                Close();
            }
            else if (btn4.Text.Equals("O") && btn5.Text.Equals("O") && btn6.Text.Equals("O"))
            {
                //   
                //---
                //   
                enhanceLoseO(btn4, btn5, btn6);
                MessageBox.Show("You lost!!");
                Close();
            }
            else if (btn2.Text.Equals("O") && btn5.Text.Equals("O") && btn8.Text.Equals("O"))
            {
                // -  
                // -
                // -  
                enhanceLoseO(btn2, btn5, btn8);
                MessageBox.Show("You lost!!");
                Close();
            }
        }



    }
}
