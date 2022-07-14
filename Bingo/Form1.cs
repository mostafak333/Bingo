using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            generateButtons();
        }
      
        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Text= "✪";
            b.Font = new Font("Georgia", 40);
            b.Enabled = false;
            checkFortTheWinner();
        }
        private void checkFortTheWinner()
        {
            int there_is_a_winner = 0;
            // check for rows 
            if(button1.Text == button2.Text &&  button3.Text == button4.Text && button4.Text == button5.Text)
            {
                there_is_a_winner++;
            }
            if (button6.Text == button7.Text && button8.Text == button9.Text && button9.Text == button10.Text)
            {
                there_is_a_winner++;
            }
            if (button11.Text == button12.Text && button13.Text == button14.Text && button14.Text == button15.Text)
            {
                there_is_a_winner++;
            }
            if (button16.Text == button17.Text && button18.Text == button19.Text && button19.Text == button20.Text)
            {
                there_is_a_winner++;
            }
            if (button21.Text == button22.Text && button23.Text == button24.Text && button24.Text == button25.Text)
            {
                there_is_a_winner++;
            }

            //check for digonal
            if (button1.Text == button7.Text && button13.Text == button19.Text && button19.Text == button25.Text)
            {
                there_is_a_winner++;
            }
            if (button5.Text == button9.Text && button13.Text == button17.Text && button17.Text == button21.Text)
            {
                there_is_a_winner++;
            }

            //check for column
            if (button1.Text == button6.Text && button11.Text == button16.Text && button16.Text == button21.Text)
            {
                there_is_a_winner++;
            }
            if (button2.Text == button7.Text && button12.Text == button17.Text && button17.Text == button22.Text)
            {
                there_is_a_winner++;
            }
            if (button3.Text == button8.Text && button13.Text == button18.Text && button18.Text == button23.Text)
            {
                there_is_a_winner++;
            }
            if (button4.Text == button9.Text && button14.Text == button19.Text && button19.Text == button24.Text)
            {
                there_is_a_winner++;
            }
            if (button5.Text == button10.Text && button15.Text == button20.Text && button20.Text == button25.Text)
            {
                there_is_a_winner++;
            }
            if (there_is_a_winner == 2) {
                MessageBox.Show("BINGO\n Winner!");
                disableButtons();

            }
        }

        private void disableButtons()
        {

            Button btn;
            for (int i = 1; i < 26; i++)
            {
                btn = (Button)Controls.Find("button" + i, true)[0];
                btn.Enabled = false;
            }
        }
        private int[] createRnadomArray()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
            Random random = new Random();
            arr = arr.OrderBy(x => random.Next()).ToArray();
            return arr;
        }
        private void generateButtons()
        {
            Button btn;
            int[] arr = createRnadomArray();
            for (int i = 0, n = 1; i < 25; i++, n++)
            {
                btn = (Button)Controls.Find("button" + n, true)[0];
                btn.Enabled = true;
                btn.Text = arr[i].ToString();
                btn.Font = new Font("Georgia", 30);
                btn.BackColor = System.Drawing.Color.White;
                btn.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ff5224");
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = System.Drawing.ColorTranslator.FromHtml("#37474f");
                btn.FlatAppearance.BorderSize = 2;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to Restart?", "Restart Game", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                generateButtons();
            }
        }

        
    }

}
