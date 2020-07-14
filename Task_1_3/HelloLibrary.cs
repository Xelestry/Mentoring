using System;
using System.Transactions;

namespace Task_1_3
{
    public static class HelloLibrary
    {
        public static string SayHello(string userName)
        {
            var currentTime = DateTime.Now;

            return $"{currentTime:HH:mm:ss} - Hello, {userName}!";
        }
    }
}
