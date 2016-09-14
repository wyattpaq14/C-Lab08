using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inclass_week9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string message = "";
        private void button1_Click(object sender, EventArgs e)
        {
            string engText = txtEnglish.Text;
            string latText = "";
            char[] text = engText.ToCharArray();
            int arraySize = text.Length;

            Array.Reverse(text);

            for (int i = 0; i < text.Length; i++)
            {
                char letter = text[i];
                message += letter;

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {

                }
                else
                {
                    text[i] = '.';
                    text[i + text.Length] = letter;
                }
                
            }


            MessageBox.Show("Letter:" + message + "Size: " + arraySize);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
