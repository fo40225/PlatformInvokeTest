namespace PlatformInvokeTest
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using System.Runtime.InteropServices;

    internal class Program
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int puts(string c);

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        internal static extern int _flushall();

        private static void Main(string[] args)

        {
            puts("hello, P/Invoke");
            _flushall();
        }
    }
}
