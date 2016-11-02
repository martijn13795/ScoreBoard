using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreBord
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label1.Font = new Font("DS-Digital", 260.0f, FontStyle.Bold);
            label2.Font = new Font("DS-Digital", 260.0f, FontStyle.Bold);
            label5.Font = new Font("DS-Digital", 170.0f, FontStyle.Bold);
            label7.Font = new Font("DS-Digital", 170.0f, FontStyle.Bold);
            label9.Font = new Font("DS-Digital", 60.0f, FontStyle.Bold);
            label12.Font = new Font("DS-Digital", 40.0f, FontStyle.Bold);
            label13.Font = new Font("DS-Digital", 40.0f, FontStyle.Bold);
        }

            protected override void WndProc(ref Message m)
            {
                base.WndProc(ref m);
                if (m.Msg == WM_NCHITTEST)
                    m.Result = (IntPtr)(HT_CAPTION);
            }

            private const int WM_NCHITTEST = 0x84;
            private const int HT_CLIENT = 0x1;
            private const int HT_CAPTION = 0x2;

        public string label1Text
        {
            get
            {
                return this.label1.Text;
            }
            set
            {
                this.label1.Text = value;
            }
        }

        public string label2Text
        {
            get
            {
                return this.label2.Text;
            }
            set
            {
                this.label2.Text = value;
            }
        }

        public string label3Text
        {
            get
            {
                return this.label3.Text;
            }
            set
            {
                this.label3.Text = value;
            }
        }

        public string label4Text
        {
            get
            {
                return this.label4.Text;
            }
            set
            {
                this.label4.Text = value;
            }
        }

        public string label5Text
        {
            get
            {
                return label5.Text;
            }
            set
            {
                label5.Text = value;
            }
        }

        public string label7Text
        {
            get
            {
                return label7.Text;
            }
            set
            {
                label7.Text = value;
            }
        }

        public string label9Text
        {
            get
            {
                return this.label9.Text;
            }
            set
            {
                this.label9.Text = value;
            }
        }

        public string label12Text
        {
            get
            {
                return this.label12.Text;
            }
            set
            {
                this.label12.Text = value;
            }
        }

        public string label13Text
        {
            get
            {
                return this.label13.Text;
            }
            set
            {
                this.label13.Text = value;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
