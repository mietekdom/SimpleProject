using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject01
{
    class WordDocumentFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compressing Word Document");
        }
        public void Print()
        {
            Console.WriteLine($"{FileName} printing....");
        }
    }
}
