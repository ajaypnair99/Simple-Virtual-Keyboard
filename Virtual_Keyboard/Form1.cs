//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Windows;
//using System.Threading.Tasks;
//using System.Windows.Input;
using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WindowsInput;
using System.IO;
using System.Drawing;

/// <summary>
/// WARNING ! :
/// Before you check the code , I really should've made a button array
/// Its much much much complex than it should've been 
/// yes I regret it 
/// </summary>


namespace Virtual_Keyboard
{
    
    public partial class Form1 : Form
    {

        public Boolean IsOpenedf2 = false;
        // [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        // public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);
        /*
         This was for a mouseclick function which doesn't work as needed so i removed it
        */
        //  private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        //  private const int MOUSEEVENTF_LEFTUP = 0x04;
        //  private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        //  private const int MOUSEEVENTF_RIGHTUP = 0x10;


        //double value;
        //to make the window on the top most position 
        static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
        static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
        static readonly IntPtr HWND_TOP = new IntPtr(0);
        static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
        const UInt32 SWP_NOSIZE = 0x0001;
        const UInt32 SWP_NOMOVE = 0x0002;
        const UInt32 TOPMOST_FLAGS = SWP_NOMOVE | SWP_NOSIZE;


        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Form1()
        {
            
            InitializeComponent();
            this.Location = new Point(Width - (Width - 100), Height - (Height -100));
            this.StartPosition = FormStartPosition.Manual;

        }



