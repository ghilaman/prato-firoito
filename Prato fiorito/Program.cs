using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Resources;
//Prato Fiorito.exe
//Questo programma in pratica è un 
//prato fiorito molto rudimentale.
//potete modificarlo, migliorarlo o 
//diffonderlo, ma vi serai grato se teneste la mia fonte
//grazie.
//Creato da Drasgo , Inutilmente Studios
//il 29/08/2012. ciao a Tutti e buon divertimento!

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        SoundPlayer suono = new SoundPlayer(Resource1.tada);       
        SoundPlayer suono1 = new SoundPlayer(Resource1.Windows_XP___Rimozione_hardware);
        public int conto1 = 16;
        public String [] stringadiprova = { 
        "1", "2", "3" ,"4","5","6","7","8","9"
        };
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Vai!")
            {
                Random rand = new Random();
                int selezionanumero = rand.Next(0, 9);
                if (stringadiprova[selezionanumero]=="1")
                    button1.Text = "X";
                else
                    button1.Text = "O";
                conto1--;
                controllavittoria();
                if (button1.Text == "X")
                    controllaperdita();
                ;
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Vai!")
            {
                Random rand1 = new Random();

                int selezionanumero = rand1.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button2.Text = "X";
                else
                    button2.Text = "O";
                conto1--;
                controllavittoria();
                if (button2.Text == "X")
                    controllaperdita();
            }
            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "Vai!")
            {
                Random rand2 = new Random();

                int selezionanumero = rand2.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button3.Text = "X";
                else
                    button3.Text = "O";
                conto1--;
                controllavittoria();
                if (button3.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "Vai!")
            {
                Random rand3 = new Random();

                int selezionanumero = rand3.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button4.Text = "X";
                else
                    button4.Text = "O";
                conto1--;
                controllavittoria();
                if (button4.Text == "X")
                    controllaperdita();
            }


            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Vai!")
            {
                Random rand4 = new Random();

                int selezionanumero = rand4.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1")
                    button5.Text = "X";
                else
                    button5.Text = "O";
                conto1--;
                controllavittoria();
                if (button5.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "Vai!")
            {
                Random rand5 = new Random();

                int selezionanumero = rand5.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1")
                    button6.Text = "X";
                else
                    button6.Text = "O";
                conto1--;
                controllavittoria();
                if (button6.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "Vai!")
            {
                Random rand6 = new Random();

                int selezionanumero = rand6.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1")
                    button7.Text = "X";
                else
                    button7.Text = "O";
                conto1--;
                controllavittoria();
                if (button7.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "Vai!")
            {
                Random rand7 = new Random();

                int selezionanumero = rand7.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button8.Text = "X";
                else
                    button8.Text = "O";
                conto1--;
                controllavittoria();
                if (button8.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "Vai!")
            {
                Random rand8 = new Random();

                int selezionanumero = rand8.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1")
                    button9.Text = "X";
                else
                    button9.Text = "O";
                conto1--;
                controllavittoria();
                if (button9.Text == "X")
                    controllaperdita();
            }
            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (button10.Text == "Vai!")
            {
                Random rand9 = new Random();

                int selezionanumero = rand9.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button10.Text = "X";
                else
                    button10.Text = "O";
                conto1--;
                controllavittoria();
                if (button10.Text == "X")
                    controllaperdita();
            }


            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (button11.Text == "Vai!")
            {
                Random rand10 = new Random();

                int selezionanumero = rand10.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button11.Text = "X";
                else
                    button11.Text = "O";
                conto1--;
                controllavittoria();
                if (button11.Text == "X")
                    controllaperdita();
            }


            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (button12.Text == "Vai!")
            {
                Random rand11 = new Random();

                int selezionanumero = rand11.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button12.Text = "X";
                else
                    button12.Text = "O";
                conto1--;
                controllavittoria();
                if (button12.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (button13.Text == "Vai!")
            {
                Random rand12 = new Random();

                int selezionanumero = rand12.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1")
                    button13.Text = "X";
                else
                    button13.Text = "O";
                conto1--;
                controllavittoria();
                if (button13.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void button14_Click(object sender, EventArgs e)
        {
            if (button14.Text == "Vai!")
            {
                Random rand13 = new Random();

                int selezionanumero = rand13.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1")
                    button14.Text = "X";
                else
                    button14.Text = "O";
                conto1--;
                controllavittoria();
                if (button14.Text == "X")
                    controllaperdita();
            }


            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void button15_Click(object sender, EventArgs e)
        {
            if (button15.Text == "Vai!")
            {
                Random rand14 = new Random();

                int selezionanumero = rand14.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1")
                    button15.Text = "X";
                else
                    button15.Text = "O";
                conto1--;
                controllavittoria();
                if (button15.Text == "X")
                    controllaperdita();
            }

            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.Text == "Vai!")
            {
                Random rand15 = new Random();

                int selezionanumero = rand15.Next(0, 9);
                if (stringadiprova[selezionanumero] == "1" )
                    button16.Text = "X";
                else
                    button16.Text = "O";
                conto1--;
                controllavittoria();
                if(button16.Text=="X")
                    controllaperdita();
            }
            else
                MessageBox.Show("Tasto gia' selezionato", "Attenzione!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void controllavittoria()
        {
            if (conto1 == 1)
            {
                suono.Play();
                MessageBox.Show("Hai vinto!", "Complimenti!",
                MessageBoxButtons.OK, MessageBoxIcon.None); 
                this.Hide();
                Form1 form1 = new Form1();
                form1.ShowDialog();
                this.Close();
            }

        }
        public void controllaperdita()
        {
            suono1.Play();
            MessageBox.Show("Hai perso!  >:)", "Scarsone! ", 
            MessageBoxButtons.OK, MessageBoxIcon.None);
            this.Hide();         
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}  
/*form3.cs
Codice PHP:
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
} */