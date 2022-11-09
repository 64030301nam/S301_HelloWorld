using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Helloworld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dim ans, k, i As Integer
            k = textBox1.Text
            For i = 1 To 12
                ans = i * k
                textBox2.Text = textBox2.Text & k & " * " & i & " = " & ans & vbCrLf
            Next
        }
    }
}
