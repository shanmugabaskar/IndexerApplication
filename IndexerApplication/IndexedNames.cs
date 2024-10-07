using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerApplication
{
    internal class IndexedNames
    {
        private readonly string[] enamellist = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int i = 0; i < size; i++)
                enamellist[i] = "N. A.";
        }
        public string this[int index]
        {
            get
            {
                string tmp;

                if (index >= 0 && index <= size - 1)
                {
                    tmp = enamellist[index];
                }
                else
                {
                    tmp = "";
                }

                return (tmp);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    enamellist[index] = value;
                }
            }
        }
    }
}
