using System;

// Usage: using ct = ConsoleTools.Tool;

namespace ConsoleTools
{

    public class ConsoleTool
    {
        public static bool IsTextNullOrEmptyOrWhitespaces(string txt)
        {
            if (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt)) return true;
            else return false;
        }

        #region "Line"
        #region "Write"
        public static void Write(string txt) { Console.Write(txt); }

        public static void Write(string txt, param object[] args) { Console.Write(txt, args); }
        #endregion

        #region "Inputs"
        
        public static string Input(string txt) { Write(txt); return ReadLine(); }

        public static string Input(string txt, param object[] args) { Write(txt, args); return ReadLine(); }

        #endregion

        #endregion
        #region "Lines"
        #region "Input Lines"

        public static string InputLine(string txt) { WriteLine(txt); return ReadLine(); }

        public static string InputLine(string txt, param object[] args) { Console.WriteLine(txt, new object[] { args }); return ReadLine(); }

        #endregion
        #region "WriteLines"
        public static void WriteLine(string txt) { Console.WriteLine(txt); }

        public static void WriteLine(string txt, param object[] args) { Console.WriteLine(txt,  args);} 

        #endregion

        public static string ReadLine() { return Console.ReadLine(); }

        #endregion
    }
}
