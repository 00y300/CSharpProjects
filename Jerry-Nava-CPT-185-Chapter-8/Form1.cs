//Jerry Nava
//CPT-185-A01S
//Lab 8
using System;
using System.Media;
using System.Windows.Forms;

namespace Jerry_Nava_CPT_185_Chapter_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Convertbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string standlang = StandardtextBox.Text;
                string morse = "";

                for (int i = 0; i < standlang.Length; i++)
                {

                    switch (char.ToLower(standlang[i]))
                    {

                        case 'a': morse = ".- "; break;
                        case 'b': morse = "-..." ; break;
                        case 'c': morse = " -.-." ; break;
                        case 'd': morse = " -.." ; break;
                        case 'e': morse = "." ; break;
                        case 'f': morse = "..-." ; break;
                        case 'g': morse = "--." ; break;
                        case 'h': morse = "...." ; break;
                        case 'i': morse = ".." ; break;
                        case 'j': morse = ".---" ; break;
                        case 'k': morse = "-.-" ; break;
                        case 'l': morse = ".-.." ; break;
                        case 'm': morse = "--" ; break;
                        case 'n': morse = "-." ; break;
                        case 'o': morse = "---" ; break;
                        case 'p': morse = "-.-." ; break;
                        case 'q': morse = "--.-" ; break;
                        case 'r': morse = ".-." ; break;
                        case 's': morse = "..." ; break;
                        case 't': morse = "-" ; break;
                        case 'u': morse = "..-" ; break;
                        case 'v': morse = "...-" ; break;
                        case 'w': morse = ".--" ; break;
                        case 'x': morse = "-..-" ; break;
                        case 'y': morse = "-.--" ; break;
                        case 'z': morse = "--.." ; break;
                        case ' ': morse = " " ; break;
                        case ',': morse = "--..--" ; break;
                        case '.': morse = ".-.-.-" ; break;
                        case '0': morse = "-----" ; break;
                        case '1': morse = ".----" ; break;
                        case '2': morse = "..---" ; break;
                        case '3': morse = "...--" ; break;
                        case '4': morse = "....-" ; break;
                        case '5': morse = "....." ; break;
                        case '6': morse = "-...." ; break;
                        case '7': morse = "--..." ; break;
                        case '8': morse = "---.." ; break;
                        case '9': morse = "----." ; break;
                    }
                    MorsecodelistBox.Items.Add("             "+morse+"\n");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exitbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Clrbutton_Click(object sender, EventArgs e)
        {
            StandardtextBox.Clear();
            MorsecodelistBox.Items.Clear();
            StandardtextBox.Focus();
        }

        private void Soundbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string standlang = StandardtextBox.Text;
                for (int i = 0; i < standlang.Length; i++)
                {
                    switch (char.ToLower(standlang[i]))
                    {
                        case 'a':
                            SoundPlayer sound = new SoundPlayer("A.wav");
                            sound.PlaySync();
                            ; break;
                        case 'b':
                            SoundPlayer B = new SoundPlayer("B.wav");
                            B.PlaySync();
                            ; break;
                        case 'c':
                            SoundPlayer C = new SoundPlayer("C.wav");
                            C.PlaySync();
                            ; break;
                        case 'd':
                            SoundPlayer D = new SoundPlayer("D.wav");
                            D.PlaySync();
                            ; break;
                        case 'e':
                            SoundPlayer E = new SoundPlayer("E.wav");
                            E.PlaySync();
                            ; break;
                        case 'f':
                            SoundPlayer F = new SoundPlayer("F.wav");
                            F.PlaySync();
                            ; break;
                        case 'g':
                            SoundPlayer G = new SoundPlayer("G.wav");
                            G.PlaySync();
                            ; break;
                        case 'h':
                            SoundPlayer H = new SoundPlayer("H.wav");
                            H.PlaySync();
                            ; break;
                        case 'i':
                            SoundPlayer I = new SoundPlayer("I.wav");
                            I.PlaySync();
                            ; break;
                        case 'j':
                            SoundPlayer J = new SoundPlayer("J.wav");
                            J.PlaySync();
                            ; break;
                        case 'k':
                            SoundPlayer K = new SoundPlayer("K.wav");
                            K.PlaySync();
                            ; break;
                        case 'l':
                            SoundPlayer L = new SoundPlayer("L.wav");
                            L.PlaySync();
                            ; break;
                        case 'm':
                            SoundPlayer M = new SoundPlayer("M.wav");
                            M.PlaySync();
                            ; break;
                        case 'n':
                            SoundPlayer N = new SoundPlayer("N.wav");
                            N.PlaySync();
                            ; break;
                        case 'o':
                            SoundPlayer O = new SoundPlayer("O.wav");
                            O.PlaySync();
                            ; break;
                        case 'p':
                            SoundPlayer P = new SoundPlayer("P.wav");
                            P.PlaySync();
                            ; break;
                        case 'q':
                            SoundPlayer Q = new SoundPlayer("Q.wav");
                            Q.PlaySync();
                            ; break;
                        case 'r':
                            SoundPlayer R = new SoundPlayer("R.wav");
                            R.PlaySync();
                            ; break;
                        case 's':
                            SoundPlayer S = new SoundPlayer("S.wav");
                            S.PlaySync();
                            ; break;
                        case 't':
                            SoundPlayer t = new SoundPlayer("T.wav");
                            t.PlaySync();
                            ; break;
                        case 'u':
                            SoundPlayer U = new SoundPlayer("U.wav");
                            U.PlaySync();
                            ; break;
                        case 'v':
                            SoundPlayer V = new SoundPlayer("V.wav");
                            V.PlaySync();
                            ; break;
                        case 'w':
                            SoundPlayer W = new SoundPlayer("W.wav");
                            W.PlaySync();
                            ; break;
                        case 'x':
                            SoundPlayer X = new SoundPlayer("X.wav");
                            X.PlaySync();
                            ; break;
                        case 'y':
                            SoundPlayer Y = new SoundPlayer("Y.wav");
                            Y.PlaySync();
                            ; break;
                        case 'z':
                            SoundPlayer Z = new SoundPlayer("Z.wav");
                            Z.PlaySync();
                            ; break;

                        case ',':
                            SoundPlayer comma = new SoundPlayer(",.wav");
                            comma.PlaySync();
                            ; break;

                        case '0':
                            SoundPlayer zero = new SoundPlayer("0.wav");
                            zero.PlaySync();
                            ; break;
                        case '1':
                            SoundPlayer one = new SoundPlayer("1.wav");
                            one.PlaySync();
                            ; break;
                        case '2':
                            SoundPlayer two = new SoundPlayer("2.wav");
                            two.PlaySync();
                            ; break;
                        case '3':
                            SoundPlayer three = new SoundPlayer("3.wav");
                            three.PlaySync();
                            ; break;
                        case '4':
                            SoundPlayer four = new SoundPlayer("4.wav");
                            four.PlaySync();
                            ; break;
                        case '5':
                            SoundPlayer five = new SoundPlayer("5.wav");
                            five.PlaySync();
                            ; break;
                        case '6':
                            SoundPlayer six = new SoundPlayer("6.wav");
                            six.PlaySync();
                            ; break;
                        case '7':
                            SoundPlayer seven = new SoundPlayer("7.wav");
                            seven.PlaySync();
                            ; break;
                        case '8':
                            SoundPlayer eight = new SoundPlayer("8.wav");
                            eight.PlaySync();
                            ; break;
                        case '9':
                            SoundPlayer nine = new SoundPlayer("9.wav");
                            nine.PlaySync();
                            ; break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
