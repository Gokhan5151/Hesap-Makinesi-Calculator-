using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Hesap_Makinesi
{
    class ozelislemler
    {
        static char[] istisna;
        public static string trigonometrikIfadeler(string textBox)
        {

            string sayi = "";
            ArrayList dizi = new ArrayList();
            istisna = textBox.ToCharArray();
            foreach (char item in istisna)
            {
                dizi.Add(item.ToString());
            }
            try
            {
                while (dizi.Contains("i") || dizi.Contains("s") || dizi.Contains("T") || dizi.Contains("t"))
            {
                
                    if (dizi.Contains("i"))
                    {
                        int sin = dizi.IndexOf("i");
                        int i = 0;
                        for (i = sin - 1; Convert.ToChar(dizi[i]) != ')'; i++)
                        {
                            if (char.IsDigit(Convert.ToChar(dizi[i])))
                                sayi += dizi[i];
                        }
                        double hesapla;
                        hesapla = Math.PI * int.Parse(sayi) / 180;
                        hesapla = Math.Sin(hesapla);
                        for (int j = sin; Convert.ToChar(dizi[sin]) != ')'; j++)
                        {
                            dizi.RemoveAt(sin);
                        }
                        dizi.RemoveAt(sin);
                        dizi[sin - 1] = hesapla.ToString();
                        if (hesapla < 0)
                            dizi.Insert(sin - 1, "0");
                        sayi = "";

                    }
                    else if (dizi.Contains("s"))
                    {
                        int cos = dizi.IndexOf("s");
                        int i = 0;
                        for (i = cos - 2; Convert.ToChar(dizi[i]) != ')'; i++)
                        {
                            if (char.IsDigit(Convert.ToChar(dizi[i])))
                                sayi += dizi[i];
                        }
                        double hesapla;
                        if (int.Parse(sayi) == 90)
                            hesapla = 0;
                        else
                        {
                            hesapla = Math.PI * int.Parse(sayi) / 180;
                            hesapla = Math.Cos(hesapla);
                        }



                        for (; Convert.ToChar(dizi[cos - 2 + 1]) != ')';)
                        {
                            dizi.RemoveAt(cos - 2 + 1);
                        }
                        dizi.RemoveAt(cos - 2 + 1);
                        dizi[cos - 2] = hesapla.ToString();
                        if (hesapla < 0)
                            dizi.Insert(cos - 2, "0");
                        sayi = "";
                    }
                    else if (dizi.Contains("T"))
                    {
                        int tan = dizi.IndexOf("T");
                        int i = 0;
                        for (i = tan; Convert.ToChar(dizi[i]) != ')'; i++)
                        {
                            if (char.IsDigit(Convert.ToChar(dizi[i])))
                                sayi += dizi[i];
                        }
                        if (int.Parse(sayi) == 90)
                        {
                            i = 0;
                            i = i / i;
                        }
                        double hesapla = Math.PI * int.Parse(sayi) / 180;
                        hesapla = Math.Sin(hesapla) / Math.Cos(hesapla);


                        for (int j = tan + 1; Convert.ToChar(dizi[tan + 1]) != ')'; j++)
                        {
                            dizi.RemoveAt(tan + 1);
                        }
                        dizi.RemoveAt(tan + 1);
                        dizi[tan] = hesapla.ToString();
                        if (hesapla < 0)
                            dizi.Insert(tan, "0");
                        sayi = "";
                    }
                    else if (dizi.Contains("t"))
                    {
                        int cot = dizi.IndexOf("t");
                        int i = 0;
                        for (i = cot - 2; Convert.ToChar(dizi[i]) != ')'; i++)
                        {
                            if (char.IsDigit(Convert.ToChar(dizi[i])))
                                sayi += dizi[i];
                        }
                        double hesapla = Math.PI * int.Parse(sayi) / 180;
                        hesapla = Math.Cos(hesapla) / Math.Sin(hesapla);
                        if (int.Parse(sayi) == 0)
                        {
                            
                            i = 0;
                            i = i / i;
                        }
                           

                   

                        for (int j = cot - 2 + 1; Convert.ToChar(dizi[cot - 2 + 1]) != ')'; j++)
                        {
                            dizi.RemoveAt(cot - 2 + 1);
                        }
                        dizi.RemoveAt(cot - 2 + 1);
                        dizi[cot - 2] = hesapla.ToString();
                        if (hesapla < 0)
                            dizi.Insert(cot - 2, "0");
                        sayi = "";
                    }
             
                
                    
                

            }
           }
             catch (DivideByZeroException)
            {
                Form1 hata = new Form1();
                hata.hata();
            }
            textBox = "";
            foreach (string item in dizi)
            {
                textBox += item;
            }
            dizi.RemoveRange(0, dizi.Count);
            return textBox;
        }


        public static string lnHesap(string lnText)
        {
            string sayi = "";
            ArrayList dizi = new ArrayList();
            istisna = lnText.ToCharArray();
            foreach (char item in istisna)
            {
                dizi.Add(item.ToString());
            }
            while (dizi.Contains("l"))
            {
                int ln = dizi.IndexOf("l");
                int i = 0;
                for (i = ln; Convert.ToChar(dizi[i]) != ')'; i++)
                {
                    if (char.IsDigit(Convert.ToChar(dizi[i])))
                        sayi += dizi[i];
                    else if (dizi[i].ToString() == "e")
                        sayi += dizi[i];
                }
                double hesapla = 0;
                if (sayi == "e")
                {
                    hesapla = 1;
                }
                else
                    hesapla = Math.Log(double.Parse(sayi)) / Math.Log(Math.E);



                for (int j = ln + 1; Convert.ToChar(dizi[ln + 1]) != ')'; j++)
                {
                    dizi.RemoveAt(ln + 1);
                }
                dizi.RemoveAt(ln + 1);
                dizi[ln] = hesapla.ToString();
                if (hesapla < 0)
                    dizi.Insert(ln, "0");
                sayi = "";
            }
            lnText = "";
            foreach (string item in dizi)
            {
                lnText+= item;
            }
            dizi.RemoveRange(0, dizi.Count);
            return lnText;
        }



        public static string ePi(string textBox1)
        {
            ArrayList ePi = new ArrayList();
            istisna = textBox1.ToCharArray();
            foreach (char item in istisna)
            {
                ePi.Add(item);
            }
            for (int i = 0; i < ePi.Count; i++)
            {
                if (ePi[i].ToString() == "π")
                {
                    ePi[i] = Math.PI;
                }
                else if (ePi[i].ToString() == "e")
                    ePi[i] = Math.E;
            }
            textBox1 = "";
            for (int j = 0; j < ePi.Count; j++)
            {
                textBox1+= ePi[j];
            }
            return textBox1;
        }


        public static List<string> powHesapla(List<string> hesap)
        {

            while (hesap.Contains("^"))
            {
                int k = hesap.IndexOf("^");

                string hesapla = "";
                if ((hesap[k + 1] != "-"))
                {

                    hesapla = Math.Pow(double.Parse(hesap[k - 1]), double.Parse(hesap[k + 1])).ToString();
                    hesap[k - 1] = hesapla;
                    hesap.RemoveRange(k, 2);
                }
                else if (hesap[k + 1] == "-")
                {
                    hesapla = Math.Pow(double.Parse(hesap[k - 1]), -double.Parse(hesap[k + 2])).ToString();
                    hesap[k - 1] = hesapla;
                    hesap.RemoveRange(k, 3);
                }
                else if (hesap[k - 2] == "-" && hesap[k + 2] == "-")
                {
                    hesapla = Math.Pow(-double.Parse(hesap[k - 1]), -double.Parse(hesap[k + 2])).ToString();
                    hesap[k - 2] = hesapla;
                    hesap.RemoveRange(k - 1, 3);
                }
                else if (hesap[k - 2] == "-")
                {
                    hesapla = Math.Pow(-double.Parse(hesap[k - 1]), double.Parse(hesap[k + 1])).ToString();
                    hesap[k - 2] = hesapla;
                    hesap.RemoveRange(k - 1, 3);
                }




            }
            return hesap;
        }
    }
}
