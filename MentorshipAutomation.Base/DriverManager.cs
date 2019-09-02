using System;
using System.Collections.Generic;
using System.Threading;

namespace MentorshipAutomation.Base
{
    public static class DriverManager
    {
        private static readonly Dictionary<int, Driver> Instances = new Dictionary<int, Driver>();

        public static Driver Current
        {
            get
            {
                if (!Instances.ContainsKey(Thread.CurrentThread.ManagedThreadId))
                {
                    throw new Exception("Driver instance was not created");
                }

                return Instances[Thread.CurrentThread.ManagedThreadId];
            }
            set => Instances[Thread.CurrentThread.ManagedThreadId] = value;
        }
    }
}
