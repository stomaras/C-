﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Logger : ILogger
    {
        // Low Level Module
        public void Log(string message)
        {
            Console.WriteLine($"Write to Console:  {message} ");
        }
    }
}
