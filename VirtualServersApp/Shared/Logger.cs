using System;

namespace VirtualServersApp.Shared {

    public static class Logger {

        public static void Write (string message) {
            Console.WriteLine (DateTime.Now.ToString ("yyyy/MM/dd HH:mm:ss:fff"));
            Console.WriteLine (message);
        }
    }
}