﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAnalyzerWPF
{
    class Context
    {
        // Constructor
        public Context(string input)
        {
            Input = input;
        }

        public string Input { get; set; }
        public string Output { get; set; }

    }
}
