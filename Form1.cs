using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Thread threadA, threadB, threadC, threadD;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Thread Starts-");
            ThreadStart delFirstThread = new ThreadStart(MyThreadClass.Thread1);
            ThreadStart delSecondThread = new ThreadStart(MyThreadClass.Thread2);

            threadA = new Thread(delFirstThread);
            threadB = new Thread(delFirstThread);
            threadC = new Thread(delSecondThread);
            threadD = new Thread(delSecondThread);

            threadA.Priority = ThreadPriority.Highest;
            threadB.Priority = ThreadPriority.Normal;
            threadC.Priority = ThreadPriority.AboveNormal;
            threadD.Priority = ThreadPriority.BelowNormal;

            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";
            threadC.Name = "Thread C Process";
            threadD.Name = "Thread D Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("------------");
            Console.WriteLine("This is the end of Thread");
            Console.WriteLine("-End of Thread");
            label2.Text = "-End of Thread";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

  
       
    
    
}
