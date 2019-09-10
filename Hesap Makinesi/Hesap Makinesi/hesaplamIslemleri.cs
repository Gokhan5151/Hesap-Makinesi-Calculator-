using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi
{
    class hesaplamIslemleri
    {
        static List<string> hesap = new List<string>();
        public static List<string> SayiListesi(string textBox1)
        {
            hesap.RemoveRange(0, hesap.Count);
            textBox1 = ozelislemler.trigonometrikIfadeler(textBox1);
            textBox1 = ozelislemler.lnHesap(textBox1);
            textBox1 = ozelislemler.ePi(textBox1);

            string k = textBox1;
            string ekle = "";
            char[] dizi = k.ToCharArray();
            foreach (char item in dizi)
            {

                if ((!char.IsDigit(item)) && item != ',')
                {
                    if (ekle != "")
                        hesap.Add(ekle);

                    if (item != ',')
                        hesap.Add(item.ToString());
                    ekle = "";
                }

                if (char.IsDigit(item) || item == ',')
                    ekle += item;


            }
            if (ekle != "")
                hesap.Add(ekle);

            if (hesap[0] == "-")
                hesap.Insert(0, "0");
            int sayac = hesap.Count;
            for (int i = 0; i < sayac; i++)
            {

                if (hesap[i] == "-")
                    if (hesap[i - 1] == "(")
                        hesap.Insert(i, "0");
            }
            return hesap;
        }

        static Double carpim = 1;

        static public List<string> CarpBol(List<string> hesap)
        {
            foreach (string item in hesap.FindAll(x => x == "x" || x == "/"))
            {

                int a = hesap.IndexOf(item);
                carpim = double.Parse(hesap[a - 1]);
                if (item == "x")
                    carpim *= double.Parse(hesap[a + 1]);
                if (item == "/")
                    carpim /= double.Parse(hesap[a + 1]);
                hesap.RemoveAt(a - 1);
                a = hesap.IndexOf(item);
                hesap.RemoveAt(a + 1);
                a = hesap.IndexOf(item);
                hesap[a] = carpim.ToString();


            }
            return hesap;
        }
        static public List<string> ToplaCikart(List<string> hesap)
        {
            foreach (string item in hesap.FindAll(x => x == "+" || x == "-"))
            {

                int a = hesap.IndexOf(item);
                carpim = double.Parse(hesap[a - 1]);
                if (item == "+")
                    carpim += double.Parse(hesap[a + 1]);
                if (item == "-")
                {
                    carpim -= double.Parse(hesap[a + 1]);
                }

                hesap.RemoveAt(a - 1);
                a = hesap.IndexOf(item);
                hesap.RemoveAt(a + 1);
                a = hesap.IndexOf(item);
                hesap[a] = carpim.ToString();


            }
            return hesap;
        }
        
        static public List<string> CarpBolOncelik(List<string> Oncelik)
        {
            powHesaplaOncelik(Oncelik);
            foreach (string item in Oncelik.FindAll(x => x == "x" || x == "/"))
            {

                int a = Oncelik.IndexOf(item);
                carpim = double.Parse(Oncelik[a - 1]);
                if (item == "x")
                    carpim *= double.Parse(Oncelik[a + 1]);
                if (item == "/")
                    carpim /= double.Parse(Oncelik[a + 1]);
                Oncelik.RemoveAt(a - 1);
                a = Oncelik.IndexOf(item);
                Oncelik.RemoveAt(a + 1);
                a = Oncelik.IndexOf(item);
                Oncelik[a] = carpim.ToString();


            }
            return Oncelik;
        }
        static public List<string> ToplaCikartOncelik(List<string> Oncelik)
        {
            powHesaplaOncelik(Oncelik);
            foreach (string item in Oncelik.FindAll(x => x == "+" || x == "-"))
            {

                int a = Oncelik.IndexOf(item);
                carpim = double.Parse(Oncelik[a - 1]);
                if (item == "+")
                    carpim += double.Parse(Oncelik[a + 1]);
                if (item == "-")
                    carpim -= double.Parse(Oncelik[a + 1]);
                Oncelik.RemoveAt(a - 1);
                a = Oncelik.IndexOf(item);
                Oncelik.RemoveAt(a + 1);
                a = Oncelik.IndexOf(item);
                Oncelik[a] = carpim.ToString();



            }
            return Oncelik;
        }
        static public List<string> powHesaplaOncelik(List<string> Oncelik)
        {
            while (Oncelik.Contains("^"))
            {
                int k = Oncelik.IndexOf("^");

                string hesapla = "";
                if ((Oncelik[k + 1] != "-"))
                {

                    hesapla = Math.Pow(double.Parse(Oncelik[k - 1]), double.Parse(Oncelik[k + 1])).ToString();
                    Oncelik[k - 1] = hesapla;
                    Oncelik.RemoveRange(k, 2);
                }
                else if (hesap[k + 1] == "-")
                {
                    hesapla = Math.Pow(double.Parse(Oncelik[k - 1]), -double.Parse(Oncelik[k + 2])).ToString();
                    Oncelik[k - 1] = hesapla;
                    Oncelik.RemoveRange(k, 3);
                }
                else if (Oncelik[k - 2] == "-" && Oncelik[k + 2] == "-")
                {
                    hesapla = Math.Pow(-double.Parse(Oncelik[k - 1]), -double.Parse(Oncelik[k + 2])).ToString();
                    Oncelik[k - 2] = hesapla;
                    Oncelik.RemoveRange(k - 1, 3);
                }
                else if (hesap[k - 2] == "-")
                {
                    hesapla = Math.Pow(-double.Parse(Oncelik[k - 1]), double.Parse(Oncelik[k + 1])).ToString();
                    Oncelik[k - 2] = hesapla;
                    Oncelik.RemoveRange(k - 1, 3);
                }




            }
            return Oncelik;
        }

    }
}
