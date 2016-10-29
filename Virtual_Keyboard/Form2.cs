
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
//using System.IO;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using System.Drawing;


namespace Virtual_Keyboard
{
    public partial class Form2 : Form
    {


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
        public Form2()
        {

            
            InitializeComponent();
            
            
            int ScreenWidth = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width / 3.45);
            int ScreenHeight = Convert.ToInt32(Screen.PrimaryScreen.Bounds.Height / 3);

            this.Size = new System.Drawing.Size(ScreenWidth, ScreenHeight);

        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);

            
        }

        //Num7 buton
        private void Num7_Click(object sender, EventArgs e)
        {
            
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD7);
            
        }

        //Num8 button
        private void Num8_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD8);
        }
        //Num9 button
        private void Num9_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD9);
        }
        //Num4 button
        private void Num4_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD4);
        }

        //Num5 button
        private void Num5_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD5);
        }

        //Num6 button
        private void Num6_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD6);
        }

        //Num1 button
        private void Num1_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD1);
        }

        //Num2 button
        private void Num2_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD2);
        }

        //Num3 button
        private void Num3_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD3);
        }

        //Num0 button
        private void Num0_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD0);
        }

        //PrintScr button
        private void prtscnButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.PRINT);
        }

        //ScrollLock button
        private void scrlLockButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.SCROLL);
        }

        //PageUp button
        private void PgUP_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.PRIOR);
        }

        //PageDown button
        private void PgDWN_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NEXT);
        }

        /*private void RightClickKey_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RBUTTON);
        }*/

        //Endbutton button
        private void endButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.END);
        }

        //InsertButton button
        private void Insertbutton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.INSERT);
        }

        /*
        private void AttachCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            Point p = this.PointToScreen(new Point(this.ClientRectangle.X, this.ClientRectangle.Y));
            f2.Location = p;

        }*/

        Boolean IsForm3Opened;
        private void pwrUSRbutton_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            if (IsForm3Opened == false) // checking if from3 is opened 
            {// If false
                MessageBox.Show("This mode will alow you to have addition functionality such as copy , paste shortcuts, etc", "Power User : Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f3.Show();
                f3.Location = new Point(this.Location.X, this.Location.Y + this.Height);
                IsForm3Opened = true;
                //(Application.OpenForms["Form2"] as Form1).IsOpenedf3 = true;

            }
            else if (IsForm3Opened == true)
            {
                MessageBox.Show("You already have one instance of window running , you cannot open another" , "Warning : An instance is already running" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            f3.FormClosed += new FormClosedEventHandler(Form3_Closed);
        }

        void Form3_Closed(object sender , EventArgs e)
        {
            IsForm3Opened = false; // setting form 2 opened as false
        }
       
        public void opacity()
        {
            Form1 f1 = new Form1();

                this.Opacity = f1.TransparencyButton.Value/(double)100;

        }
        
    }
}
    