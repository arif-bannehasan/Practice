﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityContainerExample
{
    public class Logger : UnityContainerExample.ILogger
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }
    }
}
