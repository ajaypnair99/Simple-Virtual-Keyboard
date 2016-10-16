using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;

namespace Virtual_Keyboard
{
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SetWindowPos(Handle, HWND_TOPMOST, 0, 0, 0, 0, TOPMOST_FLAGS);
        }

        //Control + Alt + Delete
        private void ControlAltDel_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateModifiedKeyStroke(
                new[] { VirtualKeyCode.CONTROL, VirtualKeyCode.MENU },
                new[] { VirtualKeyCode.DELETE });

        }

        //Copy Keystroke
        private void Copy_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_C);
        }

        //Paste Keystroke
        private void Paste_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_V);
        }

        //Windows + Tab
        private void WinTabbutton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.RWIN, VirtualKeyCode.TAB);
        }

        //Alt + Tab
        private void alttabbutton_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.MENU, VirtualKeyCode.TAB);
        }

        //Undo
        private void undo_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_Z);
        }

        private void ctrlTab_Click(object sender, EventArgs e)
        {
            InputSimulator.SimulateModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.TAB);
        }
    }
 }

