using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Typing_with_all_ten_fingers
{
    class Files
    {
        private string fileName;
        private string[] rows;
        public int CountRows { get; private set; }

        public Files(string fileName)
        {
            this.fileName = fileName;
        }

        public void ReadAllRows()
        {
            rows = File.ReadAllLines(fileName);
            CountRows = rows.Length;
        }

        public string GetWordByIndex(int index)
        {
            if (rows != null && rows.Length > index && index >= 0)
                return rows[index];

            throw new ArgumentException("Neplatný index!");
        }
    }
}
