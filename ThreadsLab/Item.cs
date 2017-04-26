using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public bool CheckCorrect()
        {
            bool correct = true;

            if (NumberInt != Int32.Parse(NumberString))
            {
                correct = false;
            }

            return correct;
        } 
    }
}
