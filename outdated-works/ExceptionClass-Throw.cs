//***********************************************RecordNotFoundException Class'ı*****************************************
using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    public class RecordNotFoundException:Exception
    {
        public RecordNotFoundException(string message):base(message)
        {

        }
    }
}

//************************************************ANA PROGRAM*********************************************************
using System;
using System.Collections.Generic;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();
            try
            {
                Find();
            }
            catch(RecordNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }
            
            Console.ReadLine();
        }

        //private static void ExceptionIntro()
        //{
        //    try
        //    {
        //        string[] students = new string[3] { "engin", "derin", "salih" };
        //        students[3] = "ahmet";
        //    }
        //    catch(IndexOutOfRangeException exception)
        //    {
        //        Console.WriteLine(exception.Message);
        //    }
        //}
        private static void Find()
        {
            List<string> students = new List<string> { "engin", "derin", "salih" };
            if (!students.Contains("ahmet"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("record found");
            }
        }
        
    }

}

