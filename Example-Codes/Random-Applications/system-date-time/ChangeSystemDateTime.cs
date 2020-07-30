using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ConsoleApp
{
    public class ChangeSystemDateTime
    {
        public static void RegisterApplication()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            reg.SetValue("DateTimeApp", System.Reflection.Assembly.GetExecutingAssembly().Location.ToString());
        }
        public static string GetDateTime()
        {
            try
            {
                var client = new TcpClient("time.nist.gov", 13);
                using (var streamReader = new StreamReader(client.GetStream()))
                {
                    var response = streamReader.ReadToEnd();
                    var utcDateTimeString = response.Substring(7, 17);
                    var localDateTime = DateTime.ParseExact(utcDateTimeString, "yy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                    return localDateTime.ToString();
                }
            }
            catch (Exception ex)
            {
                return "waiting response";//bad respond from api "time.nist.gov"
            }
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (client.OpenRead("http://google.com/generate_204"))
                    {
                        return true;
                    }
                }

            }
            catch
            {
                return false;
            }
        }
        public static void setDate(string dateInYourSystemFormat)//change date of system with giving paramater
        {
            var proc = new System.Diagnostics.ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = @"C:\Windows\System32";
            proc.CreateNoWindow = true;
            proc.FileName = @"C:\Windows\System32\cmd.exe";
            proc.Verb = "runas";
            proc.Arguments = "/C date " + dateInYourSystemFormat;
            try
            {
                System.Diagnostics.Process.Start(proc);
            }
            catch
            {
                Console.WriteLine("Error to change time of your system");
            }
        }
        public static void setTime(string timeInYourSystemFormat)//change time of system with giving paramater
        {
            var proc = new System.Diagnostics.ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = @"C:\Windows\System32";
            proc.CreateNoWindow = true;
            proc.FileName = @"C:\Windows\System32\cmd.exe";
            proc.Verb = "runas";
            proc.Arguments = "/C time " + timeInYourSystemFormat;
            try
            {
                System.Diagnostics.Process.Start(proc);
            }
            catch
            {
                Console.WriteLine("Error to change time of your system");
            }
        }
    }

}
