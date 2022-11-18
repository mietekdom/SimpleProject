using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject01
{
    class PowerPointFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compressing PowerPoint");
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting...");
        }
    }
}
