using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using WebDriverScraping;

namespace WebDriverTest
{
    class Program
    {
        static void Main(string[] args)
        {

            SeleniumTask st = new SeleniumTask();

            //Thread newThread = new Thread(st.StartTask);
            //newThread.Start();

            //Thread newThread2 = new Thread(st.StartTask);
            //newThread.Start();

            //Task task1 = Task.Factory.StartNew(() => st.RTX3060());
            //Task task2 = Task.Factory.StartNew(() => st.RTX3070());
            //Task task3 = Task.Factory.StartNew(() => st.RX5600());
            //Task task4 = Task.Factory.StartNew(() => st.RX5700());
            //Task task5 = Task.Factory.StartNew(() => st.NewArrivals());
            Task task6 = Task.Factory.StartNew(() => st.NewArrivalsTelegram1());
            //Task task7 = Task.Factory.StartNew(() => st.NewArrivalsTelegram2());
            //Task task7 = Task.Factory.StartNew(() => st.WishList());
            //Task task8 = Task.Factory.StartNew(() => st.WebMarket());
            

            
            Task.WaitAll(/*task1, task2, task3, task4, task6*/task6/*, task7*/ /*task8*/);
            //task1.Dispose();
            //task2.Dispose();
            //task3.Dispose();
            //task4.Dispose();
            //task6.Dispose();
            task6.Dispose();
            //task7.Dispose();
            //task8.Dispose();
            bool done = true;
        }

        
    }
}
