using System;
using static System.Console;

namespace SJCNet.DesignPatterns.Shared.Utility.Old
{
    public static class Logger
    {
        private const int SymbolCount = 40;
        private const char HeaderSymbol = '#';
        private const char SubHeaderSymbol = '-';

        public static void WriteStart(string message)
        {
            WriteLine(new string(HeaderSymbol, SymbolCount));
            Write(message);
            WriteLine(new string(HeaderSymbol, SymbolCount));
        }

        public static void WriteEnd(string message)
        {
            AddLineBreak();
            WriteLine(new string(HeaderSymbol, SymbolCount));
            Write(message);
            WriteLine(new string(HeaderSymbol, SymbolCount));
        }

        public static void WriteHeader(string heading)
        {
            AddLineBreak();
            Write(heading);
            WriteLine(new string(HeaderSymbol, SymbolCount));
        }

        public static void WriteFooter(string footer)
        {
            AddLineBreak();
            Write(footer);
            WriteLine(new string(HeaderSymbol, SymbolCount));
        }

        public static void WriteSubHeader(string message)
        {
            AddLineBreak();
            WriteLine(message);
            WriteLine(new string(SubHeaderSymbol, SymbolCount));
        }

        public static void Write(string message)
        {
            WriteLine($"{DateTime.Now.ToShortDateString()} {DateTime.Now.ToShortTimeString()}: {message}");
        }

        public static void AddLineBreak()
        {
            WriteLine(string.Empty);
        }
    }
}
