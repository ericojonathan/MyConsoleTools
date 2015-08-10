using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinConsole
{
    public class ConsoleTool
    {
        static bool IsTextNullOrEmptyOrWhitespaces(string txt)
        {
            if (string.IsNullOrEmpty(txt) || string.IsNullOrWhiteSpace(txt)) return true;
            else return false;
        }
        #region "Line"
        #region "Write"
        static void Write(string txt) { Console.Write(txt); }

        static void Write(string txt, object[] args) { Console.Write(txt, args); }

        static void Write(string txt, object arg0) { Console.Write(txt, new object[] { arg0 }); }

        static void Write(string txt, object arg0, object arg1) { Console.Write(txt, new object[] { arg0, arg1 }); }

        static void Write(string txt, object arg0, object arg1, object arg2) { Console.Write(txt, new object[] { arg0, arg1, arg2 }); }

        static void Write(string txt, object arg0, object arg1, object arg2, object arg3) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3 }); }

        static void Write(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); }
        #endregion
        #region "Inputs"
        static string Input(string txt) { Write(txt); return ReadLine(); }

        static string Input(string txt, object[] args) { Write(txt, args); return ReadLine(); }

        static string Input(string txt, object arg0) { Console.Write(txt, new object[] { arg0 }); return ReadLine(); }

        static string Input(string txt, object arg0, object arg1) { Console.Write(txt, new object[] { arg0, arg1 }); return ReadLine(); }

        static string Input(string txt, object arg0, object arg1, object arg2) { Console.Write(txt, new object[] { arg0, arg1, arg2 }); return ReadLine(); }

        static string Input(string txt, object arg0, object arg1, object arg2, object arg3) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3 }); return ReadLine(); }

        static string Input(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.Write(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); return ReadLine(); }
        #endregion
        #endregion
        #region "Lines"
        #region "Input Lines"

        static string InputLine(string txt) { WriteLine(txt); return ReadLine(); }

        static string InputLine(string txt, object[] args) { Console.WriteLine(txt, new object[] { args }); return ReadLine(); }

        static string InputLine(string txt, object arg0) { Console.WriteLine(txt, new object[] { arg0 }); return ReadLine(); }

        static string InputLine(string txt, object arg0, object arg1) { Console.WriteLine(txt, new object[] { arg0, arg1 }); return ReadLine(); }

        static string InputLine(string txt, object arg0, object arg1, object arg2) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2 }); return ReadLine(); }

        static string InputLine(string txt, object arg0, object arg1, object arg2, object arg3) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3 }); return ReadLine(); }

        static string InputLine(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); return ReadLine(); }

        #endregion
        #region "WriteLines"
        static void WriteLine(string txt) { Console.WriteLine(txt); }

        static void WriteLine(string txt, object[] args) { Console.WriteLine(txt, new object[] { args }); }

        static void WriteLine(string txt, object arg0) { Console.WriteLine(txt, new object[] { arg0 }); }

        static void WriteLine(string txt, object arg0, object arg1) { Console.WriteLine(txt, new object[] { arg0, arg1 }); }

        static void WriteLine(string txt, object arg0, object arg1, object arg2) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2 }); }

        static void WriteLine(string txt, object arg0, object arg1, object arg2, object arg3) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3 }); }

        static void WriteLine(string txt, object arg0, object arg1, object arg2, object arg3, object arg4) { Console.WriteLine(txt, new object[] { arg0, arg1, arg2, arg3, arg4 }); }

        #endregion

        static string ReadLine() { return Console.ReadLine(); }

        #endregion
    }
}
