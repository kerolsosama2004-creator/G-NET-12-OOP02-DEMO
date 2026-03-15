using System;
using System.Collections.Generic;
using System.Text;

namespace G_NET_12_OOP02_DEMO
{
    internal static class Counter
    {
        //public int X;//invalid
        // public Counter()
        //{

        //}
        //-------
        static Counter()
        {
            _Count = 0;
        }
        private static int _Count = 0;

        public static void Increment() => _Count++;
        public static void Decrement() => _Count--;
        public static void Reset() => _Count = 0;
        public static int GetCount() => _Count;
    }
}
