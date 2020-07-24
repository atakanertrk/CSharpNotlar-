using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp;
using System.IO;
using System.Net;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Data;
using System.Net.Sockets;
using System.Globalization;
using Microsoft.Win32;
using static System.Net.Mime.MediaTypeNames;
using static ConsoleApp.ChangeSystemDateTime;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            RegisterApplication(); // adding system registry for see the application in program manager and start application on windows startup (kayıt defteri düzenleyicisi)
            ProcessProgramChangeSystemDateTime();
            Console.ReadLine();
        }
        

        private static void ProcessProgramChangeSystemDateTime()
        {
            if (CheckForInternetConnection() == true)
            {
                var response = GetDateTime();
                if(response == "waiting response")//api doesnt respond
                {
                    Console.WriteLine("couldnt get date from internet. No response from api");
                    Console.WriteLine("try few more times or try later");
                    Console.WriteLine("press enter to retry");
                    Console.ReadLine();
                    Console.Clear();
                    ProcessProgramChangeSystemDateTime();
                }
                else//api responds as expected
                {
                    //this else block seperates "datetime" to "date" and "time". Than calls setTime() and setDate() methods
                    string date = "";
                    string time = "";
                    int count = 0;
                    foreach (char c in response)
                    {
                        if (c == ' ')
                        {
                            break;
                        }
                        date += c;
                    }
                    string longtime = response.Substring(response.IndexOf(' ') + 1);
                    foreach (char c in longtime)
                    {
                        if (c == ':')
                        {
                            count += 1;
                        }
                        if (count == 2)
                        {
                            break;
                        }
                        time += c;
                    }
                    Console.WriteLine($"Updating System Date and Time");
                    Console.WriteLine("please wait");
                    System.Threading.Thread.Sleep(5000);//wait 5 second
                    setDate(date); //changes system date
                    System.Threading.Thread.Sleep(5000);//wait 5 second
                    setTime(time); //changes system time
                    System.Threading.Thread.Sleep(2000);//wait 2 second
                    Console.WriteLine("all done!!");
                    Console.WriteLine($"your system date: {date} and time: {time}");
                    Console.WriteLine("press enter to close the application");
                }
            }
            else
            {
                Console.WriteLine("you must connect to internet");
                Console.WriteLine("press enter for try again");
                Console.ReadLine();
                Console.Clear();
                ProcessProgramChangeSystemDateTime();
            }
            
        }

    }
}
