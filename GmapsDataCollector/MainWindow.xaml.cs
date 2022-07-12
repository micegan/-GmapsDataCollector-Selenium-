using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using System.Net;
using System.Web;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Collections.ObjectModel;
using System.Xml;
using System.Windows.Markup;
using OpenQA.Selenium.Support.UI;


namespace ddddd
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int numm = 0;
        public static T CloneXaml<T>(T source, string Typed, string Namet, string Adres, string Open, string Phonenumber, string Ratings, string Webpage, string Imageurl)
        {

            string xaml = XamlWriter.Save(source).Replace(">№<", ">" + elcount.ToString().Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "") + "<").Replace(">Ratings<", ">" + Ratings.ToString() + "<").Replace(">Phone number<", ">" + Phonenumber.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "") + "<").Replace(">Web page<", ">" + Webpage.ToString() + "<").Replace(">Name<", ">" + Namet.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "") + "<").Replace(">Type<", ">" + Typed.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "") + "<").Replace(">Adres<", ">" + Adres.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "") + "<").Replace(">Open<", ">" + Open.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "") + "<");



            StringReader sr = new StringReader(xaml);

            XmlReader xr = XmlReader.Create(sr);
            return (T)XamlReader.Load(xr);
        }

        public static string url = "";
        public static int howm = 0;
        public static int howmuch = 1;
        public static List<string> list = new List<string>();
        public static string lasturl = "";

        public static IWebDriver otherinfo;

        public static IWebDriver driver;




        public static System.Windows.Forms.Timer timerdc = new System.Windows.Forms.Timer();

        public static System.Windows.Forms.Timer timerdd = new System.Windows.Forms.Timer();

        public static System.Windows.Forms.Timer timerdrd = new System.Windows.Forms.Timer();


        public static System.Windows.Forms.Timer timerd = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer timeraltd = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer timerdll = new System.Windows.Forms.Timer();
        public static System.Windows.Forms.Timer timexrdll = new System.Windows.Forms.Timer();




        public static bool stopped = false;
        public static List<string> typelist = new List<string>();
        public static List<string> namelist = new List<string>();
        public static List<string> openlist = new List<string>();
        public static List<string> adreslist = new List<string>();


        public static List<string> urllist = new List<string>();


        public static List<ListBoxItem> itemlist = new List<ListBoxItem>();

        public static bool enable = false;
        public static string lil = "";
        public static string sitee = "";
        public static int elcount = 0;
        public static int lastct = 0;
        public static string lastur = "";
        public static string lastur5 = "";
        public static bool isn = false;
        public static string kurl = "";
        public MainWindow()
        {

            InitializeComponent();
            //180 to 180 coords loop


  


            // FirefoxDriverService driverd = FirefoxDriverService.CreateDefaultService(Directory.GetCurrentDirectory().ToString(), "geckodriver.exe");


            //   if (File.Exists(@"C:\Program Files (x86)\Mozilla Firefox\firefox.exe"))
            //   {
            //       driverd.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
            //  }
            //  else if (File.Exists(@"C:\Program Files\Mozilla Firefox\firefox.exe"))
            //  {
            //      driverd.FirefoxBinaryPath = @"C:\Program Files\Mozilla Firefox\firefox.exe";
            //  }



            IWebDriver driverf = new ChromeDriver(Directory.GetCurrentDirectory().ToString());





            driver = driverf;

            driver.Navigate().GoToUrl("https://www.google.com/maps/search/");





            IWebDriver otherinfof = new ChromeDriver(Directory.GetCurrentDirectory().ToString());
            otherinfof.Navigate().GoToUrl("https://www.google.com/maps/search/");


            otherinfo = otherinfof;


            timerdc.Interval = 1000;

            timerdll.Interval = 7500;


            timexrdll.Interval = 4000;



            timerdc.Start();

            timerdc.Tick += (ed, od) =>
            {
                if (stopped != false)
                {
                    timerdc.Stop();
                    timerdd.Stop();
                    timerdrd.Stop();
                    timeraltd.Stop();
                    timerdll.Stop();
                    timexrdll.Stop();
                }
                if (lastur != lil && lil != String.Empty)
                    {
                        lastur = lil;
                        otherinfo.Navigate().GoToUrl(lil);


                        timerdll.Start();
                    if (stopped != false)
                    {
                        timerdc.Stop();
                        timerdd.Stop();
                        timerdrd.Stop();
                        timeraltd.Stop();
                        timerdll.Stop();
                        timexrdll.Stop();
                    }
                    timerdc.Stop();
                        timerdll.Tick += (edccc, odccc) =>
                        {
                           
                                if (stopped != false)
                                {
                               
                                timerdc.Stop();
                                    timerdd.Stop();
                                    timerdrd.Stop();
                                timeraltd.Stop();
                                    timerdll.Stop();
                                    timexrdll.Stop();
                                }
                                IJavaScriptExecutor js;

                                js = (IJavaScriptExecutor)otherinfo;


                                // later on...
                                string strrr = (string)js.ExecuteScript("if (document.getElementsByClassName('RcCsl fVHpi w4vB1d NOE9ve M0S7ae AG25L')[0] != undefined) { var txt = 'complete'; return txt;}");
                           
                                if (strrr == "complete")
                                {

                                    timerdll.Stop();
                                    if (elcount < typelist.Count)
                                    {

                                    if (stopped != false)
                                    {
                                      
                                        timerdc.Stop();
                                        timerdd.Stop();
                                        timerdrd.Stop();
                                        timeraltd.Stop();
                                        timerdll.Stop();
                                        timexrdll.Stop();
                                    }

                                    if (stopped != false)
                                    {
                                        
                                        timerdc.Stop();
                                        timerdd.Stop();
                                        timerdrd.Stop();
                                        timeraltd.Stop();
                                        timerdll.Stop();
                                        timexrdll.Stop();
                                    }
                                    elcount = elcount + 1;
                                        if (otherinfo.FindElements(By.XPath("//div[@class='RcCsl fVHpi w4vB1d NOE9ve M0S7ae AG25L']")).Count >= 4)
                                        {
                                            sitee = otherinfo.FindElements(By.XPath("//div[@class='RcCsl fVHpi w4vB1d NOE9ve M0S7ae AG25L']"))[3].Text;
                                        }
                                        // var teletelephone = otherinfo.FindElements(By.XPath("//div[@class='QSFF4-text gm2-body-2']"))[2].Text;
                                        var teletelephone = "";


                                        if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 4)
                                        {
                                            if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[3].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[3].GetAttribute("aria-label").Contains("Phone"))
                                            {
                                                teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[3].Text;
                                            }
                                            else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[1].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[1].GetAttribute("aria-label").Contains("Phone"))
                                            {
                                                teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[1].Text;
                                            }
                                            else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[2].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[2].GetAttribute("aria-label").Contains("Phone"))
                                            {
                                                teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[2].Text;
                                            }
                                            else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 5 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[4].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[4].GetAttribute("aria-label").Contains("Phone"))
                                            {
                                                teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[4].Text;
                                            }
                                            else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 6 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[5].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[5].GetAttribute("aria-label").Contains("Phone"))
                                            {
                                                teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[5].Text;
                                            }
                                            else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 7 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[6].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[6].GetAttribute("aria-label").Contains("Phone"))
                                            {
                                                teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[6].Text;
                                            }
                                            else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 8 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[7].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[7].GetAttribute("aria-label").Contains("Phone"))
                                            {
                                                teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[7].Text;
                                            }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 9 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[8].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[8].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[8].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 10 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[9].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[9].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[9].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 11 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[10].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[10].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[10].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 12 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[11].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[11].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[11].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 13 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[12].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[12].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[12].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 14 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[13].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[13].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[13].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 15 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[14].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[14].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[14].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 16 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[15].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[15].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[15].Text;
                                        }
                                        else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 17 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[16].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[16].GetAttribute("aria-label").Contains("Phone"))
                                        {
                                            teletelephone = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[16].Text;
                                        }
                                    }

                                        var ratings = "";

                                        var ptype = typelist[elcount - 1];
                                        if (otherinfo.FindElements(By.XPath("//button[@class='Yr7JMd-pane-hSRGPd']"))[0].Text.Contains("reviews"))
                                        {
                                            if (otherinfo.FindElements(By.XPath("//button[@class='Yr7JMd-pane-hSRGPd']")).Count != 0)
                                            {
                                                ratings = otherinfo.FindElements(By.XPath("//button[@class='Yr7JMd-pane-hSRGPd']"))[0].Text + " , " + otherinfo.FindElements(By.XPath("//span[@class='aMPvhf-fI6EEc-KVuj8d']"))[0].Text;
                                            }
                                        }
                                        else
                                        {
                                            if (otherinfo.FindElements(By.XPath("//span[@class='aMPvhf-fI6EEc-KVuj8']")).Count > 0)
                                            {
                                                ratings = otherinfo.FindElements(By.XPath("//span[@class='aMPvhf-fI6EEc-KVuj8d']"))[0].Text;
                                            }
                                            else
                                            {

                                                ratings = "";
                                            }
                                        }
                                        var pname = namelist[elcount - 1];
                                        var padress = adreslist[elcount - 1];
                                        var popen = openlist[elcount - 1];



                                        if (popen == String.Empty || popen == "")
                                        {

                                            if (otherinfo.FindElements(By.XPath("//span[@class='LJKBpe-Tswv1b-hour-text']")).Count > 0)
                                            {

                                                popen = otherinfo.FindElements(By.XPath("//span[@class='LJKBpe-Tswv1b-hour-text']"))[0].Text.Replace("  ", " ");
                                            }
                                        }

                                        int ct = 0;




                                     


                                    if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[3].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[3].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[3].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[1].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[1].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[1].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[2].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[2].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[2].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 5 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[4].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[4].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[4].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 6 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[5].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[5].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[5].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 7 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[6].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[6].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[6].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 8 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[7].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[7].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[7].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 9 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[8].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[8].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[8].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 10 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[9].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[9].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[9].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 11 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[10].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[10].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[10].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 12 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[11].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[11].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[11].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 13 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[12].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[12].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[12].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 14 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[13].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[13].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[13].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 15 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[14].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[14].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[14].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 16 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[15].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[15].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[15].Text;
                                    }
                                    else if (otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']")).Count >= 17 && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[16].GetAttribute("aria-label") != null && otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[16].GetAttribute("aria-label").Contains("Website"))
                                    {
                                        sitee = otherinfo.FindElements(By.XPath("//button[@class='CsEnBe']"))[16].Text;
                                    }

                                    if (sitee.Contains("Website"))
                                    {

                                        sitee = sitee.Replace("Website: ", "");

                                    }

                                    var filepath = Directory.GetCurrentDirectory().ToString() + "\\" + key.Replace("&", "").Replace("#", "").Replace("$", "").Replace("<", "").Replace(">", "").Replace("!", "").Replace("/", "").Replace("\\", "").Replace("%", "").Replace("*", "").Replace("\'", "").Replace("\"", "").Replace("{", "").Replace("}", "").Replace("?", "").Replace(":", "").Replace("@", "").Replace(" ", "_").Replace("+", "").Replace("`", "").Replace("|", "").Replace("=", "") + ".csv";
                                        string lll = "";

                                        if (isn == false && File.Exists(filepath))
                                        {
                                            File.Delete(filepath);
                                            isn = true;
                                        }


                                        if (File.Exists(filepath))
                                        {
                                            StreamReader sr = new StreamReader(filepath);
                                            lll = sr.ReadToEnd();
                                            sr.Close();
                                        }
                                        padress = otherinfo.FindElements(By.XPath("//div[@class='Io6YTe fontBodyMedium']"))[0].Text;


                                        //"QSFF4-text gm2-body-2"

                                        using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                                        FileMode.OpenOrCreate, FileAccess.Write)))
                                        {

                                            if (!lll.Contains("Telephone Number"))
                                            {


                                                writer.WriteLine("sep=,");

                                                writer.WriteLine("Type, Adres, Name, IsOpen, Telephone Number, Ratings, Web Page");
                                                writer.WriteLine(ptype.ToString() + "," + padress.ToString().Replace(",", "") + "," + pname.ToString().Replace(",", "") + "," + popen.ToString().Replace(",", "") + "," + teletelephone.ToString().Replace(",", "") + "," + ratings.ToString().Replace(",", "") + "," + sitee.ToString());
                                                writer.Close();
                                            }
                                            else
                                            {
                                                writer.WriteLine(lll.ToString() + ptype.ToString() + "," + padress.ToString().Replace(",", "") + "," + pname.ToString().Replace(",", "") + "," + popen.ToString().Replace(",", "") + "," + teletelephone.ToString().Replace(",", "") + "," + ratings.ToString().Replace(",", "") + "," + sitee.ToString());
                                                writer.Close();
                                            }

                                        }


                                        var bxo = CloneXaml(item, ptype, pname, padress, popen, teletelephone, ratings, sitee, "");
                                        holder.Items.Add(bxo);
                                        this.FindName("holder");
                                   
                                    System.Windows.Forms.Timer tmm = new System.Windows.Forms.Timer();
                                    tmm.Interval = 2000;
                                    tmm.Start();
                                    tmm.Tick += (x, y) =>
                                    {


                                        if (elcount - 1 <= urllist.Count() - 1)
                                        {
                                            
                                                lastur = urllist[elcount - 1];
                                                otherinfo.Navigate().GoToUrl(urllist[elcount - 1]);
                                            tmm.Stop();
                                            timexrdll.Stop();
                                            timerdll.Start();
                                            if (stopped != false)
                                            {
                                                tmm.Stop();
                                                timerdc.Stop();
                                                timerdd.Stop();
                                                timerdrd.Stop();
                                                timeraltd.Stop();
                                                timerdll.Stop();
                                                timexrdll.Stop();
                                            }
                                        }
                                    };

                                        
                                    }

                                }




                                else
                                {
                                    timerdll.Stop();
                                    timerdll.Start();
                                    if (stopped != false)
                                    {
                                        timerdc.Stop();
                                        timerdd.Stop();
                                        timerdrd.Stop();
                                    timeraltd.Stop();
                                        timerdll.Stop();
                                        timexrdll.Stop();
                                    }
                                };



                    };


                }

            };
        }


        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        public static string key = "";
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            key = keyy.Text;
        }
        public static bool firstt = false;
        public static int cad = 1;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (stopped != false)
            {
                timerdc.Stop();
                timerdd.Stop();
                timerdrd.Stop();
                timeraltd.Stop();
                timerdll.Stop();
                timexrdll.Stop();
            }
            if (Selenium.IsSelected == true)
            {
                cad = 1;
                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@57.7997928,-134.633477,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));


                timeraltd.Interval = 7000;
                timeraltd.Start();
                if (stopped != false)
                {
                    timerdc.Stop();
                    timerdd.Stop();
                    timerdrd.Stop();
                    timeraltd.Stop();
                    timerdll.Stop();
                    timexrdll.Stop();
                }

                timeraltd.Tick += (ed, od) =>
                {
                    if (stopped != false)
                    {
                        timerdc.Stop();
                        timerdd.Stop();
                        timerdrd.Stop();
                        timeraltd.Stop();
                        timerdll.Stop();
                        timexrdll.Stop();
                    }
                    timeraltd.Stop();


                    IJavaScriptExecutor jsd;

                    jsd = (IJavaScriptExecutor)driver;
                    jsd.ExecuteScript("if(document.getElementsByClassName('jmUlyc-LaJeF-on-HG3vT-checkbox')[0] != undefined) { document.getElementsByClassName('jmUlyc-LaJeF-on-HG3vT-checkbox')[0].click()}");

                    string strrr = (string)jsd.ExecuteScript("if (document.getElementsByClassName('V0h1Ob-haAclf THOPZb CpccDe')[0] != undefined) { var txt = 'complete'; return txt;}");

                    if (strrr == "complete")
                    {

                        //hV1iCc noprint hV1iCc-disabled
                        //hV1iCc noprint hV1iCc-disabled
                        //"a4gq8e-aVTXAb-haAclf-jRmmHf-hSRGPd"
                        //button
                        //class="DVeyrd gm2-hairline-border section-action-chip-button"
                        if (driver.FindElement(By.Id("ppdPk-Ej1Yeb-LgbsSe-tJiF1e")).GetAttribute("class") != "hV1iCc noprint hV1iCc-disabled" || driver.FindElements(By.XPath("//a[@class='V79n2d-di8rgd-aVTXAb-title']")).Count == 0 || driver.FindElements(By.XPath("//button[@class='DVeyrd gm2-hairline-border section-action-chip-button']")).Count == 0)
                        {


                            timerdd.Interval = 10000;
                            timerdd.Start();
                            if (stopped != false)
                            {
                                timerdc.Stop();
                                timerdd.Stop();
                                timerdrd.Stop();
                                timeraltd.Stop();
                                timerdll.Stop();
                                timexrdll.Stop();
                            }

                            timerdd.Tick += (edd, odd) =>
                        {
                            //  int ho = 0;
                            if (stopped != false)
                            {
                                timerdc.Stop();
                                timerdd.Stop();
                                timerdrd.Stop();
                                timeraltd.Stop();
                                timerdll.Stop();
                                timexrdll.Stop();
                            }
                            IList<IWebElement> col = driver.FindElements(By.XPath("//div[@class='V0h1Ob-haAclf THOPZb CpccDe']"));
                            foreach (IWebElement el in col)                                    //CUwbzc-content gm2-body-2
                            {





                                // ho = ho + 1;
                                //  IWebElement pname = el.FindElements(By.TagName("span"))[0];
                                if (el.FindElements(By.TagName("span"))[0] != null) {
                                    if (list.Contains(el.FindElements(By.TagName("span"))[0].Text) == false)
                                    {

                                        IWebElement ptype = el.FindElements(By.TagName("span"))[0];
                                        IWebElement padress = el.FindElements(By.TagName("span"))[0];
                                        string popen = "";


                                        //needs selenium

                                        enable = true;

                                        if (el.FindElements(By.TagName("span"))[0] != null)
                                        {

                                            string newurl = driver.FindElements(By.XPath("//a[@class='a4gq8e-aVTXAb-haAclf-jRmmHf-hSRGPd']"))[col.IndexOf(el)].GetAttribute("href").ToString();

                                            if (firstt == false)
                                            {
                                                lil = newurl;
                                                firstt = true;
                                            }
                                            else
                                            {
                                                //   if (!urllist.Contains(newurl))
                                                //   {
                                                urllist.Add(newurl);
                                                //  }
                                            }

                                            /*
                                                                             WebRequest wq = WebRequest.Create(newurl);


                                                                                 WebResponse wr = wq.GetResponse();
                                                                                  Stream stream = wr.GetResponseStream();

                                                                                  StreamReader srr = new StreamReader(stream);
                                                                                 string data = srr.ReadToEnd();


                                                                                     WebClient wc = new WebClient();
                                                                                     string[] domains = wc.DownloadString("http://data.iana.org/TLD/tlds-alpha-by-domain.txt").Split('\n');
                                                                               // string data = wc.DownloadString(newurl);

                                                                                  string s = "\\\",\\\"";



                                                                                   char[] ch = s.ToCharArray();



                                                                                   string[] strr = data.Split(ch);

                                                                                  bool found = false;

                                                                                   string site = "";

                                                                                  for (int m = 0; m < strr.Length; m++)
                                                                                 {

                                                                                        if (found == false)
                                                                                       {
                                                                                           if (strr[m].Contains("www.") && !strr[m].Contains("www.google") && !strr[m].Contains("gstatic.com"))
                                                                                {


                                                                                              found = true;
                                                                                             site = strr[m];

                                                                                              }
                                                                                          }

                                                                                  }



                                                                                   StreamWriter sdw = new StreamWriter(@"M:\ddd.txt");
                                                                                  sdw.WriteLine(data);
                                                                                  sdw.Close();*/
                                            /////////////////////////////////////////////////////////////////////////////////////////////////////


                                            //string sitee = otherinfo.FindElements(By.XPath("//div[@class='QSFF4-text gm2-body-2']"))[3].Text;





                                            if (el.FindElements(By.TagName("span")).Count >= 16)
                                            {
                                                ptype = el.FindElements(By.TagName("span"))[12];
                                                if (!el.FindElements(By.TagName("span"))[15].Text.Contains("Ope") || !el.FindElements(By.TagName("span"))[15].Text.Contains("Close"))
                                                {
                                                    padress = el.FindElements(By.TagName("span"))[15];
                                                }
                                            }
                                            else if (el.FindElements(By.TagName("span")).Count == 13)
                                            {
                                                if (el.FindElements(By.TagName("span"))[12].Text.Contains(" ") == false)
                                                {
                                                    ptype = el.FindElements(By.TagName("span"))[12];

                                                }
                                                else
                                                {
                                                    padress = el.FindElements(By.TagName("span"))[12];
                                                }
                                            }
                                            else if (el.FindElements(By.TagName("span")).Count < 15 && el.FindElements(By.TagName("span")).Count > 13)
                                            {
                                                ptype = el.FindElements(By.TagName("span"))[11];
                                                if (!el.FindElements(By.TagName("span"))[13].Text.Contains("Ope") || !el.FindElements(By.TagName("span"))[13].Text.Contains("Clos"))
                                                {
                                                    padress = el.FindElements(By.TagName("span"))[13];
                                                }
                                                else
                                                {
                                                    popen = el.FindElements(By.TagName("span"))[13].Text;
                                                }
                                            }
                                            else if (el.FindElements(By.TagName("span")).Count == 15)
                                            {
                                                ptype = el.FindElements(By.TagName("span"))[14];

                                            }


                                            if (el.FindElements(By.TagName("span")).Count() >= 19)
                                            {
                                                if (el.FindElements(By.TagName("span"))[18].Text.Contains("Ope") || el.FindElements(By.TagName("span"))[18].Text.Contains("Close"))
                                                {
                                                    popen = el.FindElements(By.TagName("span"))[18].Text;
                                                }
                                                else
                                                {
                                                    padress = el.FindElements(By.TagName("span"))[15];
                                                }
                                            }
                                            else if (el.FindElements(By.TagName("span")).Count() == 16)
                                            {
                                                if (el.FindElements(By.TagName("span"))[15].Text.Contains("Ope") || el.FindElements(By.TagName("span"))[15].Text.Contains("Close"))
                                                {
                                                    popen = el.FindElements(By.TagName("span"))[15].Text;
                                                }
                                                else
                                                {
                                                    padress = el.FindElements(By.TagName("span"))[15];
                                                }

                                            }
                                            list.Add(el.FindElements(By.TagName("span"))[0].Text);





                                            typelist.Add(ptype.Text.Replace("·", "").Replace(" & ", " and ").Replace(" & ", " and ").Replace("\'", "").Replace("\"", ""));

                                            adreslist.Add(padress.Text.Replace("·", "").Replace(" & ", " and ").Replace(" & ", " and ").Replace("\'", "").Replace("\"", ""));

                                            namelist.Add(el.FindElements(By.TagName("span"))[0].Text.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "").Replace("·", ""));

                                            openlist.Add(popen.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", ""));







                                        }


                                    }


                                    timeraltd.Start();

                                    timerdd.Stop();

                                };

                                if (howmuch != 1)
                                {
                                    if (stopped != false)
                                    {
                                        timerdc.Stop();
                                        timerdd.Stop();
                                        timerdrd.Stop();
                                        timeraltd.Stop();
                                        timerdll.Stop();
                                        timexrdll.Stop();


                                    }
                                    if (driver.FindElement(By.Id("ppdPk-Ej1Yeb-LgbsSe-tJiF1e")).GetAttribute("class") != "hV1iCc noprint hV1iCc-disabled")
                                    {
                                        timerdrd.Interval = 4000;
                                        timerdrd.Start();

                                        timerdrd.Tick += (eddccc, oddccc) =>
                                        {


                                            IJavaScriptExecutor js;

                                            js = (IJavaScriptExecutor)driver;


                                            string strrrd = (string)js.ExecuteScript("if (document.getElementById('ppdPk-Ej1Yeb-LgbsSe-tJiF1e') != undefined) { var txt = 'complete'; return txt;}");

                                            string strrrde = (string)js.ExecuteScript("if (document.getElementsByClassName('V79n2d-di8rgd-aVTXAb-title').length != 0) { var txte = 'complete'; return txte;}");
                                            //'CUwbzc-content gm2-body-2'
                                            timerdrd.Stop();

                                            if (strrrd == "complete")
                                            {
                                                if (strrrde == "complete")
                                                {
                                                    if (cad == 1)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@70.7663956,-68.3639458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 2)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@10.7721046,-103.1686333,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 3)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-49.9912931,-88.0514458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }




                                                    else if (cad == 4)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.9339762,-149.6280555,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 5)
                                                    {

                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.1386762,-132.3822297,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 6)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.2246564,-109.1264949,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 7)
                                                    { driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.5363848,-93.5007315,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 8)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@39.8023194,-102.1236444,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 9)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@36.9348366,-124.9090385,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 10)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@25.0554372,-112.2620996,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 11)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@6.6477611,-102.5939851,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 12)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.2731501,-86.0275403,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 13)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.9954945,-72.2831397,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 14)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.8457602,-64.5920653,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 15)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-9.2445455,-59.6701903,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 16)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-17.8651481,-70.6125731,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 17)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-12.24483,-80.0388426,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 18)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-26.8546937,-66.9237541,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 19)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-35.5576847,-69.4096764,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 20)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-45.9931305,-77.4267757,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 21)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-52.0249946,-61.3881533,7z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 22)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@21.8590549,-17.6528125,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 23)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@18.8656295,-6.0972654,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 24)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@8.7456959,-14.4593992,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 25)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@11.8548468,7.8944939,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 26)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-6.0238193,11.2525162,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 27)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-23.9701369,17.5076556,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 28)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.5768529,39.4006437,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                    }
                                                    else if (cad == 29)
                                                    {
                                                        driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-18.3859174,38.7092862,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                        MessageBox.Show("all");
                                                    }
                                                    cad = cad + 1;

                                                    if (stopped != false)
                                                    {
                                                        timerdc.Stop();
                                                        timerdd.Stop();
                                                        timerdrd.Stop();
                                                        timeraltd.Stop();
                                                        timerdll.Stop();
                                                        timexrdll.Stop();
                                                    }


                                                }
                                                else
                                                {

                                                    IJavaScriptExecutor jjs;

                                                    jjs = (IJavaScriptExecutor)driver;
                                                    // later on...
                                                    jjs.ExecuteScript("document.getElementById('ppdPk-Ej1Yeb-LgbsSe-tJiF1e').click()");
                                                    timerdrd.Stop();
                                                    timerdrd.Start();

                                                }
                                            }

                                            else
                                            {
                                                timerdrd.Stop();
                                                timerdrd.Start();
                                                if (stopped != false)
                                                {
                                                    timerdc.Stop();
                                                    timerdd.Stop();
                                                    timerdrd.Stop();
                                                    timeraltd.Stop();
                                                    timerdll.Stop();
                                                    timexrdll.Stop();
                                                }
                                            }
                                            if (stopped != false)
                                            {
                                                timerdc.Stop();
                                                timerdd.Stop();
                                                timerdrd.Stop();
                                                timeraltd.Stop();
                                                timerdll.Stop();
                                                timexrdll.Stop();
                                            }

                                        };
                                    }
                                }

                            }

                            howmuch = howmuch + 1;

                        };
                        }
                        else if (driver.FindElement(By.Id("ppdPk-Ej1Yeb-LgbsSe-tJiF1e")).GetAttribute("class") == "hV1iCc noprint hV1iCc-disabled" || driver.FindElements(By.XPath("//a[@class='V79n2d-di8rgd-aVTXAb-title']")).Count != 0 || driver.FindElements(By.XPath("//button[@class='DVeyrd gm2-hairline-border section-action-chip-button']")).Count != 0)
                        {


                            if (cad == 1)
                            {
                                cad = 2;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@70.7663956,-68.3639458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 2)
                            {
                                cad = 3; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@10.7721046,-103.1686333,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 3)
                            {
                                cad = 4; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-49.9912931,-88.0514458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }




                            else if (cad == 4)
                            {
                                cad = 5; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.9339762,-149.6280555,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 5)
                            {
                                cad = 6;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.1386762,-132.3822297,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 6)
                            {

                                cad = 7;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.2246564,-109.1264949,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 7)
                            {

                                cad = 8; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.5363848,-93.5007315,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 8)
                            {
                                cad = 9;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@39.8023194,-102.1236444,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 9)
                            {
                                cad = 10;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@36.9348366,-124.9090385,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 10)
                            {
                                cad = 11;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@25.0554372,-112.2620996,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 11)
                            {
                                cad = 12;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@6.6477611,-102.5939851,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 12)
                            {
                                cad = 13;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.2731501,-86.0275403,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 13)
                            {
                                cad = 14;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.9954945,-72.2831397,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 14)
                            {
                                cad = 15;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.8457602,-64.5920653,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 15)
                            {
                                cad = 16;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-9.2445455,-59.6701903,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 16)
                            {
                                cad = 17;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-17.8651481,-70.6125731,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 17)
                            {
                                cad = 18;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-12.24483,-80.0388426,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 18)
                            {
                                cad = 19;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-26.8546937,-66.9237541,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 19)
                            {
                                cad = 20;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-35.5576847,-69.4096764,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 20)
                            {
                                cad = 21;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-45.9931305,-77.4267757,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 21)
                            {
                                cad = 22;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-52.0249946,-61.3881533,7z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 22)
                            {
                                cad = 23;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@21.8590549,-17.6528125,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 23)
                            {
                                cad = 24;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@18.8656295,-6.0972654,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 24)
                            {
                                cad = 25;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@8.7456959,-14.4593992,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 25)
                            {
                                cad = 26;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@11.8548468,7.8944939,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 26)
                            {
                                cad = 27;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-6.0238193,11.2525162,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 27)
                            {
                                cad = 28;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-23.9701369,17.5076556,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 28)
                            {
                                cad = 29;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.5768529,39.4006437,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                            }
                            else if (cad == 29)
                            {
                                cad = 30;
                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-18.3859174,38.7092862,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));

                            }

                            timeraltd.Start();
                            if (stopped != false)
                            {
                                timerdc.Stop();
                                timerdd.Stop();
                                timerdrd.Stop();
                                timeraltd.Stop();
                                timerdll.Stop();
                                timexrdll.Stop();
                            }
                        }


                    }
                    else
                    {
                         strrr = (string)jsd.ExecuteScript("if (document.getElementsByClassName('Nv2PK THOPZb CpccDe')[0] != undefined) { var txt = 'complete'; return txt;}");

                        if (strrr == "complete")
                        {

                            //hV1iCc noprint hV1iCc-disabled
                            //hV1iCc noprint hV1iCc-disabled
                            //"a4gq8e-aVTXAb-haAclf-jRmmHf-hSRGPd"
                            //button
                            //class="DVeyrd gm2-hairline-border section-action-chip-button"
                            if (driver.FindElement(By.Id("ppdPk-Ej1Yeb-LgbsSe-tJiF1e")).GetAttribute("class") != "hV1iCc noprint hV1iCc-disabled" || driver.FindElements(By.XPath("//a[@class='V79n2d-di8rgd-aVTXAb-title']")).Count == 0 || driver.FindElements(By.XPath("//button[@class='DVeyrd gm2-hairline-border section-action-chip-button']")).Count == 0)
                            {


                                timerdd.Interval = 10000;
                                timerdd.Start();
                                if (stopped != false)
                                {
                                    timerdc.Stop();
                                    timerdd.Stop();
                                    timerdrd.Stop();
                                    timeraltd.Stop();
                                    timerdll.Stop();
                                    timexrdll.Stop();
                                }

                                timerdd.Tick += (edd, odd) =>
                                {
                                    //  int ho = 0;
                                    if (stopped != false)
                                    {
                                        timerdc.Stop();
                                        timerdd.Stop();
                                        timerdrd.Stop();
                                        timeraltd.Stop();
                                        timerdll.Stop();
                                        timexrdll.Stop();
                                    }
                                    IList<IWebElement> col = driver.FindElements(By.XPath("//div[@class='V0h1Ob-haAclf THOPZb CpccDe']"));
                                    foreach (IWebElement el in col)                                    //CUwbzc-content gm2-body-2
                                    {





                                        // ho = ho + 1;
                                        //  IWebElement pname = el.FindElements(By.TagName("span"))[0];
                                        if (el.FindElements(By.TagName("span"))[0] != null)
                                        {
                                            if (list.Contains(el.FindElements(By.TagName("span"))[0].Text) == false)
                                            {

                                                IWebElement ptype = el.FindElements(By.TagName("span"))[0];
                                                IWebElement padress = el.FindElements(By.TagName("span"))[0];
                                                string popen = "";


                                                //needs selenium

                                                enable = true;

                                                if (el.FindElements(By.TagName("span"))[0] != null)
                                                {

                                                    string newurl = driver.FindElements(By.XPath("//a[@class='a4gq8e-aVTXAb-haAclf-jRmmHf-hSRGPd']"))[col.IndexOf(el)].GetAttribute("href").ToString();

                                                    if (firstt == false)
                                                    {
                                                        lil = newurl;
                                                        firstt = true;
                                                    }
                                                    else
                                                    {
                                                        //   if (!urllist.Contains(newurl))
                                                        //   {
                                                        urllist.Add(newurl);
                                                        //  }
                                                    }

                                                    /*
                                                                                     WebRequest wq = WebRequest.Create(newurl);


                                                                                         WebResponse wr = wq.GetResponse();
                                                                                          Stream stream = wr.GetResponseStream();

                                                                                          StreamReader srr = new StreamReader(stream);
                                                                                         string data = srr.ReadToEnd();


                                                                                             WebClient wc = new WebClient();
                                                                                             string[] domains = wc.DownloadString("http://data.iana.org/TLD/tlds-alpha-by-domain.txt").Split('\n');
                                                                                       // string data = wc.DownloadString(newurl);

                                                                                          string s = "\\\",\\\"";



                                                                                           char[] ch = s.ToCharArray();



                                                                                           string[] strr = data.Split(ch);

                                                                                          bool found = false;

                                                                                           string site = "";

                                                                                          for (int m = 0; m < strr.Length; m++)
                                                                                         {

                                                                                                if (found == false)
                                                                                               {
                                                                                                   if (strr[m].Contains("www.") && !strr[m].Contains("www.google") && !strr[m].Contains("gstatic.com"))
                                                                                        {


                                                                                                      found = true;
                                                                                                     site = strr[m];

                                                                                                      }
                                                                                                  }

                                                                                          }



                                                                                           StreamWriter sdw = new StreamWriter(@"M:\ddd.txt");
                                                                                          sdw.WriteLine(data);
                                                                                          sdw.Close();*/
                                                    /////////////////////////////////////////////////////////////////////////////////////////////////////


                                                    //string sitee = otherinfo.FindElements(By.XPath("//div[@class='QSFF4-text gm2-body-2']"))[3].Text;





                                                    if (el.FindElements(By.TagName("span")).Count >= 16)
                                                    {
                                                        ptype = el.FindElements(By.TagName("span"))[12];
                                                        if (!el.FindElements(By.TagName("span"))[15].Text.Contains("Ope") || !el.FindElements(By.TagName("span"))[15].Text.Contains("Close"))
                                                        {
                                                            padress = el.FindElements(By.TagName("span"))[15];
                                                        }
                                                    }
                                                    else if (el.FindElements(By.TagName("span")).Count == 13)
                                                    {
                                                        if (el.FindElements(By.TagName("span"))[12].Text.Contains(" ") == false)
                                                        {
                                                            ptype = el.FindElements(By.TagName("span"))[12];

                                                        }
                                                        else
                                                        {
                                                            padress = el.FindElements(By.TagName("span"))[12];
                                                        }
                                                    }
                                                    else if (el.FindElements(By.TagName("span")).Count < 15 && el.FindElements(By.TagName("span")).Count > 13)
                                                    {
                                                        ptype = el.FindElements(By.TagName("span"))[11];
                                                        if (!el.FindElements(By.TagName("span"))[13].Text.Contains("Ope") || !el.FindElements(By.TagName("span"))[13].Text.Contains("Clos"))
                                                        {
                                                            padress = el.FindElements(By.TagName("span"))[13];
                                                        }
                                                        else
                                                        {
                                                            popen = el.FindElements(By.TagName("span"))[13].Text;
                                                        }
                                                    }
                                                    else if (el.FindElements(By.TagName("span")).Count == 15)
                                                    {
                                                        ptype = el.FindElements(By.TagName("span"))[14];

                                                    }


                                                    if (el.FindElements(By.TagName("span")).Count() >= 19)
                                                    {
                                                        if (el.FindElements(By.TagName("span"))[18].Text.Contains("Ope") || el.FindElements(By.TagName("span"))[18].Text.Contains("Close"))
                                                        {
                                                            popen = el.FindElements(By.TagName("span"))[18].Text;
                                                        }
                                                        else
                                                        {
                                                            padress = el.FindElements(By.TagName("span"))[15];
                                                        }
                                                    }
                                                    else if (el.FindElements(By.TagName("span")).Count() == 16)
                                                    {
                                                        if (el.FindElements(By.TagName("span"))[15].Text.Contains("Ope") || el.FindElements(By.TagName("span"))[15].Text.Contains("Close"))
                                                        {
                                                            popen = el.FindElements(By.TagName("span"))[15].Text;
                                                        }
                                                        else
                                                        {
                                                            padress = el.FindElements(By.TagName("span"))[15];
                                                        }

                                                    }
                                                    list.Add(el.FindElements(By.TagName("span"))[0].Text);





                                                    typelist.Add(ptype.Text.Replace("·", "").Replace(" & ", " and ").Replace(" & ", " and ").Replace("\'", "").Replace("\"", ""));

                                                    adreslist.Add(padress.Text.Replace("·", "").Replace(" & ", " and ").Replace(" & ", " and ").Replace("\'", "").Replace("\"", ""));

                                                    namelist.Add(el.FindElements(By.TagName("span"))[0].Text.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", "").Replace("·", ""));

                                                    openlist.Add(popen.Replace(" & ", " and ").Replace("&", " and ").Replace("\'", "").Replace("\"", "").Replace(">", "").Replace("<", ""));







                                                }


                                            }


                                            timeraltd.Start();

                                            timerdd.Stop();

                                        };

                                        if (howmuch != 1)
                                        {
                                            if (stopped != false)
                                            {
                                                timerdc.Stop();
                                                timerdd.Stop();
                                                timerdrd.Stop();
                                                timeraltd.Stop();
                                                timerdll.Stop();
                                                timexrdll.Stop();


                                            }
                                            if (driver.FindElement(By.Id("ppdPk-Ej1Yeb-LgbsSe-tJiF1e")).GetAttribute("class") != "hV1iCc noprint hV1iCc-disabled")
                                            {
                                                timerdrd.Interval = 4000;
                                                timerdrd.Start();

                                                timerdrd.Tick += (eddccc, oddccc) =>
                                                {


                                                    IJavaScriptExecutor js;

                                                    js = (IJavaScriptExecutor)driver;


                                                    string strrrd = (string)js.ExecuteScript("if (document.getElementById('ppdPk-Ej1Yeb-LgbsSe-tJiF1e') != undefined) { var txt = 'complete'; return txt;}");

                                                    string strrrde = (string)js.ExecuteScript("if (document.getElementsByClassName('V79n2d-di8rgd-aVTXAb-title').length != 0) { var txte = 'complete'; return txte;}");
                                                    //'CUwbzc-content gm2-body-2'
                                                    timerdrd.Stop();

                                                    if (strrrd == "complete")
                                                    {
                                                        if (strrrde == "complete")
                                                        {
                                                            if (cad == 1)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@70.7663956,-68.3639458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 2)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@10.7721046,-103.1686333,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 3)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-49.9912931,-88.0514458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }




                                                            else if (cad == 4)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.9339762,-149.6280555,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 5)
                                                            {

                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.1386762,-132.3822297,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 6)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.2246564,-109.1264949,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 7)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.5363848,-93.5007315,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 8)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@39.8023194,-102.1236444,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 9)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@36.9348366,-124.9090385,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 10)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@25.0554372,-112.2620996,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 11)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@6.6477611,-102.5939851,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 12)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.2731501,-86.0275403,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 13)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.9954945,-72.2831397,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 14)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.8457602,-64.5920653,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 15)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-9.2445455,-59.6701903,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 16)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-17.8651481,-70.6125731,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 17)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-12.24483,-80.0388426,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 18)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-26.8546937,-66.9237541,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 19)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-35.5576847,-69.4096764,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 20)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-45.9931305,-77.4267757,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 21)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-52.0249946,-61.3881533,7z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 22)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@21.8590549,-17.6528125,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 23)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@18.8656295,-6.0972654,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 24)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@8.7456959,-14.4593992,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 25)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@11.8548468,7.8944939,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 26)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-6.0238193,11.2525162,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 27)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-23.9701369,17.5076556,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 28)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.5768529,39.4006437,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                            }
                                                            else if (cad == 29)
                                                            {
                                                                driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-18.3859174,38.7092862,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                                                MessageBox.Show("all");
                                                            }
                                                            cad = cad + 1;

                                                            if (stopped != false)
                                                            {
                                                                timerdc.Stop();
                                                                timerdd.Stop();
                                                                timerdrd.Stop();
                                                                timeraltd.Stop();
                                                                timerdll.Stop();
                                                                timexrdll.Stop();
                                                            }


                                                        }
                                                        else
                                                        {

                                                            IJavaScriptExecutor jjs;

                                                            jjs = (IJavaScriptExecutor)driver;
                                                            // later on...
                                                            jjs.ExecuteScript("document.getElementById('ppdPk-Ej1Yeb-LgbsSe-tJiF1e').click()");
                                                            timerdrd.Stop();
                                                            timerdrd.Start();

                                                        }
                                                    }

                                                    else
                                                    {
                                                        timerdrd.Stop();
                                                        timerdrd.Start();
                                                        if (stopped != false)
                                                        {
                                                            timerdc.Stop();
                                                            timerdd.Stop();
                                                            timerdrd.Stop();
                                                            timeraltd.Stop();
                                                            timerdll.Stop();
                                                            timexrdll.Stop();
                                                        }
                                                    }
                                                    if (stopped != false)
                                                    {
                                                        timerdc.Stop();
                                                        timerdd.Stop();
                                                        timerdrd.Stop();
                                                        timeraltd.Stop();
                                                        timerdll.Stop();
                                                        timexrdll.Stop();
                                                    }

                                                };
                                            }
                                        }

                                    }

                                    howmuch = howmuch + 1;

                                };
                            }
                            else if (driver.FindElement(By.Id("ppdPk-Ej1Yeb-LgbsSe-tJiF1e")).GetAttribute("class") == "hV1iCc noprint hV1iCc-disabled" || driver.FindElements(By.XPath("//a[@class='V79n2d-di8rgd-aVTXAb-title']")).Count != 0 || driver.FindElements(By.XPath("//button[@class='DVeyrd gm2-hairline-border section-action-chip-button']")).Count != 0)
                            {


                                if (cad == 1)
                                {
                                    cad = 2;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@70.7663956,-68.3639458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 2)
                                {
                                    cad = 3; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@10.7721046,-103.1686333,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 3)
                                {
                                    cad = 4; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-49.9912931,-88.0514458,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }




                                else if (cad == 4)
                                {
                                    cad = 5; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.9339762,-149.6280555,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 5)
                                {
                                    cad = 6;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@62.1386762,-132.3822297,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 6)
                                {

                                    cad = 7;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.2246564,-109.1264949,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 7)
                                {

                                    cad = 8; driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@53.5363848,-93.5007315,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 8)
                                {
                                    cad = 9;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@39.8023194,-102.1236444,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 9)
                                {
                                    cad = 10;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@36.9348366,-124.9090385,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 10)
                                {
                                    cad = 11;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@25.0554372,-112.2620996,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 11)
                                {
                                    cad = 12;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@6.6477611,-102.5939851,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 12)
                                {
                                    cad = 13;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.2731501,-86.0275403,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 13)
                                {
                                    cad = 14;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.9954945,-72.2831397,4.75z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 14)
                                {
                                    cad = 15;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-2.8457602,-64.5920653,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 15)
                                {
                                    cad = 16;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-9.2445455,-59.6701903,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 16)
                                {
                                    cad = 17;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-17.8651481,-70.6125731,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 17)
                                {
                                    cad = 18;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-12.24483,-80.0388426,6z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 18)
                                {
                                    cad = 19;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-26.8546937,-66.9237541,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 19)
                                {
                                    cad = 20;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-35.5576847,-69.4096764,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 20)
                                {
                                    cad = 21;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-45.9931305,-77.4267757,5.5z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 21)
                                {
                                    cad = 22;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-52.0249946,-61.3881533,7z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 22)
                                {
                                    cad = 23;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@21.8590549,-17.6528125,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 23)
                                {
                                    cad = 24;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@18.8656295,-6.0972654,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 24)
                                {
                                    cad = 25;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@8.7456959,-14.4593992,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 25)
                                {
                                    cad = 26;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@11.8548468,7.8944939,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 26)
                                {
                                    cad = 27;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-6.0238193,11.2525162,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 27)
                                {
                                    cad = 28;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-23.9701369,17.5076556,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 28)
                                {
                                    cad = 29;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-13.5768529,39.4006437,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));
                                }
                                else if (cad == 29)
                                {
                                    cad = 30;
                                    driver.Navigate().GoToUrl("https://www.google.com/maps/search/cafe/@-18.3859174,38.7092862,5.42z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));

                                }

                                timeraltd.Start();
                                if (stopped != false)
                                {
                                    timerdc.Stop();
                                    timerdd.Stop();
                                    timerdrd.Stop();
                                    timeraltd.Stop();
                                    timerdll.Stop();
                                    timexrdll.Stop();
                                }
                            }


                        }

                        else if (stopped != false)
                        {
                            timerdc.Stop();
                            timerdd.Stop();
                            timerdrd.Stop();
                            timeraltd.Stop();
                            timerdll.Stop();
                            timexrdll.Stop();
                        }
                        timeraltd.Start();
                    }


                };


            }

         /*    else if (WebRq.IsSelected == true)
              {

                      Uri rl = new Uri("https://www.google.com/maps/search/cafe/@57.7997928,-134.633477,3z/data=!4m2!2m1!6e5?hl=en".Replace("/cafe/", "/" + key + "/"));

                      WebRequest webRequest = WebRequest.Create("https://www.google.com/maps/search/cafe?hl=en".Replace("/cafe/", "/" + key + "/"));
                      WebResponse wr = webRequest.GetResponse();

                      Stream rstram = wr.GetResponseStream();

                      StreamReader reqestdatastream = new StreamReader(rstram);


                      string dat = reqestdatastream.ReadToEnd();


              //
                //      StreamWriter filestreamWritertest = new StreamWriter(Directory.GetCurrentDirectory().ToString() + "\\" + @"test.txt");

                      StreamReader blacksymbols = new StreamReader(Directory.GetCurrentDirectory().ToString() + "\\" + @"rsymbols.txt");


                      //       List<string> datasiteraw = reqestdatastream.ReadToEnd().Split('\"').ToList();

                      string[] symbolstodelete = blacksymbols.ReadToEnd().Split(new string[] { "\n" }, StringSplitOptions.None);

                      string[] pppdata = dat.Split(new string[] { "\"" }, StringSplitOptions.None);

                      string fin = "";
                      for (int i = 0; i < pppdata.Length; i++)
                      {
                          if (pppdata[i].Length < 20)
                          {
                              int id = 0;
                              foreach (string sym in symbolstodelete)
                              {
                                  if (sym.Contains(pppdata[i]) == true)
                                  {
                                      id = id + 1;
                                  }

                              }

                              if (id == 0 && !pppdata[i].Contains("null") && !pppdata[i].Contains("]") && !pppdata[i].Contains("$$") && !pppdata[i].Contains(key) && !pppdata[i].Contains("["))
                              {
                                  fin = fin + pppdata[i];

                              }
                              else
                              {
                                  fin = fin + "";
                              }

                          }
                      }
                      string[] k = fin.Split('\\');
                    //  foreach (string kk in k)
                      //{
                     //     filestreamWritertest.Write(kk + "\n");
                     // }
                      //72
                      int num = 72;

                      List<string> datasite = new List<string>();
                      List<string> dataname = new List<string>();
                      List<string> datatype = new List<string>();
                      List<string> adres = new List<string>();
                      List<string> rewiews = new List<string>();
                      List<string> popene = new List<string>();
                      WebClient wcc = new WebClient();
                      string[] domains = wcc.DownloadString("http://data.iana.org/TLD/tlds-alpha-by-domain.txt").Split('\n');


                      int c = 1;
                      for (int m = 0; m < k.Length; m++)
                      {

                          if (k[m].Contains("+") && k[m].Contains("tel:") && !k[m].Contains("Google+") && !k[m].Contains("phot"))
                          {

                              popene.Add(k[m]);

                          }

                          if (k[m].Contains("reviews"))
                          {
                              rewiews.Add(k[m]);
                          }

                          foreach (string domain in domains)
                          {




                              if (k[m].Contains("." + domain))
                              {
                                  if (!datasite.Contains(k[m]))
                                  {
                                      datasite.Add(k[m]);
                                      datatype.Add(k[m + 2]);
                                      dataname.Add(k[m + 3]);
                                      if (m - 4 >= 0)
                                      {

                                          adres.Add(k[m - 3] + " " + k[m - 4]);

                                      }
                                      else
                                      {
                                          adres.Add("");
                                      }
                                  }


                                  ////////////////////////fix


                              }
                          }
                      }


                      for (int pee = 0; pee < datasite.Count(); pee++)
                      {

                          var filepath = Directory.GetCurrentDirectory().ToString() + "\\" + key.Replace("&", "").Replace("#", "").Replace("$", "").Replace("<", "").Replace(">", "").Replace("!", "").Replace("/", "").Replace("\\", "").Replace("%", "").Replace("*", "").Replace("\'", "").Replace("\"", "").Replace("{", "").Replace("}", "").Replace("?", "").Replace(":", "").Replace("@", "").Replace(" ", "_").Replace("+", "").Replace("`", "").Replace("|", "").Replace("=", "") + ".csv";
                          string lll = "";

                          if (isn == false && File.Exists(filepath))
                          {
                              File.Delete(filepath);
                              isn = true;
                          }


                          if (File.Exists(filepath))
                          {
                              StreamReader sr = new StreamReader(filepath);
                              lll = sr.ReadToEnd();
                              sr.Close();
                          }



                          //"QSFF4-text gm2-body-2"
                          var ptype = "";
                          if (pee < datatype.Count())

                          {
                              ptype = datatype[pee];
                          }
                          var site = datasite[pee];
                          var padress = "";
                          var teletelephone = "";
                          var pname = "";
                          var ratings = "";
                          if (pee < adres.Count())
                          {
                              padress = adres[pee];
                          }
                          if (pee < dataname.Count)
                          {
                              pname = dataname[pee];
                          }
                          if (pee < popene.Count)
                          {
                              teletelephone = popene[pee];
                          }


                          if (pee < rewiews.Count)
                          {
                              ratings = rewiews[pee];
                          }
                          using (StreamWriter writer = new StreamWriter(new FileStream(filepath,
                              FileMode.OpenOrCreate, FileAccess.Write)))
                          {

                              if (!lll.Contains("Telephone Number"))
                              {


                                  writer.WriteLine("sep=,");

                                  writer.WriteLine("Type, Adres, Name, Telephone Number, Ratings, Web Page");
                                  writer.WriteLine(ptype + "," + padress.Replace(",", "") + "," + pname.Replace(",", "") + "," + teletelephone.Replace(",", "") + "," + ratings.Replace(",", "") + "," + site);
                                  writer.Close();
                              }
                              else
                              {



                                  writer.WriteLine(lll + ptype + "," + padress.Replace(",", "") + "," + pname.Replace(",", "") + "," + teletelephone.Replace(",", "") + "," + ratings.Replace(",", "") + "," + site);
                                  writer.Close();
                              }

                              var bxo = CloneXaml(item, ptype, pname, padress, "", teletelephone, ratings, sitee, "");
                              holder.Items.Add(bxo);
                              this.FindName("holder");
                          }




                          //if (!k[71 * c].Contains("Ope") && !k[71 * c].Contains("Clos"))
                          // {
                          //      num = 71;
                             // }
                             if (k.Length >= 75* c)
                             {

                                 if (k[71 * c].Contains("Ope") || k[71 * c].Contains("Clos"))
                                 {
                                     num = 71;
                                 }
                                 if (k[72 * c].Contains("Ope") || k[72 * c].Contains("Clos"))
                                 {
                                     num = 72;
                                 }
                                 if (k[73 * c].Contains("Ope") || k[73 * c].Contains("Clos"))
                                 {
                                     num = 73;
                                 }
                                 if (k[74 * c].Contains("Ope") || k[74 * c].Contains("Clos"))
                                 {
                                     num = 74;
                                 }
                                 if (k[75 * c].Contains("Ope") || k[75 * c].Contains("Clos"))
                                 {
                                     num = 75;
                                 }


                      16


                                 if (m == num * c)
                                 {
                                     c = c + 1;

                                     filestreamWritertest.Write(k[m] + "\n" + "[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]fghfh].,],],],],],]]]jh]]kj]]]]]]" + "\n");
                                     num = 71;

                                 }
                                 else if (m != num * c)
                                 {
                                     filestreamWritertest.Write(k[m] + "\n");
                                 }

                             }
                             else {
                                 filestreamWritertest.Write(k[m] + "\n");
                             }
        }




                        reqestdatastream.Close();
                        blacksymbols.Close();

                //    WebClient wc = new WebClient();
                //    string[] domains = wc.DownloadString("http://data.iana.org/TLD/tlds-alpha-by-domain.txt").Split('\n');
                if (stopped != false)
                {
                    timerdc.Stop();
                    timerdd.Stop();
                    timerdrd.Stop();
                    timeraltd.Stop();
                    timerdll.Stop();
                    timexrdll.Stop();
                }


            }*/

            


        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Box_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_MouseDown(object sender, MouseButtonEventArgs e)
        {
            timerdc.Stop();
            timerdd.Stop();
            timerdrd.Stop();
            timeraltd.Stop();
            timerdll.Stop();
            timexrdll.Stop();
            stopped = false;


            timerdc.Start();
            timeraltd.Start();

    }

        private void Button_MouseDown_1(object sender, MouseButtonEventArgs e)
        {

            stopped = true;
            timerdc.Stop();
            timerdd.Stop();
            timerdrd.Stop();
            timeraltd.Stop();
            timerdll.Stop();
            timexrdll.Stop();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            stopped = true;
            timerdc.Stop();
            timerdd.Stop();
            timerdrd.Stop();
            timeraltd.Stop();
            timerdll.Stop();
            timexrdll.Stop();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            timerdc.Stop();
            timerdd.Stop();
            timerdrd.Stop();
            timeraltd.Stop();
            timerdll.Stop();
            timexrdll.Stop();
            stopped = false;

            ///messagebox show cad
            timerdll.Start();

            timeraltd.Start();
         
        }
    }
}