        //1 button
        private void One_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("!");
                PreviousButtonDisplay.Text += "!,";
            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("1");
                PreviousButtonDisplay.Text += "1,";
            }

        }

        //2 button
        private void Two_Click(object sender, EventArgs e)
        {

            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("@");
                PreviousButtonDisplay.Text += "@,";
            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("2");
                PreviousButtonDisplay.Text += "2,";

            }

        }

        //3 button
        private void Three_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("#");
                PreviousButtonDisplay.Text += "#,";

            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("3");
                PreviousButtonDisplay.Text += "3,";
            }

        }

        //4 button
        private void Four_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("$");
                PreviousButtonDisplay.Text += "$,";
            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("4");
                PreviousButtonDisplay.Text += "4,";
            }
        }

        //5 button
        private void Five_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("{%}");
                PreviousButtonDisplay.Text += "%,";
            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("5");
                PreviousButtonDisplay.Text += "5,";
            }
        }

        //6 button
        private void Six_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("{^}");
                PreviousButtonDisplay.Text += "^,";
            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("6");
                PreviousButtonDisplay.Text += "6,";
            }
        }

        //7 button
        private void Seven_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("&");
                PreviousButtonDisplay.Text += "&,";

            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("7");
                PreviousButtonDisplay.Text += "7,";
            }
        }

        //8 button
        private void Eight_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("*");
                PreviousButtonDisplay.Text += "*,";
            }
            else if (IsOpenedf2 == false)

            {
                SendKeys.Send("8");
                PreviousButtonDisplay.Text += "8,";
            }
        }

        //9 button
        private void Nine_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("(");
                PreviousButtonDisplay.Text += "(,";
            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("9");
                PreviousButtonDisplay.Text += "9,";
            }
        }

        //0 button
        private void Zero_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send(")");
                PreviousButtonDisplay.Text += "),";
            }
            else if (IsOpenedf2 == false)
            {
                SendKeys.Send("0");
                PreviousButtonDisplay.Text += "0,";
            }
        }

        //-/_ button
        private void Negative_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("_");
                PreviousButtonDisplay.Text += "_,";
            }
            else 
            {
                SendKeys.Send("-");
                PreviousButtonDisplay.Text += "-,";
            }
        }

        //Plusbutton
        private void Positive_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("+");
                PreviousButtonDisplay.Text += "+,";
            }
            else
            {
                SendKeys.Send("=");
                PreviousButtonDisplay.Text += "=,";
            }
        }

        //BackspaceButton
        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyDown(VirtualKeyCode.BACK);
           Back_SpaceButton.MouseDown += new MouseEventHandler(MouseDown);
            PreviousButtonDisplay.Text += "Backspace,";
        }

        private void MouseDown (object sender, EventArgs e)
        {

            InputSimulator.SimulateKeyPress(VirtualKeyCode.BACK);
            BackspaceButton_Click(sender , e);

        }
        //Qbutton
        private void Qbutton_Click_1(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("Q");
                PreviousButtonDisplay.Text += "Q,";
            }
            else
            {
                SendKeys.Send("q");
                PreviousButtonDisplay.Text += "q,";
            }
        }


        //Wbutton
        private void Wbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("W");
                PreviousButtonDisplay.Text += "W,";
            }
            else
            {
                SendKeys.Send("w");
                PreviousButtonDisplay.Text += "w,";
            }
        }

        //Ebutton
        private void Ebutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("E");
                PreviousButtonDisplay.Text += "E,";
            }
            else
            {
                SendKeys.Send("e");
                PreviousButtonDisplay.Text += "e,";
            }
        }
        //Rbutton
        private void Rbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("R");
                PreviousButtonDisplay.Text += "R,";
            }
            else
            {
                SendKeys.Send("r");
                PreviousButtonDisplay.Text += "r,";
            }
        }

        //Tbutton
        private void Tbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("T");
                PreviousButtonDisplay.Text += "T,";
            }
            else
            {
                SendKeys.Send("t");
                PreviousButtonDisplay.Text += "t,";
            }
        }

        //Ybutton
        private void Ybutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("Y");
                PreviousButtonDisplay.Text += "Y,";
            }
            else
            {
                SendKeys.Send("y");
                PreviousButtonDisplay.Text += "y,";
            }
        }

        //Ubutton
        private void Ubutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("U");
                PreviousButtonDisplay.Text += "U,";
            }
            else
            {
                SendKeys.Send("u");
                PreviousButtonDisplay.Text += "u,";
            }
        }

        //Ibutton
        private void Ibutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("I");
                PreviousButtonDisplay.Text += "I,";
            }
            else
            {
                SendKeys.Send("i");
                PreviousButtonDisplay.Text += "i,";

            }
        }

        //Obutton
        private void Obutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("O");
                PreviousButtonDisplay.Text += "O,";
            }
            else
            {
                SendKeys.Send("o");
                PreviousButtonDisplay.Text += "o,";
            }
        }

        //Pbutton
        private void Pbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("P");
                PreviousButtonDisplay.Text += "P,";
            }
            else
            {
                SendKeys.Send("p");
                PreviousButtonDisplay.Text += "p,";
            }
        }

        //Brakcet_Left button
        private void button20_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("{");
                PreviousButtonDisplay.Text += "{,";
            }
            else
            {
                SendKeys.Send("[");
                PreviousButtonDisplay.Text += "[,";
            }
        }

        //Bracket_Right button
        private void button21_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("}");
                PreviousButtonDisplay.Text += "},";
            }

            else
            {
                SendKeys.Send("]");
                PreviousButtonDisplay.Text += "],";
            }
        }

        //Slash button
        private void button22_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("|");
                PreviousButtonDisplay.Text += "|,";
            }
            else
            {
                InputSimulator.SimulateKeyPress(VirtualKeyCode.OEM_102);
                //super insane stupid thing to bring up backslash because
                //C# doesn't recognize single backslash and will use it for \n,\t,etc;
                string backslash = @"\";
                PreviousButtonDisplay.Text += backslash;
            }


        }
        
        //Abutton
        private void Abutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("A");
                PreviousButtonDisplay.Text += "A,";
            }
            else
                SendKeys.Send("a");
            PreviousButtonDisplay.Text += "a,";
        }

        //Sbutton
        private void Sbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("S");
                PreviousButtonDisplay.Text += "S,";
            }
            else
            {
                SendKeys.Send("s");
                PreviousButtonDisplay.Text += "s,";
            }
        }

        //Dbutton
        private void Dbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("D");
                PreviousButtonDisplay.Text += "D,";
            }

            else
            {
                SendKeys.Send("d");
                PreviousButtonDisplay.Text += "d,";
            }
        }

        //Ebutton
        private void Fbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("F");
                PreviousButtonDisplay.Text += "F,";

            }
            else
            {
                SendKeys.Send("f");
                PreviousButtonDisplay.Text += "f,";
            }
        }

               //Gbutton
        private void Gbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("G");
                PreviousButtonDisplay.Text += "G,";
            }

            else
            {
                SendKeys.Send("g");
                PreviousButtonDisplay.Text += "g,";
            }

            
        }

        //Hbutton
        private void Hbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("H");
                PreviousButtonDisplay.Text += "H,";
            }

            else
            {
                SendKeys.Send("h");
                PreviousButtonDisplay.Text += "h,";
            }
        }

        //Jbutton
        private void Jbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("J");
                PreviousButtonDisplay.Text += "J,";
            }
            else
            {
                SendKeys.Send("j");
                PreviousButtonDisplay.Text += "j,";
            }
        }

        //Kbutton
        private void Kbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("K");
                PreviousButtonDisplay.Text += "K,";
            }

            else
            {
                SendKeys.Send("k");
                PreviousButtonDisplay.Text += "k,";
            }
        }

        //Lbutton
        private void Lbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("L");
                PreviousButtonDisplay.Text += "L,";
            }
            else
            {
                SendKeys.Send("l");
                PreviousButtonDisplay.Text += "l,";
            }
        }

        //SemiColon_Button
        private void SemiColon_Button_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send(":");
                PreviousButtonDisplay.Text += ":,";
            }
            else
            {
                SendKeys.Send(";");
                PreviousButtonDisplay.Text += ";,";
            }
        }

        //appostropher_Button
        private void appo_button_Click(object sender, EventArgs e)
        {
            SendKeys.Send("'");
            PreviousButtonDisplay.Text += "',";
        }

        //EnterButton
        private void EnterButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
            PreviousButtonDisplay.Text += "ENTER,";
        }

        //EscapeButton
        private void esc_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.ESCAPE);
            PreviousButtonDisplay.Text += "ESC,";
        }

        //F1button
        private void Function1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F1}");
            PreviousButtonDisplay.Text += "F1,";
        }

        //F2button
        private void Function2_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F2}");
            PreviousButtonDisplay.Text += "F2,";
        }

        //F3button
        private void Function3_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F3}");
            PreviousButtonDisplay.Text += "F3,";
        }

        //F4button
        private void Function4_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F4}");
            PreviousButtonDisplay.Text += "F4,";
        }

        //F5button
        private void Function5_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F5}");
            PreviousButtonDisplay.Text += "F5,";
        }

        //F6button
        private void Function6_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F6}");
            PreviousButtonDisplay.Text += "F6,";
        }

        //F7button
        private void Function7_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F7}");
            PreviousButtonDisplay.Text += "F7,";
        }

        //F8button
        private void Function8_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F8}");
            PreviousButtonDisplay.Text += "F8,";
        }

        //F9button
        private void Function9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F9}");
            PreviousButtonDisplay.Text += "F9,";
        }

        //F10button
        private void Function10_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F10}");
            PreviousButtonDisplay.Text += "F10,";
        }

        //F11button
        private void Function11_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F11}");
            PreviousButtonDisplay.Text += "F11,";
        }

        //F12button
        private void Function12_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{F12}");
            PreviousButtonDisplay.Text += "F12,";
        }

        //Zbutton
        private void Zbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("Z");
                PreviousButtonDisplay.Text += "Z,";
            }
            else
            {
                SendKeys.Send("z");
                PreviousButtonDisplay.Text += "z,";
            }
        }

        //Xbutton
        private void Xbutton_Click_1(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("X");
                PreviousButtonDisplay.Text += "X,";
            }
            else
            {
                SendKeys.Send("x");
                PreviousButtonDisplay.Text += "x,";
            }
        }

        //Cbutton
        private void Cbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("C");
                PreviousButtonDisplay.Text += "C,";
            }
            else
            {
                SendKeys.Send("c");
                PreviousButtonDisplay.Text += "c,";
            }
        }

        //Vbutton
        private void Vbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("V");
                PreviousButtonDisplay.Text += "V,";
            }
            else
            {
                SendKeys.Send("v");
                PreviousButtonDisplay.Text += "v,";
            }
        }

        //Bbutton
        private void Bbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("B");
                PreviousButtonDisplay.Text += "B,";
            }
            else
            {
                SendKeys.Send("b");
                PreviousButtonDisplay.Text += "b,";
            }
        }

        //Nbutton
        private void Nbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("N");
                PreviousButtonDisplay.Text += "N,";
            }
            else
            {
                SendKeys.Send("n");
                PreviousButtonDisplay.Text += "n,";
            }
        }

        //Mbutton
        private void Mbutton_Click(object sender, EventArgs e)
        {
            if (Caps_CheckBox.Checked || Shift_CheckBox.Checked)
            {
                SendKeys.Send("M");
                PreviousButtonDisplay.Text += "M,";
            }
            else
            {
                SendKeys.Send("m");
                PreviousButtonDisplay.Text += "m,";
            }
        }

        //,Button
        private void Comma_Button_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("{<}");
                PreviousButtonDisplay.Text += "<,";
            }
            else
            {
                SendKeys.Send("{,}");
                PreviousButtonDisplay.Text += ", ,";
            }
        }

        //.Button
        private void Period_button_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("{>}");
                PreviousButtonDisplay.Text += ">,";
            }
            else
            {
                SendKeys.Send("{.}");
                PreviousButtonDisplay.Text += ".,";
            }
        }

        //?button
        private void QuestionMarkButton_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("{?}");
                PreviousButtonDisplay.Text += "?,";
            }
            else
            {
                SendKeys.Send("{/}");
                PreviousButtonDisplay.Text += "/,";
            }
        }

        //ShiftButton
        private void ShiftButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.SHIFT);
            PreviousButtonDisplay.Text += "Shift,";
        }

        //UPbutton
        private void UPbutton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
            PreviousButtonDisplay.Text += "UP,";
        }

        //LeftButton
        private void LeftButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
            PreviousButtonDisplay.Text += "LEFT,";
        }

        //DownButton
        private void DownButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
            PreviousButtonDisplay.Text += "DOWN,";
        }

        //RightButton
        private void RightButton_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
            PreviousButtonDisplay.Text += "RIGHT,";
        }

        //SpaceButton
        private void SpaceButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.SPACE);
            PreviousButtonDisplay.Text += "SPACE,";
        }

        
        //Form loading so that the window stays on top of other windows
        private void Form1_Load(object sender, EventArgs e)
        {
             Point formlocation = this.Location;

            //removed this.Handle qualification 
            //still works fine
            SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            
        }

        //Right Windows Button
        private void WindowsButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyDown(VirtualKeyCode.RWIN);
            PreviousButtonDisplay.Text += "RWin";
        }

        //Transparency Hscroll to change Opacity of the window
        //Value goes from 40 - 100 
        //Transparency.Min = 40 , Transparency.Max = 100;
        //Defaults to 100
        private void TransparencyButton_Scroll(object sender, ScrollEventArgs e)
        {

            this.Opacity = TransparencyButton.Value / (double)100;
            
            /*
             TransparencyButton.Maximum = 100;
             TransparencyButton.Minimum = 20;
             TransparencyButton.Value = 50;


            if(TransparencyButton.Value == TransparencyButton.Minimum)
                this.Opacity = 0;
            else if ( TransparencyButton.Value == TransparencyButton.Maximum) 
                this.Opacity = 100;
                */

        }

        //Control button
        private void CTRL_button_CheckedChanged(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.CONTROL);
            PreviousButtonDisplay.Text += "Control";
        }

        //Tilde Key
        private void Tilde_Click(object sender, EventArgs e)
        {
            if (Shift_CheckBox.Checked)
            {
                SendKeys.Send("~");
                PreviousButtonDisplay.Text += "~";
            }
            else
            {
                SendKeys.Send("`");
                PreviousButtonDisplay.Text += "`";
            }
        }

        //Delete Key
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.DELETE);
            PreviousButtonDisplay.Text += "Delete";
        }

        //Tab Key
        private void TabButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.TAB);
            PreviousButtonDisplay.Text += "Tab";
        }

        //Alt button
        private void AltButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.MENU);
            PreviousButtonDisplay.Text += "ALT";
        }

        //Volume Up button
        private void VolUPButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_UP);
            PreviousButtonDisplay.Text += "VolUP";
        }

        //Volume Down button
        private void VolDWNButton_Click(object sender, EventArgs e)
        {
            
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_DOWN);
            PreviousButtonDisplay.Text += "VolDWN";
        }

        //Volume Mute button
        private void VolMuteButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.VOLUME_MUTE);
            PreviousButtonDisplay.Text += "VolMute";
        }

        //Home button
        private void HomeButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.HOME);
            PreviousButtonDisplay.Text += "Home";
        }

        //Left Windows button
        private void LWin_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.LWIN);
            PreviousButtonDisplay.Text += "Lwin";
        }

        private void ControlButtonLeft_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.CONTROL);
            PreviousButtonDisplay.Text += "Control";
        }

        
        int counter = 1;
        private void RefreshTimer_Tick(object sender, EventArgs e)
        {

            //PreviousButtonDisplay.Refresh();
            counter++;
            Clearfunction();
            //PreviousButtonDisplay.Text = "";
        }

        //implementing a clear function
        void Clearfunction()
        {
            //super stupid hacks to implement a counter that auto-clears in 300 seconds
            if (counter % 300 == 0)
            {
                PreviousButtonDisplay.Text = "";
                counter = 1;
            }
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            PreviousButtonDisplay.Text = "";
            PreviousButtonDisplay.Text = "CLEAR";
        }

       
        private void ExtendButton_Click(object sender, EventArgs e)
        {
            //IsOpenedf2is to check if form 2 is opened and will not allow the number keys on top to work
            //I used the same variable to check if the form is open so that multiple instances cannot be opened together
            //IsOpenedf2 decleration is at the top of the code
            Form2 f2 = new Form2();

            if (IsOpenedf2 == false)
            {
                MessageBox.Show("Opening the extended Numpad will render the number keys useless, you can still use it for special characters", "Warning. To regain access , close the Extended Window", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f2.Show();
                f2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
                IsOpenedf2 = true;
            }else if ( IsOpenedf2 == true)
            {
                MessageBox.Show("You already have one instance of window running , you cannot open another", "Warning : An instance is already running", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            f2.FormClosed += new FormClosedEventHandler(Form2_FormClosed);

        }
        

        void Form2_FormClosed(object sender, EventArgs e)
        {
            IsOpenedf2 = false;
        }

        /*
         * 
         * Need to add some more code here to check if form3 is opened from form2
         * The code is incomplete, but the application still works , the isntaller is not updated
         */


        // Power User accessing button
        public Boolean IsOpenedf3; //global variable to see if form 3 is opened 
        public void PWRUSRButton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(); // accessing form 3 
            Form2 f2 = new Form2(); // accessing form 2

            if (IsOpenedf3 == false ) // checking if form 3 is opened 
            {
                //if form 3 opened is false
                MessageBox.Show("This mode will alow you to have addition functionality such as copy , paste shortcuts, etc", "Power User : Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f3.Location = new Point(f2.Location.X, f2.Location.Y + f2.Height); //setting its co-ordinates
                f3.Show(); //displaying form 3
               
                IsOpenedf3 = true; // setting form 3 open to true
            }else if(IsOpenedf3 == true )
            {
                // message displayed if form 3 is already open
                MessageBox.Show("You already have one instance of window running , you cannot open another", "Warning : An instance is already running", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }

            //Handler to check if form 3 is closed
            f3.FormClosed += new FormClosedEventHandler(Form3_FormClosed);
        }

        //Method to check if form 3 is closed
        void Form3_FormClosed(object sender , EventArgs e)
        {
            //If closed , Opened = false
            IsOpenedf3 = false;
        }

        //Boolean Isform3Openedfromf2;
      //  public void form2openchecker()
       // {
            
            
            
       // }
    }

}
       