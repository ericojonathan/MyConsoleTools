using System;

// Usage: using ct = ConsoleTools.Tools;

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

        public static void Write(string txt, object[] args) { Console.Write(txt, args); }

        public static void Write(string txt, object arg0) { Console.Write(txt, new object[] { arg0 }); }

        public static void Write(string txt, object arg0, object arg1) { Console.Write(txt, new object[] { arg0, arg1 }); }

        public static void Write(string txt, object arg0, object arg1, object arg2) { Console.Write(txt, new object[] { arg0, arg1, arg2 }); }

        public static void Write(string txt, object arg0, object arg1, object arg2, object arg3) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3 }); }

        public static void Write(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); }
        #endregion
        #region "Inputs"
        public static string Input(string txt) { Write(txt); return ReadLine(); }

        public static string Input(string txt, object[] args) { Write(txt, args); return ReadLine(); }

        public static string Input(string txt, object arg0) { Console.Write(txt, new object[] { arg0 }); return ReadLine(); }

        public static string Input(string txt, object arg0, object arg1) { Console.Write(txt, new object[] { arg0, arg1 }); return ReadLine(); }

        public static string Input(string txt, object arg0, object arg1, object arg2) { Console.Write(txt, new object[] { arg0, arg1, arg2 }); return ReadLine(); }

        public static string Input(string txt, object arg0, object arg1, object arg2, object arg3) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3 }); return ReadLine(); }

        public static string Input(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); return ReadLine(); }
        #endregion
        #endregion
        #region "Lines"
        #region "Input Lines"

        public static string InputLine(string txt) { WriteLine(txt); return ReadLine(); }

        public static string InputLine(string txt, object[] args) { Console.WriteLine(txt, new object[] { args }); return ReadLine(); }

        public static string InputLine(string txt, object arg0) { Console.WriteLine(txt, new object[] { arg0 }); return ReadLine(); }

        public static string InputLine(string txt, object arg0, object arg1) { Console.WriteLine(txt, new object[] { arg0, arg1 }); return ReadLine(); }

        public static string InputLine(string txt, object arg0, object arg1, object arg2) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2 }); return ReadLine(); }

        public static string InputLine(string txt, object arg0, object arg1, object arg2, object arg3) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3 }); return ReadLine(); }

        public static string InputLine(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); return ReadLine(); }

        #endregion
        #region "WriteLines"
        public static void WriteLine(string txt) { Console.WriteLine(txt); }

        public static void WriteLine(string txt, object[] args) { Console.WriteLine(txt, new object[] { args }); }

        public static void WriteLine(string txt, object arg0) { Console.WriteLine(txt, new object[] { arg0 }); }

        public static void WriteLine(string txt, object arg0, object arg1) { Console.WriteLine(txt, new object[] { arg0, arg1 }); }

        public static void WriteLine(string txt, object arg0, object arg1, object arg2) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2 }); }

        public static void WriteLine(string txt, object arg0, object arg1, object arg2, object arg3) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3 }); }

        public static void WriteLine(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); }

        #endregion

        public static string ReadLine() { return Console.ReadLine(); }

        #endregion
    }
}
