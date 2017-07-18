﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();

            tea.prepare();

            System.Console.ReadKey();
        }
    }
}
