﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleProject01
{
    interface IFile
    {
        string FileName { get; set; }
        int Size { get; set; }
        DateTime CreatedOn { get; set; }
        void Compress();
    }
}
