using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using System.IO;
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
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
            
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD7);
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD8);
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD9);
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD4);
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD5);
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD6);
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD1);
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD2);
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD3);
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NUMPAD0);
        }

        private void prtscnButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.PRINT);
        }

        private void scrlLockButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.SCROLL);
        }

        private void PgUP_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.PRIOR);
        }

        private void PgDWN_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.NEXT);
        }

        private void RightClickKey_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.RBUTTON);
        }

        private void endButton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.END);
        }

        private void Insertbutton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateKeyPress(VirtualKeyCode.INSERT);
        }

        private void AttachCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            Point p = this.PointToScreen(new Point(this.ClientRectangle.X, this.ClientRectangle.Y));
            f2.Location = p;

        }
    }
}
    