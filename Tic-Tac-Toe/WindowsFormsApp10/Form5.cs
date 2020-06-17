using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp10
{
    public partial class Form5 : Form
    {
        Random r = new Random();
        int[] myarray = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        bool whosturn=true;
        bool win = false;
        int counter = 0;
        public Form5()
        {
            InitializeComponent();
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button1.Text = "X";
            button1.Enabled = false;
            myarray[0] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            Check_winner();
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }
            Pc_turn(pc);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button2.Text = "X";
            button2.Enabled = false;
            Check_winner();
            myarray[1] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1]==0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }
           
            Pc_turn(pc);
        }
        private void Pc_turn(int pc)
        {
            if (pc == 1 && button1.Enabled == true)
            {
                counter = counter + 1;
                button1.Text = "O";
                myarray[pc - 1] = 0;
                button1.Enabled = false;
                whosturn = false;
            }
            else if (pc == 2 && button2.Enabled == true)
            {
                counter = counter + 1;
                button2.Text = "O";
                myarray[pc - 1] = 0;
                button2.Enabled = false;
                whosturn = false;
            }
            else if (pc == 3 && button3.Enabled == true)
            {
                counter = counter + 1;
                button3.Text = "O";
                myarray[pc - 1] = 0;
                button3.Enabled = false;
                whosturn = false;
            }
            else if (pc == 4 && button4.Enabled == true)
            {
                counter = counter + 1;
                button4.Text = "O";
                myarray[pc - 1] = 0;
                button4.Enabled = false;
                whosturn = false;
            }
            else if (pc == 5 && button5.Enabled == true)
            {
                counter = counter + 1;
                button5.Text = "O";
                myarray[pc - 1] = 0;
                button5.Enabled = false;
                whosturn = false;
            }
            else if (pc == 6 && button6.Enabled == true)
            {
                counter = counter + 1;
                button6.Text = "O";
                myarray[pc - 1] = 0;
                button6.Enabled = false;
                whosturn = false;
            }
            else if (pc == 7 && button7.Enabled == true)
            {
                counter = counter + 1;
                button7.Text = "O";
                myarray[pc - 1] = 0;
                button7.Enabled = false;
                whosturn = false;
            }
            else if (pc == 8 && button8.Enabled == true)
            {
                counter = counter + 1;
                button8.Text = "O";
                myarray[pc - 1] = 0;
                button8.Enabled = false;
                whosturn = false;

            }
            else if (pc == 9 && button9.Enabled == true)
            {
                counter = counter + 1;
                button9.Text = "O";
                myarray[pc - 1] = 0;
                button9.Enabled = false;
                whosturn = false;
            }
            else if (pc == 10 && button10.Enabled == true)
            {
                counter = counter + 1;
                button10.Text = "O";
                myarray[pc - 1] = 0;
                button10.Enabled = false;
                whosturn = false;
            }
            else if (pc == 11 && button11.Enabled == true)
            {
                counter = counter + 1;
                button11.Text = "O";
                myarray[pc - 1] = 0;
                button11.Enabled = false;
                whosturn = false;
            }
            else if (pc == 12 && button12.Enabled == true)
            {
                counter = counter + 1;
                button12.Text = "O";
                myarray[pc - 1] = 0;
                button12.Enabled = false;
                whosturn = false;
            }
            else if (pc == 13 && button13.Enabled == true)
            {
                counter = counter + 1;
                button13.Text = "O";
                myarray[pc - 1] = 0;
                button13.Enabled = false;
                whosturn = false;
            }
            else if (pc == 14 && button14.Enabled == true)
            {
                counter = counter + 1;
                button14.Text = "O";
                myarray[pc - 1] = 0;
                button14.Enabled = false;
                whosturn = false;
            }
            else if (pc == 15 && button15.Enabled == true)
            {
                counter = counter + 1;
                button15.Text = "O";
                myarray[pc - 1] = 0;
                button15.Enabled = false;
                whosturn = false;
            }
            else if (pc == 16 && button16.Enabled == true)
            {
                counter = counter + 1;
                button16.Text = "O";
                myarray[pc - 1] = 0;
                button16.Enabled = false;
                whosturn = false;
            }
            else if (pc == 17 && button17.Enabled == true)
            {
                counter = counter + 1;
                button17.Text = "O";
                myarray[pc - 1] = 0;
                button17.Enabled = false;
                whosturn = false;
            }
            else if (pc == 18 && button18.Enabled == true)
            {
                counter = counter + 1;
                button18.Text = "O";
                myarray[pc - 1] = 0;
                button18.Enabled = false;
                whosturn = false;
            }

            else if (pc == 19 && button19.Enabled == true)
            {
                counter = counter + 1;
                button19.Text = "O";
                myarray[pc - 1] = 0;
                button19.Enabled = false;
                whosturn = false;
            }
            else if (pc == 20 && button20.Enabled == true)
            {
                counter = counter + 1;
                button20.Text = "O";
                myarray[pc - 1] = 0;
                button20.Enabled = false;
                whosturn = false;
            }
            else if (pc == 21 && button21.Enabled == true)
            {
                counter = counter + 1;
                button21.Text = "O";
                myarray[pc - 1] = 0;
                button21.Enabled = false;
                whosturn = false;
            }
            else if (pc == 22 && button22.Enabled == true)
            {
                counter = counter + 1;
                button22.Text = "O";
                myarray[pc - 1] = 0;
                button22.Enabled = false;
                whosturn = false;
            }
            else if (pc == 23 && button23.Enabled == true)
            {
                counter = counter + 1;
                button23.Text = "O";
                myarray[pc - 1] = 0;
                button23.Enabled = false;
                whosturn = false;
            }
            else if (pc == 24 && button24.Enabled == true)
            {
                counter = counter + 1;
                button24.Text = "O";
                myarray[pc - 1] = 0;
                button24.Enabled = false;
                whosturn = false;
            }
            else if (pc == 25 && button25.Enabled == true)
            {
                counter = counter + 1;
                button25.Text = "O";
                myarray[pc - 1] = 0;
                button25.Enabled = false;
                whosturn = false;
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button3.Text = "X";
            button3.Enabled = false;
            Check_winner();
            myarray[2] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button4.Text = "X";
            button4.Enabled = false;
            Check_winner();
            myarray[3] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button5.Text = "X";
            button5.Enabled = false;
            Check_winner();
            myarray[4] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button6.Text = "X";
            button6.Enabled = false;
            Check_winner();
            myarray[5] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button7.Text = "X";
            button7.Enabled = false;
            Check_winner();
            myarray[6] = 0;
            int pc = r.Next(1, 9);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button8.Text = "X";
            button8.Enabled = false;
            Check_winner();
            myarray[7] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button9.Text = "X";
            button9.Enabled = false;
            Check_winner();
            myarray[8] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button10.Text = "X";
            button10.Enabled = false;
            Check_winner();
            myarray[9] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button11.Text = "X";
            button11.Enabled = false;
            Check_winner();
            myarray[10] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button12.Text = "X";
            button12.Enabled = false;
            Check_winner();
            myarray[11] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button13.Text = "X";
            button13.Enabled = false;
            Check_winner();
            myarray[12] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button14.Text = "X";
            button14.Enabled = false;
            Check_winner();
            myarray[13] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button15.Text = "X";
            button15.Enabled = false;
            Check_winner();
            myarray[14] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);

        }

        private void button16_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button16.Text = "X";
            button16.Enabled = false;
            Check_winner();
            myarray[15] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button17.Text = "X";
            button17.Enabled = false;
            Check_winner();
            myarray[16] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button18.Text = "X";
            button18.Enabled = false;
            Check_winner();
            myarray[17] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button19.Text = "X";
            button19.Enabled = false;
            Check_winner();
            myarray[18] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button20.Text = "X";
            button20.Enabled = false;
            Check_winner();
            myarray[19] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        
        private void button21_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button21.Text = "X";
            button21.Enabled = false;
            Check_winner();
            myarray[20] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button22.Text = "X";
            button22.Enabled = false;
            Check_winner();
            myarray[21] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button23.Text = "X";
            button23.Enabled = false;
            Check_winner();
            myarray[22] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button24.Text = "X";
            button24.Enabled = false;
            Check_winner();
            
            myarray[23] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }
            Pc_turn(pc);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            counter = counter + 1;
            button25.Text = "X";
            button25.Enabled = false;
            Check_winner();
            myarray[24] = 0;
            int pc = r.Next(1, 25);
            whosturn = true;
            if (myarray[0] == 0 && myarray[1] == 0 && myarray[2] == 0 && myarray[3] == 0 && myarray[4] == 0 && myarray[5] == 0 && myarray[6] == 0 && myarray[7] == 0 && myarray[8] == 0 && myarray[9] == 0 && myarray[10] == 0 && myarray[11] == 0 && myarray[12] == 0 && myarray[13] == 0 && myarray[14] == 0 && myarray[15] == 0 && myarray[16] == 0 && myarray[17] == 0 && myarray[18] == 0 && myarray[19] == 0 && myarray[20] == 0 && myarray[21] == 0 && myarray[22] == 0 && myarray[23] == 0 && myarray[24] == 0)
            {
                Check_winner();
            }
            else
            {
                while (myarray[pc - 1] == 0)
                {
                    pc = r.Next(1, 25);
                }
            }

            Pc_turn(pc);
        }
        private void Check_winner()
        {
            //orizontia
            if (button1.Text == button2.Text && button2.Text == button3.Text && button3.Text == button4.Text && button4.Text == button5.Text && button1.Enabled == false)
            {
                win = true;
            }
            else if (button6.Text== button7.Text && button7.Text == button8.Text && button8.Text == button9.Text && button9.Text == button10.Text && button6.Enabled == false)
            {
                win = true;
            }
            else if (button11.Text == button12.Text && button12.Text == button13.Text && button13.Text == button14.Text && button14.Text == button15.Text && button11.Enabled == false)
            {
                win = true;
            }
            else if(button16.Text == button17.Text && button17.Text == button18.Text && button18.Text == button19.Text && button19.Text == button20.Text && button16.Enabled == false)
            {
                win = true;
            }
            else if(button21.Text == button22.Text && button22.Text == button23.Text && button23.Text == button24.Text && button24.Text == button25.Text && button21.Enabled == false)
            {
                win = true;
            }

            //katheta
            else if (button1.Text == button6.Text && button6.Text == button11.Text && button11.Text == button16.Text && button16.Text == button21.Text && button1.Enabled == false)
            {
                win = true;
            }
            else if(button2.Text == button7.Text && button7.Text == button12.Text && button12.Text == button17.Text && button17.Text == button22.Text && button2.Enabled == false)
            {
                win = true;
            }
            else if (button3.Text == button8.Text && button8.Text == button13.Text && button13.Text == button18.Text && button18.Text == button23.Text && button3.Enabled == false)
            {
                win = true;
            }
            else if(button4.Text == button9.Text && button9.Text == button14.Text && button14.Text == button19.Text && button19.Text == button24.Text && button4.Enabled == false)
            {
                win = true;
            }
            else if(button5.Text == button10.Text && button10.Text == button15.Text && button15.Text == button20.Text && button20.Text == button25.Text && button5.Enabled == false)
            {
                win = true;
            }
            //kuria diagwnios
            else if (button1.Text == button7.Text && button7.Text == button13.Text && button13.Text == button19.Text && button19.Text == button25.Text && button1.Enabled == false)
            {
                win = true;
            }
            //deutereuousa diagwnios
            else if(button5.Text == button9.Text && button9.Text == button13.Text && button13.Text == button17.Text && button17.Text == button21.Text && button5.Enabled == false)
            {
                win = true;
            }

            if (win == true)
            {
                lock_button();
                if (whosturn == true)
                {
                    MessageBox.Show("Winner is pc/o");
                }
                else if (whosturn==false)
                {
                    MessageBox.Show("Winner is user/x");
                }
            }
            else  
            {
                if (counter == 25)
                {
                    MessageBox.Show("Isopalia");
                }
            }
        }
        private void lock_button()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
            button11.Enabled = false;
            button12.Enabled = false;
            button13.Enabled = false;
            button14.Enabled = false;
            button15.Enabled = false;
            button16.Enabled = false;
            button17.Enabled = false;
            button18.Enabled = false;
            button19.Enabled = false;
            button20.Enabled = false;
            button21.Enabled = false;
            button22.Enabled = false;
            button23.Enabled = false;
            button24.Enabled = false;
            button25.Enabled = false;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            button14.Enabled = true;
            button15.Enabled = true;
            button16.Enabled = true;
            button17.Enabled = true;
            button18.Enabled = true;
            button19.Enabled = true;
            button20.Enabled = true;
            button21.Enabled = true;
            button22.Enabled = true;
            button23.Enabled = true;
            button24.Enabled = true;
            button25.Enabled = true;
            button1.Text = " ";
            button2.Text = " ";
            button3.Text = " ";
            button4.Text = " ";
            button5.Text = " ";
            button6.Text = " ";
            button7.Text = " ";
            button8.Text = " ";
            button9.Text = " ";
            button10.Text = " ";
            button11.Text = " ";
            button12.Text = " ";
            button13.Text = " ";
            button14.Text = " ";
            button15.Text = " ";
            button16.Text = " ";
            button17.Text = " ";
            button18.Text = " ";
            button19.Text = " ";
            button20.Text = " ";
            button21.Text = " ";
            button22.Text = " ";
            button23.Text = " ";
            button24.Text = " ";
            button25.Text = " ";
            counter = 0;
            whosturn = true;
            win = false;
            for (int i = 0; i < myarray.Length; i++)
            {
                myarray[i] = 1;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }

}
