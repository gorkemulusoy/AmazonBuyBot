using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace WebDriverScraping
{
    public class SeleniumTask
    {
        public void RTX3060()
        {
            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page
                string url = "https://www.amazon.com/s?k=rtx+3060+ti&i=electronics&rh=n%3A172282%2Cn%3A541966%2Cn%3A193870011%2Cn%3A17923671011%2Cn%3A284822%2Cp_n_date%3A1249033011%2Cp_6%3AATVPDKIKX0DER&s=price-desc-rank&dc&crid=2APE04RBG4DA4&qid=1610104740&rnid=303116011&sprefix=rtx+3060%2Caps%2C307%2Cp_6%3AATVPDKIKX0DER&ref=sr_st_price-desc-rank";
                driver.Navigate().GoToUrl(url);

                string bos = "Login Noktasi";

                while (true)
                {


                    // Get User Name field, Password field and Login Button
                    var yazi = driver.FindElements(By.XPath("//*[text()='No results for rtx 3600 ti in Computers']"));

                    if (yazi.Count == 0)
                    {
                        var foundList = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div/h2/a/span"));
                        var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rtx 3060 ti"));
                        if (foundElement == null)
                        {

                        }
                        else
                        {
                            var satici = driver.FindElement(By.ClassName("tabular-buybox-text"));
                            if (satici.Text != "Amazon.com")
                            {
                                driver.Navigate().GoToUrl(url);
                            }
                            else
                            {
                                foundElement.Click();
                                var buyButton = driver.FindElement(By.Id("buy-now-button"));
                                buyButton.Click();


                                //To wait for element visible
                                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-iframe")));
                                driver.SwitchTo().Frame("turbo-checkout-iframe");

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-pyo-button")));

                                var place = driver.FindElement(By.Id("turbo-checkout-pyo-button"));
                                place.Click();
                                Console.Beep(5352, 10000);
                                break;
                            }
                        }
                    }
                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(10000, 30000));
                    driver.Navigate().Refresh();
                }
            }
        }

        public void RTX3070()
        {
            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page

                string url = "https://www.amazon.com/s?k=rtx+3070&i=computers&rh=n%3A284822%2Cp_6%3AATVPDKIKX0DER%2Cp_n_feature_four_browse-bin%3A6066318011&s=price-desc-rank&dc&qid=1610298613&rnid=2057431011&ref=sr_nr_p_n_feature_four_browse-bin_2";

                driver.Navigate().GoToUrl(url);
                string bos = "Login Noktasi";
                while (true)
                {

                    // Get User Name field, Password field and Login Button
                    var yazi = driver.FindElements(By.XPath("//*[text()='No results for rtx 3070 in Computers']"));

                    if (yazi.Count == 0)
                    {
                        var foundList = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div/h2/a/span"));
                        var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rtx 3070"));
                        if (foundElement == null)
                        {

                        }
                        else
                        {
                            var satici = driver.FindElement(By.ClassName("tabular-buybox-text"));
                            if (satici.Text != "Amazon.com")
                            {
                                driver.Navigate().GoToUrl(url);
                            }
                            else
                            {
                                foundElement.Click();
                                var buyButton = driver.FindElement(By.Id("buy-now-button"));
                                buyButton.Click();


                                //To wait for element visible
                                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-iframe")));
                                driver.SwitchTo().Frame("turbo-checkout-iframe");

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-pyo-button")));

                                var place = driver.FindElement(By.Id("turbo-checkout-pyo-button"));
                                place.Click();
                                Console.Beep(5352, 10000);
                                break;
                            }
                        }
                    }

                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(10000, 30000));
                    driver.Navigate().Refresh();
                }
            }
        }


        public void RX5600()
        {
            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page
                string url = "https://www.amazon.com/s?k=rx+5600+xt&i=computers&bbn=284822&rh=n%3A284822%2Cp_6%3AATVPDKIKX0DER%2Cp_n_feature_four_browse-bin%3A6066317011&s=price-desc-rank&dc&qid=1610300756&rnid=2057431011&ref=sr_nr_p_n_feature_four_browse-bin_3";
                driver.Navigate().GoToUrl(url);
                string bos = "Login Noktasi";
                while (true)
                {

                    // Get User Name field, Password field and Login Button
                    var yazi = driver.FindElements(By.XPath("//*[text()='No results for rx 5600 xt in Computers']"));

                    if (yazi.Count == 0)
                    {
                        var foundList = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div/h2/a/span"));
                        var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rx 5600 xt"));
                        if (foundElement == null)
                        {

                        }
                        else
                        {
                            var satici = driver.FindElement(By.ClassName("tabular-buybox-text"));
                            if (satici.Text != "Amazon.com")
                            {
                                driver.Navigate().GoToUrl(url);
                            }
                            else
                            {
                                foundElement.Click();
                                var buyButton = driver.FindElement(By.Id("buy-now-button"));
                                buyButton.Click();


                                //To wait for element visible
                                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-iframe")));
                                driver.SwitchTo().Frame("turbo-checkout-iframe");

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-pyo-button")));

                                var place = driver.FindElement(By.Id("turbo-checkout-pyo-button"));
                                place.Click();
                                Console.Beep(5352, 10000);
                                break;
                            }
                        }
                    }

                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(10000, 30000));
                    driver.Navigate().Refresh();
                }
            }
        }


        public void RX5700()
        {
            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page

                string url = "https://www.amazon.com/s?k=rx+5700&i=computers&rh=n%3A284822%2Cp_6%3AATVPDKIKX0DER%2Cp_n_feature_four_browse-bin%3A6066318011&s=price-desc-rank&dc&qid=1610298613&rnid=2057431011&ref=sr_nr_p_n_feature_four_browse-bin_2";

                driver.Navigate().GoToUrl(url);
                string bos = "Login Noktasi";
                while (true)
                {


                    // Get User Name field, Password field and Login Button
                    var yazi = driver.FindElements(By.XPath("//*[text()='No results for rx 5700 in Computers']"));

                    if (yazi.Count == 0)
                    {
                        var foundList = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div/h2/a/span"));
                        var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rx 5700"));
                        if (foundElement == null)
                        {

                        }
                        else
                        {
                            var satici = driver.FindElement(By.ClassName("tabular-buybox-text"));
                            if (satici.Text != "Amazon.com")
                            {
                                driver.Navigate().GoToUrl(url);
                            }
                            else
                            {
                                foundElement.Click();
                                var buyButton = driver.FindElement(By.Id("buy-now-button"));
                                buyButton.Click();


                                //To wait for element visible
                                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-iframe")));
                                driver.SwitchTo().Frame("turbo-checkout-iframe");

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-pyo-button")));

                                var place = driver.FindElement(By.Id("turbo-checkout-pyo-button"));
                                place.Click();
                                Console.Beep(5352, 10000);
                                break;
                            }
                        }
                    }
                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(10000, 30000));
                    driver.Navigate().Refresh();
                }
            }
        }

        public void NewArrivals()
        {
            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page

                string url = "https://www.amazon.com/s?i=computers-intl-ship&bbn=16225007011&rh=n%3A16225007011%2Cn%3A193870011%2Cn%3A17923671011%2Cn%3A284822%2Cp_6%3AATVPDKIKX0DER%2Cp_n_availability%3A1248801011%2Cp_36%3A26800-110000&s=date-desc-rank&dc&qid=1612648531&rnid=386442011&ref=sr_nr_p_36_1";

                driver.Navigate().GoToUrl(url);
                Console.WriteLine("\nLütfen Amazona Login Olun Daha Sonra Devam Etmek için bir tuşa basın...");
                Console.ReadKey();
                Console.WriteLine("\nÜrün tarama başladı.");
                driver.Navigate().GoToUrl(url);
                while (true)
                {


                    // Get User Name field, Password field and Login Button
                    //var yazi = driver.FindElements(By.XPath("//*[text()='No results for rx 5700 in Computers']"));


                    var foundList = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div/h2/a/span"));
                    var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rx 5700") || x.Text.ToLower().Contains("rtx 3060") || x.Text.ToLower().Contains("rtx 3070") || x.Text.ToLower().Contains("rtx 3080") || x.Text.ToLower().Contains("rx 5600"));

                    //var Urunler = foundList.Select(x => x.Text).ToList();

                    if (foundElement == null)
                    {

                    }
                    else
                    {
                        try
                        {

                            foundElement.Click();

                            var satici = driver.FindElement(By.ClassName("tabular-buybox-text"));
                            if (satici.Text != "Amazon.com")
                            {
                                driver.Navigate().GoToUrl(url);
                            }
                            else
                            {

                                var buyButton = driver.FindElement(By.Id("buy-now-button"));
                                buyButton.Click();

                                Console.Beep(1352, 500);

                                //To wait for element visible
                                WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 15));

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-iframe")));
                                driver.SwitchTo().Frame("turbo-checkout-iframe");

                                wait.Until(ExpectedConditions.ElementIsVisible(By.Id("turbo-checkout-pyo-button")));

                                var place = driver.FindElement(By.Id("turbo-checkout-pyo-button"));
                                place.Click();
                                Console.Beep(5352, 5000);
                                break;
                            }
                        }
                        catch (Exception)
                        {
                            Console.Beep(1352, 5000);
                            driver.Navigate().GoToUrl(url);
                        }

                    }

                    Random rnd = new Random();
                    Thread.Sleep(rnd.Next(1500, 7000));
                    driver.Navigate().Refresh();
                }
            }
        }
        public void NewArrivalsTelegram1()
        {


            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page

                string urlCom = "https://www.amazon.com/s?i=computers-intl-ship&bbn=16225007011&rh=n%3A16225007011%2Cn%3A193870011%2Cn%3A17923671011%2Cn%3A284822%2Cp_6%3AATVPDKIKX0DER%2Cp_n_availability%3A1248801011%2Cp_36%3A26800-140000&s=date-desc-rank&dc&qid=1612648531&rnid=386442011&ref=sr_nr_p_36_1";
                string urlCoUk = "https://www.amazon.co.uk/s?k=Graphics+Cards&i=computers&rh=n%3A430500031%2Cp_36%3A25000-110000%2Cp_n_availability%3A419162031%2Cp_6%3AA3P5ROKL5A1OLE&s=date-desc-rank&dc&qid=1613341385&rnid=419151031&ref=sr_nr_p_6_6";
                string urlDE = "https://www.amazon.de/s?k=Graphics+Cards&i=computers&bbn=430161031&rh=n%3A430161031%2Cp_6%3AA3JWKAKR8XB7XF%7CA3OJWAJQNSBARP%2Cp_n_availability%3A419126031%2Cp_36%3A28000-110000&s=date-desc-rank&dc&language=en&qid=1613464266&rnid=419115031&ref=sr_nr_p_6_3";
                string urlFR = "https://www.amazon.fr/s?k=Cartes+graphiques&i=computers&bbn=430340031&rh=n:430340031,p_36:50000-,p_n_availability:437882031,p_6:A1X6FK5RDHNB96&s=date-desc-rank&dc=&_encoding=UTF8&c=ts&qid=1613027028&rnid=428393031&ts_id=430340031&ref=sr_nr_p_36_1&low-price=280&high-price=1100";
                string urlTR = "https://www.amazon.com.tr/s?i=computers&bbn=12601951031&rh=n%3A12601951031%2Cp_6%3AA1UNQM1SR2CHM%7CA3O5TP4R0OZYXZ%2Cp_n_availability%3A13136583031%2Cp_36%3A299000-1200000&s=date-desc-rank&dc&qid=1613888229&rnid=13736708031&ref=sr_nr_p_36_4";
                string urlIT = "https://www.amazon.it/s?i=computers&bbn=460090031&rh=n%3A460090031%2Cp_6%3AA11IL2PNWYJU7H%2Cp_36%3A28000-110000%2Cp_n_availability%3A490214031%2Cp_n_feature_seven_browse-bin%3A16067946031&s=date-desc-rank&dc&qid=1613070264&rnid=8321625031&ref=sr_nr_p_n_feature_seven_browse-bin_2";
                string urlES = "https://www.amazon.es/s?i=computers&bbn=937935031&rh=n%3A937935031%2Cp_36%3A28000-110000%2Cp_6%3AA1AT7YVPFBWXBL%2Cp_n_feature_seven_browse-bin%3A16069169031&s=date-desc-rank&dc&qid=1613158391&rnid=8179000031&ref=sr_nr_p_n_feature_seven_browse-bin_3";
                string urlJP = "https://www.amazon.co.jp/s?i=computers&bbn=2151901051&rh=n%3A2127209051%2Cn%3A2151901051%2Cn%3A2151911051%2Cp_6%3AAN1VRQENFRJN5&s=price-desc-rank&dc&language=en&qid=1618666705&rnid=2151901051&ref=sr_st_price-desc-rank";
                //SendTelegram("Ürün Tarama Başladı - " + urlCom);
                //SendTelegram("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegram("Ürün Tarama Başladı - " + urlDE);
                //SendTelegram("Ürün Tarama Başladı - " + urlFR);
                //SendTelegram("Ürün Tarama Başladı - " + urlIT);
                //SendTelegram("Ürün Tarama Başladı - " + urlES);

                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCom);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlDE);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlFR);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlIT);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlES);

                List<string> urlList = new List<string>() { urlJP };
                List<string> spam = new List<string>();
                int sayac = 0;
                while (true)
                {
                    try
                    {
                        sayac = sayac + 1;
                        if (sayac == 200)
                        {
                            spam.Clear();
                            sayac = 0;
                        }

                        foreach (var item in urlList)
                        {
                            driver.Navigate().GoToUrl(item);

                            var foundList = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div/h2/a/span"));
                            if (foundList.Count == 0)
                            {
                                foundList = driver.FindElements(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/span[3]/div[2]/div"));
                            }

                            //var element = foundList.FirstOrDefault();
                            var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rtx 3060") || x.Text.ToLower().Contains("rtx 3070") || x.Text.ToLower().Contains("rtx 3080"));
                            var foundElementAMD = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rx 5700") && !x.Text.ToLower().Contains("sonnet") || x.Text.ToLower().Contains("rx 5600") || x.Text.ToLower().Contains("rx6800") || x.Text.ToLower().Contains("rx5700") || x.Text.ToLower().Contains("rx5600") || x.Text.ToLower().Contains("rx 6800") || x.Text.ToLower().Contains("rx 6700"));
                            if (foundElement != null)
                            {
                                string urlText = foundElement.Text.ToString();
                                foundElement.Click();
                                string urlUrun = driver.Url;
                                string mesaj = urlText + " - " + urlUrun;
                                string spamText = urlText + " - " + item;
                                if (!spam.Contains(spamText))
                                {
                                    SendTelegram(mesaj);
                                    spam.Add(spamText);
                                }

                            }

                            if (foundElementAMD != null)
                            {
                                string urlText = foundElementAMD.Text.ToString();
                                foundElementAMD.Click();
                                string urlUrun = driver.Url;
                                string mesaj = urlText + " - " + urlUrun;
                                string spamText = urlText + " - " + item;
                                if (!spam.Contains(spamText))
                                {
                                    SendTelegramAMD(mesaj);
                                    spam.Add(spamText);
                                }

                            }





                            Random rnd = new Random();
                            Thread.Sleep(rnd.Next(1000, 5000));

                        }
                    }
                    catch (Exception)
                    {
                        driver.Navigate().GoToUrl(urlCom);
                    }

                }
            }
        }
        public void NewArrivalsTelegram2()
        {


            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page

                string urlCom = "https://www.amazon.com/s?i=computers-intl-ship&bbn=16225007011&rh=n%3A16225007011%2Cn%3A193870011%2Cn%3A17923671011%2Cn%3A284822%2Cp_6%3AATVPDKIKX0DER%2Cp_n_availability%3A1248801011%2Cp_36%3A26800-140000&s=date-desc-rank&dc&qid=1612648531&rnid=386442011&ref=sr_nr_p_36_1";
                string urlCoUk = "https://www.amazon.co.uk/s?k=Graphics+Cards&i=computers&rh=n%3A430500031%2Cp_36%3A25000-110000%2Cp_n_availability%3A419162031%2Cp_6%3AA3P5ROKL5A1OLE&s=date-desc-rank&dc&qid=1613341385&rnid=419151031&ref=sr_nr_p_6_6";
                string urlDE = "https://www.amazon.de/s?k=Graphics+Cards&i=computers&bbn=430161031&rh=n%3A430161031%2Cp_6%3AA3JWKAKR8XB7XF%7CA3OJWAJQNSBARP%2Cp_n_availability%3A419126031%2Cp_36%3A28000-110000&s=date-desc-rank&dc&language=en&qid=1613464266&rnid=419115031&ref=sr_nr_p_6_3";
                string urlFR = "https://www.amazon.fr/s?k=Cartes+graphiques&i=computers&bbn=430340031&rh=n:430340031,p_36:50000-,p_n_availability:437882031,p_6:A1X6FK5RDHNB96&s=date-desc-rank&dc=&_encoding=UTF8&c=ts&qid=1613027028&rnid=428393031&ts_id=430340031&ref=sr_nr_p_36_1&low-price=280&high-price=1100";
                string urlTR = "https://www.amazon.com.tr/s?i=computers&bbn=12601951031&rh=n%3A12601951031%2Cp_6%3AA1UNQM1SR2CHM%7CA3O5TP4R0OZYXZ%2Cp_n_availability%3A13136583031%2Cp_36%3A299000-1200000&s=date-desc-rank&dc&qid=1613888229&rnid=13736708031&ref=sr_nr_p_36_4";
                string urlIT = "https://www.amazon.it/s?i=computers&bbn=460090031&rh=n%3A460090031%2Cp_6%3AA11IL2PNWYJU7H%2Cp_36%3A28000-110000%2Cp_n_availability%3A490214031%2Cp_n_feature_seven_browse-bin%3A16067946031&s=date-desc-rank&dc&qid=1613070264&rnid=8321625031&ref=sr_nr_p_n_feature_seven_browse-bin_2";
                string urlES = "https://www.amazon.es/s?i=computers&bbn=937935031&rh=n%3A937935031%2Cp_36%3A28000-110000%2Cp_6%3AA1AT7YVPFBWXBL%2Cp_n_feature_seven_browse-bin%3A16069169031&s=date-desc-rank&dc&qid=1613158391&rnid=8179000031&ref=sr_nr_p_n_feature_seven_browse-bin_3";
                //SendTelegram("Ürün Tarama Başladı - " + urlCom);
                //SendTelegram("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegram("Ürün Tarama Başladı - " + urlDE);
                //SendTelegram("Ürün Tarama Başladı - " + urlFR);
                //SendTelegram("Ürün Tarama Başladı - " + urlIT);
                //SendTelegram("Ürün Tarama Başladı - " + urlES);

                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCom);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlDE);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlFR);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlIT);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlES);

                List<string> urlList = new List<string>() { urlTR, urlES, urlIT };
                List<string> spam = new List<string>();
                int sayac = 0;
                while (true)
                {
                    try
                    {
                        sayac = sayac + 1;
                        if (sayac == 200)
                        {
                            spam.Clear();
                            sayac = 0;
                        }

                        foreach (var item in urlList)
                        {
                            driver.Navigate().GoToUrl(item);

                            var foundList = driver.FindElements(By.XPath("//*[@id='search']/div[1]/div[2]/div/span[3]/div[2]/div/div/span/div/div/div[2]/div[2]/div/div[1]/div/div/div/h2/a/span"));
                            if (foundList.Count == 0)
                            {
                                foundList = driver.FindElements(By.XPath("/html/body/div[1]/div[2]/div[1]/div[2]/div/span[3]/div[2]/div"));
                            }

                            //var element = foundList.FirstOrDefault();
                            var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rtx 3060 ti") || x.Text.ToLower().Contains("rtx 3070") || x.Text.ToLower().Contains("rtx 3080"));
                            var foundElementAMD = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rx 5700") && !x.Text.ToLower().Contains("sonnet") || x.Text.ToLower().Contains("rx 5600") || x.Text.ToLower().Contains("rx6800") || x.Text.ToLower().Contains("rx5700") || x.Text.ToLower().Contains("rx5600") || x.Text.ToLower().Contains("rx 6800") || x.Text.ToLower().Contains("rx 6700"));
                            if (foundElement != null)
                            {
                                string urlText = foundElement.Text.ToString();
                                foundElement.Click();
                                string urlUrun = driver.Url;
                                string mesaj = urlText + " - " + urlUrun;
                                string spamText = urlText +" - " + item;
                                if (!spam.Contains(spamText))
                                {
                                    SendTelegram(mesaj);
                                    spam.Add(spamText);
                                }

                            }

                            if (foundElementAMD != null)
                            {
                                string urlText = foundElementAMD.Text.ToString();
                                foundElementAMD.Click();
                                string urlUrun = driver.Url;
                                string mesaj = urlText + " - " + urlUrun;
                                string spamText = urlText + " - " + item;
                                if (!spam.Contains(spamText))
                                {
                                    SendTelegramAMD(mesaj);
                                    spam.Add(spamText);
                                }

                            }





                            //Random rnd = new Random();
                            //Thread.Sleep(rnd.Next(0, 2000));

                        }
                    }
                    catch (Exception)
                    {
                        driver.Navigate().GoToUrl(urlCom);
                    }

                }
            }
        }
        public void WishList()
        {


            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page

                string url3060 = "https://www.amazon.com/hz/wishlist/genericItemsPage/1DCPV6WQLQDDO?ref_=wl_fv_le&viewType=grid";
                string url3070 = "https://www.amazon.com/hz/wishlist/genericItemsPage/3W3AF0E9E85S7?ref_=wl_fv_le&viewType=grid";
                string url3080 = "https://www.amazon.com/hz/wishlist/genericItemsPage/6GEW9TQ8VS1D?ref_=wl_fv_le";
                string urlAMD = "https://www.amazon.com/hz/wishlist/genericItemsPage/1MEEPZ24EENMC?ref_=wl_fv_le&viewType=list";
                string urlIT = "https://www.amazon.it/s?i=computers&bbn=460090031&rh=n%3A460090031%2Cp_6%3AA11IL2PNWYJU7H%2Cp_36%3A28000-110000%2Cp_n_availability%3A490214031%2Cp_n_feature_seven_browse-bin%3A16067946031&s=date-desc-rank&dc&qid=1613070264&rnid=8321625031&ref=sr_nr_p_n_feature_seven_browse-bin_2";
                string urlES = "https://www.amazon.es/s?i=computers&bbn=937935031&rh=n%3A937935031%2Cp_36%3A28000-110000%2Cp_6%3AA1AT7YVPFBWXBL%2Cp_n_feature_seven_browse-bin%3A16069169031&s=date-desc-rank&dc&qid=1613158391&rnid=8179000031&ref=sr_nr_p_n_feature_seven_browse-bin_3";
                //SendTelegram("Ürün Tarama Başladı - " + urlCom);
                //SendTelegram("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegram("Ürün Tarama Başladı - " + urlDE);
                //SendTelegram("Ürün Tarama Başladı - " + urlFR);
                //SendTelegram("Ürün Tarama Başladı - " + urlIT);
                //SendTelegram("Ürün Tarama Başladı - " + urlES);

                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCom);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlDE);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlFR);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlIT);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlES);

                List<string> urlList = new List<string>() { urlAMD, url3060, url3070, url3080/*, urlES, urlIT*/ };
                List<string> spam = new List<string>();
                int sayac = 0;
                while (true)
                {
                    sayac = sayac + 1;
                    if (sayac == 200)
                    {
                        spam.Clear();
                        sayac = 0;

                    }

                    foreach (var item in urlList)
                    {
                        driver.Navigate().GoToUrl(item);
                        Actions actions = new Actions(driver);


                        var foundList = driver.FindElements(By.XPath("/html/body/div[1]/div[2]/div/div/div/div/div/div[2]/div[7]/div/div/ul/li/span/div/div/div/div[2]/div[3]"));
                        //var foundList = driver.FindElements(By.ClassName("g-item-sortable"));

                        //var foundElement = foundList.FirstOrDefault();
                        var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("add to cart"));
                        //var clickElement = foundElement.FindElement(By.ClassName("a-list-item"));
                        //var foundElementAMD = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rx 5700") || x.Text.ToLower().Contains("rx 5600") || x.Text.ToLower().Contains("rx6800") || x.Text.ToLower().Contains("rx5700") || x.Text.ToLower().Contains("rx5600") || x.Text.ToLower().Contains("rx 6800") || x.Text.ToLower().Contains("rx 6700") || x.Text.ToLower().Contains("rtx3060"));
                        if (foundElement != null)
                        {
                            string urlText = foundElement.Text.ToString();
                            foundElement.Click();
                            //var clickElement = foundElement.FindElement(By.ClassName("a-price"));
                            //actions.MoveToElement(clickElement);
                            //actions.Perform();
                            //actions.Click();
                            string urlUrun = driver.Url;
                            string mesaj = urlText + " - " + urlUrun;
                            if (!spam.Contains(mesaj))
                            {
                                SendTelegram(mesaj);
                                spam.Add(mesaj);
                            }

                        }
                        else
                        {

                            //if (foundElementAMD != null)
                            //{
                            //    string urlText = foundElementAMD.Text.ToString();
                            //    foundElementAMD.Click();
                            //    string urlUrun = driver.Url;
                            //    string mesaj = urlText + " - " + urlUrun;
                            //    if (!spam.Contains(mesaj))
                            //    {
                            //        SendTelegramAMD(mesaj);
                            //        spam.Add(mesaj);
                            //    }

                            //}
                        }




                        //Random rnd = new Random();
                        //Thread.Sleep(rnd.Next(0, 2000));

                    }

                }
            }
        }
        public void WebMarket()
        {


            // Initialize the Chrome Driver
            using (var driver = new ChromeDriver())
            {
                // Go to the home page

                string url = "https://www.webmarket.com.tr/";
                driver.Navigate().GoToUrl(url);

                Console.WriteLine("Login ol");
                Console.ReadKey();
                url = "https://www.webmarket.com.tr/urun/urunler?c=108";
                //SendTelegram("Ürün Tarama Başladı - " + urlCom);
                //SendTelegram("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegram("Ürün Tarama Başladı - " + urlDE);
                //SendTelegram("Ürün Tarama Başladı - " + urlFR);
                //SendTelegram("Ürün Tarama Başladı - " + urlIT);
                //SendTelegram("Ürün Tarama Başladı - " + urlES);

                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCom);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlCoUk);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlDE);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlFR);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlIT);
                //SendTelegramAMD("Ürün Tarama Başladı - " + urlES);

                //List<string> urlList = new List<string>() { urlCom, urlCoUk, urlDE, urlFR, urlTR/*, urlES, urlIT*/ };
                List<string> spam = new List<string>();
                int sayac = 0;
                while (true)
                {
                    try
                    {

                        driver.Navigate().GoToUrl(url);
                        Random rnd = new Random();
                        Thread.Sleep(rnd.Next(10000, 30000));


                        sayac = sayac + 1;
                        if (sayac == 200)
                        {
                            spam.Clear();
                            sayac = 0;
                        }




                        var foundList = driver.FindElements(By.XPath("/html/body/form/div[5]/div[2]/div[2]/div[3]/div[4]/div"));


                        //var element = foundList.FirstOrDefault();
                        var foundElement = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rtx 3060") || x.Text.ToLower().Contains("rtx 3070") || x.Text.ToLower().Contains("rtx3070") || x.Text.ToLower().Contains("rtx 3080") || x.Text.ToLower().Contains("rtx3060") || x.Text.ToLower().Contains("rtx3080") || x.Text.ToLower().Contains("gtx1660") || x.Text.ToLower().Contains("gtx 1660"));
                        var foundElementAMD = foundList.FirstOrDefault(x => x.Text.ToLower().Contains("rx 5700") || x.Text.ToLower().Contains("rx 5600") || x.Text.ToLower().Contains("rx 6800") || x.Text.ToLower().Contains("rx 6700") || x.Text.ToLower().Contains("rtx3060") || x.Text.ToLower().Contains("rx5700") || x.Text.ToLower().Contains("rx5600") || x.Text.ToLower().Contains("rx6800") || x.Text.ToLower().Contains("rx-5700") || x.Text.ToLower().Contains("rx-5600") || x.Text.ToLower().Contains("rx-580") || x.Text.ToLower().Contains("rx 580") || x.Text.ToLower().Contains("rx 580"));
                        if (foundElement != null)
                        {
                            string urlText = foundElement.Text.ToString();
                            //foundElement.Click();
                            //string urlUrun = driver.Url;
                            string mesaj = "WebMarket " + urlText;
                            if (!spam.Contains(mesaj))
                            {
                                SendTelegram(mesaj);
                                spam.Add(mesaj);
                            }

                        }

                        if (foundElementAMD != null)
                        {
                            string urlText = foundElementAMD.Text.ToString();
                            //foundElementAMD.Click();
                            //string urlUrun = driver.Url;
                            string mesaj = "WebMarket ";
                            if (!spam.Contains(mesaj))
                            {
                                SendTelegramAMD(mesaj);
                                spam.Add(mesaj);
                            }

                        }




                    }
                    catch (Exception)
                    {
                        driver.Navigate().GoToUrl(url);
                    }

                }
            }
        }

        private void SendTelegram(string link)
        {
            string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
            using (var client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string apiToken = "1652961606:AAERJHRoV3XRBOcmQrtAFwM5HfdXCR1MWwg";
                string chatId = "@AmazonMalBotCHN";
                //string text = "Test message";

                urlString = String.Format(urlString, apiToken, chatId, link);


                string html = client.DownloadString(urlString);
            }

            //string apiToken = "1652961606:AAERJHRoV3XRBOcmQrtAFwM5HfdXCR1MWwg";
            //string chatId = "@AmazonMalBotCHN";
            //string text = "Test message";

            //urlString = String.Format(urlString, apiToken, chatId, text);
            //WebRequest request = WebRequest.Create(urlString);
            //Stream rs = request.GetResponse().GetResponseStream();

            //StreamReader reader = new StreamReader(rs);
            //string line = "";
            //StringBuilder sb = new StringBuilder();
            //while (line != null)
            //{
            //    line = reader.ReadLine();
            //    if (line != null)
            //        sb.Append(line);
            //}
            //string response = sb.ToString();

        }


        private void SendTelegramAMD(string link)
        {
            string urlString = "https://api.telegram.org/bot{0}/sendMessage?chat_id={1}&text={2}";
            using (var client = new WebClient())
            {
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                string apiToken = "1594616139:AAEMPpWLk5e-mEQIkjrpscyKcCdlRoHvbFk";
                string chatId = "@amazonamdbotchn";
                //string text = "Test message";

                urlString = String.Format(urlString, apiToken, chatId, link);


                string html = client.DownloadString(urlString);
            }

            //string apiToken = "1652961606:AAERJHRoV3XRBOcmQrtAFwM5HfdXCR1MWwg";
            //string chatId = "@AmazonMalBotCHN";
            //string text = "Test message";

            //urlString = String.Format(urlString, apiToken, chatId, text);
            //WebRequest request = WebRequest.Create(urlString);
            //Stream rs = request.GetResponse().GetResponseStream();

            //StreamReader reader = new StreamReader(rs);
            //string line = "";
            //StringBuilder sb = new StringBuilder();
            //while (line != null)
            //{
            //    line = reader.ReadLine();
            //    if (line != null)
            //        sb.Append(line);
            //}
            //string response = sb.ToString();

        }
    }
}
