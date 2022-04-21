using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Generator_Password_Word_Forms
{
    public partial class Form1 : Form
    {
        char[] mainArray = new char[] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '#', '_', '$', '#', '%', '^', '&', '*', '(', ')', '-', '=', '+', '-', '/', '?', '<', '>', '!' };
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();


        }

        private void SpecialSimvolRadioButton_Click(object sender, EventArgs e)//0-26 больших символов символов, 27-52-маленикие,53-62- цифры,63-82 - символы
        {

        }


        private void ButtonGeneratePassworsd_Click(object sender, EventArgs e)
        {
            int lengthPassword = Convert.ToInt32(comboBoxLengthPassword.Text);
            string password = string.Empty;



            if (SpecialSimvolRadioButton.Checked == true
            && comboBoxCountNumber.Text == string.Empty
            && comboBoxSpecialSimvol.Text == string.Empty
            && comboBoxBigLetter.Text == string.Empty
            && comboBoxSmallLetter.Text == string.Empty
            && comboBoxLengthPassword.Text != string.Empty)
            {
                RandomPassword(textBoxPassword, password, lengthPassword, 0, 82);
            }
            else if (SpecialSimvolRadioButton.Checked == true
            && comboBoxCountNumber.Text == string.Empty
            && comboBoxBigLetter.Text != string.Empty
            && comboBoxSpecialSimvol.Text == string.Empty
            && comboBoxSmallLetter.Text == string.Empty
            && comboBoxLengthPassword.Text != string.Empty)
            {
                password = string.Empty;
                RandomPassWithBigLetter(Convert.ToInt32(comboBoxBigLetter.Text), password, lengthPassword);
            }

            else if (SpecialSimvolRadioButton.Checked == true
             && comboBoxCountNumber.Text != string.Empty
            && comboBoxBigLetter.Text != string.Empty
            && comboBoxSpecialSimvol.Text == string.Empty
            && comboBoxSmallLetter.Text == string.Empty
            && comboBoxLengthPassword.Text != string.Empty)
            {


            }


        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            char[] mainArray = new char[] { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '@', '#', '_', '$', '#', '%', '^', '&', '*', '(', ')', '-', '=', '+', '-', '/', '?', '<', '>', '!' };
            textBoxPassword.Text = string.Empty;
            if (comboBoxLengthPassword != null)
                textBoxPassword.Text = mainArray[Convert.ToInt32(comboBoxLengthPassword.Text) - 1].ToString();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RandomPassword(TextBox T, string password, int longPassword, int rndMin, int rndMax)
        {

            password = string.Empty;
            for (int i = 0; i < longPassword; i++)
            {
                password = password + mainArray[rnd.Next(rndMin, rndMax)];
            }
            T.Text = password;
        }

        //private void GenerateChar(string pass,int minValueRandom, int maxValueRandom)
        //{
        //    pass = pass + mainArray[rnd.Next(minValueRandom, maxValueRandom)];            
        //}
        private void RandomPassWithBigLetter(int genBigLetter, string password, int lengthPassword)
        {
            int smallLetter = lengthPassword - genBigLetter;
            int bigLetter = 0;
            for (int i = 0; i < lengthPassword; i++)
            {
                if (rnd.Next(0, 100) < 50 && bigLetter < genBigLetter)
                {
                    //GenerateChar(password, 0, 26);
                    password = password + mainArray[rnd.Next(0, 26)];
                    bigLetter++;
                }
                else if (smallLetter > 0)
                {
                    // GenerateChar(password, 27, 82);
                    password = password + mainArray[rnd.Next(27, 82)];
                    smallLetter--;
                }
                else
                {
                    //GenerateChar(password, 0, 26);
                    password = password + mainArray[rnd.Next(0, 26)];
                    bigLetter++;
                }
            }
            textBoxPassword.Text = password;
        }

        private void GenCharWhithNumber(int genBigLetter, int number, string password, int lengthPassword)
        {
            int smallLetter = lengthPassword - genBigLetter;
            number = lengthPassword- Convert.ToInt32(comboBoxCountNumber.Text);
            int bigLetter = 0;
            for (int i = 0; i < lengthPassword; i++)
            {
                if (rnd.Next(0, 120) < 30 && bigLetter < genBigLetter)
                {
                    //GenerateChar(password, 0, 26);
                    password = password + mainArray[rnd.Next(0, 26)];
                    bigLetter++;

                }
                else if (rnd.Next(0, 120) < 60 && bigLetter < genBigLetter)
                {
                    password = password + mainArray[rnd.Next(27, 52)];
                    smallLetter--;
                }

                else if (rnd.Next(0, 120) < 90 && bigLetter < genBigLetter && number > 0)
                {
                    password = password + mainArray[rnd.Next(53, 63)];
                    number--;
                }
                else if (rnd.Next(0, 120) > 90 && bigLetter < genBigLetter)
                {
                    password = password + mainArray[rnd.Next(53, 63)];
                }
                textBoxPassword.Text = password;
            }
        }
    }
}

