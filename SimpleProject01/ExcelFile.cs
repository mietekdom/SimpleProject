using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject01
{
    class ExcelFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compressing Excell File");
        }
        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report....");
        }
    }

}
