using System.Reflection.Emit;
using System.Windows.Forms;

namespace AutoClick
{
    public partial class Form1 : Form
    {
        KeyboardHook hookStart = new KeyboardHook();
        KeyboardHook hookStop = new KeyboardHook();
        public Form1()
        {
            InitializeComponent();
            hookStart.KeyPressed +=
           new EventHandler<KeyPressedEventArgs>(start_Pressed);
            // register the control + alt + F12 combination as hot key.
            hookStart.RegisterHotKey(AutoClick.ModifierKeys.None ,
                Keys.Right);
            hookStop.KeyPressed +=
          new EventHandler<KeyPressedEventArgs>(stop_Pressed);
            // register the control + alt + F12 combination as hot key.
            hookStop.RegisterHotKey(AutoClick.ModifierKeys.None,
                Keys.Left);
        }
        void start_Pressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            timer1.Interval = (int)num_interval.Value;
            timer1.Start();
        }
        void stop_Pressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            timer1.Stop();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = (int) num_interval.Value;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Mouse.LeftClick();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}