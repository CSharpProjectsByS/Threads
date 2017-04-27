using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadsLab
{
    public partial class Form1 : Form
    {
        Item item1 = new Item(0);
        Item item2 = new Item(0);
        Item item3 = new Item(0);


        private string MaybieCorrectValue = "";
        private string SleepCorrectValue = "";
        private string LockCorrectValue = "";
        private readonly object locker = new object();

        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }



        private void StartButton_Click(object sender, EventArgs e)
        {
            RunMaybie();
            RunCaseSleep();
            RunCaseLock();
        }

        private void RunMaybie()
        {
            int n = Int32.Parse(ObjectCount.Text);

            ProgresInfo1.Text = "W trakcie realizacji";

            Thread thread1 = new Thread(() => SaveNewValues(n));
            Thread thread2 = new Thread(() => CheckCorrectionOfValues(n));

             var stopWatch = Stopwatch.StartNew();

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            var time = stopWatch.ElapsedMilliseconds;


            MaybieCorrect.Text = MaybieCorrectValue;
            MaybieTime.Text = time.ToString() + " ms";

            ProgresInfo1.Text = "Zakończono";
        }

        private void RunCaseSleep()
        {
            int n = Int32.Parse(ObjectCount.Text);

            ProgresInfo2.Text = "W trakcie realizacji";

            Thread thread1 = new Thread(() => SaveNewValuesCaseSleep(n));
            Thread thread2 = new Thread(() => CheckCorrectionOfValuesCaseSleep(n));

            var stopWatch = Stopwatch.StartNew();

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            var time = stopWatch.ElapsedMilliseconds;


            SleepCorrect.Text = SleepCorrectValue;
            SleepTime.Text = time.ToString() + " ms";

            ProgresInfo2.Text = "Zakończono";
        }


        private void RunCaseLock()
        {
            int n = Int32.Parse(ObjectCount.Text);

            ProgresInfo3.Text = "W trakcie realizacji";

            Thread thread1 = new Thread(() => SaveNewValuesCaseLock(n));
            Thread thread2 = new Thread(() => CheckCorrectionOfValuesCaseLock(n));

            var stopWatch = Stopwatch.StartNew();

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();

            var time = stopWatch.ElapsedMilliseconds;


            LockCorrect.Text = LockCorrectValue;
            LockTime.Text = time.ToString() + " ms";

            ProgresInfo3.Text = "Zakończono";
        }

        private void SaveNewValues(int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int tmp = rnd.Next(0, 1000);
                item1.Save(tmp);
            }
        }

        private void CheckCorrectionOfValues(int n)
        {
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                if (item1.CheckCorrect())
                {
                    p++;
                }
            }

            float correctResult = (float) p / n * 100;

            MaybieCorrectValue = correctResult.ToString() + "%";
        }


        private void SaveNewValuesCaseSleep(int n)
        {
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int tmp = rnd.Next(0, 1000);
                item1.SaveSleep(tmp);
            }
        }

        private void CheckCorrectionOfValuesCaseSleep(int n)
        {
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                if (item1.CheckCorrect())
                {
                    p++;
                }
            }

            float correctResult = (float)p / n * 100;

            SleepCorrectValue = correctResult.ToString() + "%";
        }

        private void SaveNewValuesCaseLock(int n)
        {
            lock(locker)
            {
                Random rnd = new Random();
                for (int i = 0; i < n; i++)
                {
                    int tmp = rnd.Next(0, 1000);
                    item1.SaveLock(tmp, locker);
                }
            }
        }

        private void CheckCorrectionOfValuesCaseLock(int n)
        {
                int p = 0;
                for (int i = 0; i < n; i++)
                {
                    bool correct;

                    correct = item1.CheckCorrectLock(locker);
                    
                    if (correct)
                    {
                        p++;
                    }
                }

                float correctResult = (float)p / n * 100;

                LockCorrectValue = correctResult.ToString() + "%";
        }
    }
}
