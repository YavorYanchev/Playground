﻿using System;

namespace NinjectInjectsDependenciesForUs.Logging
{
    public class MockLogging : ILogging
    {
        public void Debug(string message)
        {
            Console.WriteLine("Mock Debug: [{0}]", message);
        }
    }
}
