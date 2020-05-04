using System;
using System.Collections.Generic;
using System.Text;                      // INTERFACE İLE FARKLI VERİTABANLARI İÇİN EKLEME SİLME VS İŞLEMLERİ YAPABİLİRİZ.
                    //BU İŞLEMLERİ YAPMAK İÇİN EKLEME SİLME İŞLEMLERİNİ ICustomerDal'a YAZIP IMPLAMENT EDİYORUM
namespace interfaces
{
    interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }
        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }
        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }
        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }
        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }
    
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}


//****************************************ANA PROGRAMIMIZA GELDİĞİMİZDE*************************************************



    class Program
    {

        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FistName = "atakan",
                LastName = "ertürk"
            };

            customerManager.Add(new ...());   // ARTIK EKLEMEK İÇİN Add(new ..) yazdığımda bana iki seçenek sunar
                                // ORACLE SQL Mİ EKLEYEYEİM SQL SERVER'A MI EKLEYEYİM DİYE. BU ŞEKİLDE BİRDEN ÇOK 
                                    //                                                     DATABASE UYUMLU ÇALIŞABİLİRİZ...
            manager.Add(customer);

        }
    }
                  // AYRICA BİZ BURDA INTERFACE IMPLAMENT EDEREK POLYMORPHISM DE UYGULAMIŞ OLDUK
