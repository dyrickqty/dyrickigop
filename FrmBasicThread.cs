﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace FrmBasicThreadLobusta
{
    public partial class FrmBasicThread : Form
    {
        private Thread thread1, thread2;
        public FrmBasicThread()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyThreadClass threadClass = new MyThreadClass();

            Console.WriteLine("-Before starting thread-");
            ThreadStart NewThread = new ThreadStart(MyThreadClass.Thread1);

            Thread ThreadA = new Thread(NewThread);
            ThreadA.Name = "Thread A Process";

            Thread ThreadB = new Thread(NewThread);
            ThreadB.Name = "Thread B Process";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();

            Console.WriteLine("-End of Thread-");
            label1.Text = "-End of Thread-";

        }
    }
}
