﻿using System;

namespace NinjectInjectsDependenciesForUs.Logging
{
    public class Logging : ILogging
    {
        public void Debug(string message)
        {
            Console.WriteLine("Debug: [{0}]", message);
        }
    }
}
