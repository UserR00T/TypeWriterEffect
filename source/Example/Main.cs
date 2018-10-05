using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TypewriterEffect;

namespace Example
{
    public partial class Main : Form
    {
        public static Typewriter typeWriter;
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            var list = new List<Typewriter.Label>
            {
                new Typewriter.Label("TypeWriterEffect", Typewriter.Label.LabelMode.OverwriteText),
                new Typewriter.Label("Adds a TypeWriter effect to Windows Forms Application.", Typewriter.Label.LabelMode.OverwriteText),
                new Typewriter.Label("Created by UserR00T.", Typewriter.Label.LabelMode.OverwriteText)
            };
            typeWriter = new Typewriter(mainLabel, list, 70, 2, 300);
        }

        private void ToggleBtn_Click(object sender, EventArgs e)
        {
            typeWriter.Toggle();
        }

        private void ForceEnableBtn_Click(object sender, EventArgs e)
        {
            typeWriter.Start();
        }

        private void ForceDisableBtn_Click(object sender, EventArgs e)
        {
            typeWriter.Stop();
        }

        private void DisposeBtn_Click(object sender, EventArgs e)
        {
            typeWriter.Dispose();
        }
    }
}
