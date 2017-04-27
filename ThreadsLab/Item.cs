using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsLab
{
    class Item
    { 
        public string NumberString { get; set; }
        public int NumberInt { get; set; }

        public Item(int i)
        {
            Save(i);
        }

        public void Save(int i)
        {
            NumberString = i.ToString();
 
            NumberInt = i;
        }

        public void SaveSleep(int i)
        {
            NumberString = i.ToString();
            Thread.Sleep(0);
            NumberInt = i;
        }

        public void SaveLock(int i, object locker)
        {
            lock (locker)
            {
                NumberString = i.ToString();
                NumberInt = i;
            }
        }

        public bool CheckCorrect()
        {
            bool correct = true;

            if (NumberInt != Int32.Parse(NumberString))
            {
                correct = false;
            }

            return correct;
        }

        public bool CheckCorrectLock(object locker)
        {
            bool correct = true;

            lock (locker)
            {
                if (NumberInt != Int32.Parse(NumberString))
                {
                    correct = false;
                }
            }

            return correct;
        }
    }
}
