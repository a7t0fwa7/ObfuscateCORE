using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ObfuscateCORE.Helpers
{
    internal class URL
    {
        internal static string ObfsIP(string ip)
        {
            string[] arr1 = ip.Split('.');

            string partIP00 = arr1[0];
            string partIP11 = arr1[1];
            string partIP22 = arr1[2];
            string partIP33 = arr1[3];

            string out11 = Convert.ToByte(partIP00).ToString("x2");
            string out22 = Convert.ToByte(partIP11).ToString("x2");
            string out33 = Convert.ToByte(partIP22).ToString("x2");
            string out44 = Convert.ToByte(partIP33).ToString("x2");
            string output1 = $"http://0x{out11}.0x{out22}.0x{out33}.0x{out44}";

            MessageBox.Show("[+] Obfuscated IP: " + output1);
            return output1;
        }

        internal static string ObfsURL(string url)
        {
            Uri myUri = new Uri(url);

            var ip = Dns.GetHostAddresses(myUri.Host)[0];
            string ip1 = ip.ToString();
            MessageBox.Show("[+] IP: " + ip1);
            string[] arr = ip1.Split('.');

            string partIP = arr[0];
            string partIP1 = arr[1];
            string partIP2 = arr[2];
            string partIP3 = arr[3];

            string out1 = Convert.ToByte(partIP).ToString("x2");
            string out2 = Convert.ToByte(partIP1).ToString("x2");
            string out3 = Convert.ToByte(partIP2).ToString("x2");
            string out4 = Convert.ToByte(partIP3).ToString("x2");
            string output = $"http://0x{out1}.0x{out2}.0x{out3}.0x{out4}";
             MessageBox.Show("[+] Obfuscated IP: " + output);
            return output;

        }
    }
}
