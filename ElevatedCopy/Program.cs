using System;
using System.Diagnostics;

namespace ElevatedCopy
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                var process = new Process();
                process.StartInfo.FileName = "cmd.exe";
                process.StartInfo.Arguments = "/c COPY \"" + args[0] + "\" \"" + args[1] + "\"";
                process.StartInfo.UseShellExecute = true;
                process.StartInfo.Verb = "runas";
                process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;

                process.Start();
            }
        }
    }
}
