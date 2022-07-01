using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ObfuscateCORE.Helpers
{
    class Batch
    {
        private static Random random = new Random();

        public static String JunkString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ ";
            return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        internal static void EncryptBatch(string code)
        {
            SaveFileDialog saver = new SaveFileDialog();
            saver.InitialDirectory = "C:\\Users\\" + Environment.UserName;
            saver.RestoreDirectory = true;
            saver.DefaultExt = ".bat";
            saver.ShowDialog();
            string bruh = code = string.Concat(code.Select(x => Char.IsLetterOrDigit(x) ? "%" + JunkString(6) + "%" + x : x.ToString())).TrimStart();
            string name = JunkString(3);
            File.WriteAllText(saver.FileName, code);
            MessageBox.Show("[+] File Obfuscated Successfully!" + Environment.NewLine + saver.FileName);
        }
    }
}
