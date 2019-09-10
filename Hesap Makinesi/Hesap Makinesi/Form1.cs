using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;


namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        List<string> hesap = new List<string>();
        List<string> Oncelik = new List<string>();
        char[] istisna;
        int k3 = 0;
        int Parantez = 0;


        int parantez = 0;
        char virgul=' ';
        //Dört İŞLEM
        //Çarpma
        private void button13_Click(object sender, EventArgs e)
        {
            
            try {
                istisna = textBox1.Text.ToCharArray();
                int sayac = 0;
                for (int i = k3; i < istisna.Length; i++)
                {
                    if (istisna[i] == ',')
                        sayac++;
                }
                if (char.IsDigit(istisna[istisna.Length - 1]) && istisna[istisna.Length - 1] != 'x' || istisna[istisna.Length - 1] == ')' || istisna[istisna.Length - 1] == 'e' || istisna[istisna.Length - 1] == 'π')
                {

                    textBox1.Text += "x";


                    if (sayac != 0)
                        Virgul();
                }
                k3 = istisna.Length - 1;


                if (!char.IsDigit(istisna[0]) && istisna[0] != '(')
                {

                    if (istisna[0] != '-' && istisna[0] != 'π' && istisna[0] != 'e' && istisna[0] != 'S' && istisna[0] != 'T' && istisna[0] != 'l' && istisna[0] != 'C')
                        textBox1.Text = "";
                    else if (textBox2.Text != "")
                    {
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = "";
                        textBox1.Text += "x";
                        virgul = ' ';
                    }

                }
                else if (textBox2.Text != "")
                {
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = "";
                    textBox1.Text += "x";
                    virgul = ' ';
                }
             
            }
            catch (IndexOutOfRangeException)
            {
                
            }
        }
        //Toplama
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {

                istisna = textBox1.Text.ToCharArray();
                int sayac = 0;
                for (int i = k3; i < istisna.Length; i++)
                {
                    if (istisna[i] == ',')
                        sayac++;
                }
                if (char.IsDigit(istisna[istisna.Length - 1]) && istisna[istisna.Length - 1] != '+' || istisna[istisna.Length - 1] == ')'|| istisna[istisna.Length - 1] == 'e'|| istisna[istisna.Length - 1] == 'π')
                {

                    textBox1.Text += "+";


                    if (sayac != 0)
                        Virgul();
                }
                k3 = istisna.Length - 1;

                if (!char.IsDigit(istisna[0]) && istisna[0] != '(')
                {

                    if (istisna[0] != '-'&& istisna[0]!= 'π' && istisna[0] != 'e'&&istisna[0]!='S'&& istisna[0] != 'T'&& istisna[0] != 'l'&& istisna[0] != 'C')
                        textBox1.Text = "";
                    else if (textBox2.Text != "")
                    {
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = "";
                        textBox1.Text += "+";
                        virgul = ' ';
                    }

                }
                else if (textBox2.Text != "")
                {
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = "";
                    textBox1.Text += "+";
                       virgul = ' ';
                }
              
            }
            catch (IndexOutOfRangeException)
            {

            }
        }
        //Cikartma
        private void button11_Click(object sender, EventArgs e)
        {

            try
            {

                istisna = textBox1.Text.ToCharArray();
                int sayac = 0;
                for (int i = k3; i < istisna.Length; i++)
                {
                    if (istisna[i] == ',')
                        sayac++;
                }
                if (istisna[istisna.Length - 1] != '-' || istisna[istisna.Length - 1] == ')')
                {
                    if (istisna[istisna.Length - 1] != '+' && istisna[istisna.Length - 1] != 'x' && istisna[istisna.Length - 1] != '/' || istisna[istisna.Length - 1] == 'e' || istisna[istisna.Length - 1] == 'π')
                        textBox1.Text += "-";


                    if (sayac != 0)
                        Virgul();
                }
             
                
                   
                
                k3 = istisna.Length - 1;


                if (!char.IsDigit(istisna[0]) && istisna[0] != '(')
                {
                    if (istisna[0] != '-' && istisna[0] != 'π' && istisna[0] != 'e' && istisna[0] != 'S' && istisna[0] != 'T' && istisna[0] != 'l' && istisna[0] != 'C')
                        textBox1.Text = "";
                    else if (textBox2.Text != "")
                    {
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = "";
                        textBox1.Text += "-";
                        virgul = ' ';
                    }


                }
     
                else if (textBox2.Text != "")
                {
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = "";
                    textBox1.Text += "-";
                    virgul = ' ';
                }


                


            }
            catch (IndexOutOfRangeException)
            {

            }

        }
        //Bölme
        private void button12_Click(object sender, EventArgs e)
        {

            try
            {

                istisna = textBox1.Text.ToCharArray();
                int sayac = 0;
                for (int i = k3; i < istisna.Length; i++)
                {
                    if (istisna[i] == ',')
                        sayac++;
                }
                if (char.IsDigit(istisna[istisna.Length - 1]) && istisna[istisna.Length - 1] != '/' || istisna[istisna.Length - 1] == ')' || istisna[istisna.Length - 1] == 'e' || istisna[istisna.Length - 1] == 'π')
                {

                    textBox1.Text += "/";


                    if (sayac != 0)
                    {
                        
                        Virgul();
                        
                    }
                     
                }
                k3 = istisna.Length - 1;
                if (!char.IsDigit(istisna[0]) && istisna[0] != '(')
                {

                    if (istisna[0] != '-' && istisna[0] != 'π' && istisna[0] != 'e' && istisna[0] != 'S' && istisna[0] != 'T' && istisna[0] != 'l' && istisna[0] != 'C')
                        textBox1.Text = "";
                    else if (textBox2.Text != "")
                    {
                        textBox1.Text = textBox2.Text;
                        textBox2.Text = "";
                        textBox1.Text += "/";
                        virgul = ' ';
                    }

                }
                else if (textBox2.Text != "")
                {
                    textBox1.Text = textBox2.Text;
                    textBox2.Text = "";
                    textBox1.Text += "/";
                    virgul = ' ';
                }
               
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            virgul = ' ';

        }

        private void ClickToplu(object sender, EventArgs e)
        {
          



            textBox1.Text += (sender as Button).Text;

            istisna = textBox1.Text.ToCharArray();
            
            if(istisna.Length>1)
            {
                if (istisna[istisna.Length - 2] == ')'|| istisna[istisna.Length - 2] == 'e'|| istisna[istisna.Length - 2] == 'π')
                    istisna[istisna.Length - 1] = '\0';
            }
            textBox1.Clear();
            foreach (char item in istisna)
            {
                textBox1.Text += item;
            }
              



            if (textBox1.Text[textBox1.Text.Length - 1] == ',')
            {
                
                Virgul();
               
            }
            
            

        }

        
        //Hesapla
        private void button14_Click(object sender, EventArgs e)
        {
             hesap=hesaplamIslemleri.SayiListesi(textBox1.Text);

            
           

            try
            {
               
                
                while (hesap.Contains("("))
                {
                    
                    int y = hesap.LastIndexOf("(");
                    int sayi = 0;
                    for (sayi = y; hesap[sayi]!=")"; sayi++)
                    {

                    }
                   
                   

                    for (int i = y + 1; i < sayi; i++)
                    {
                        Oncelik.Add(hesap[i].ToString());
                    }
                    for (int i = y + 1; sayi - y != 1;)
                    {
                        hesap.RemoveAt(i);
                        sayi--;
                        y = hesap.LastIndexOf("(");
  
                    }

                    Oncelik=hesaplamIslemleri.CarpBolOncelik(Oncelik);
                    Oncelik = hesaplamIslemleri.ToplaCikartOncelik(Oncelik);

                    y = hesap.LastIndexOf("(");
                    hesap.RemoveAt(y+1);
                    y = hesap.LastIndexOf("(");
                    hesap[y] = Oncelik[0];





                    Oncelik.RemoveRange(0, Oncelik.Count);
                }
                hesap=ozelislemler.powHesapla(hesap);
                if (hesap.Contains("+") || hesap.Contains("/") || hesap.Contains("x") || hesap.Contains("-"))
                {
                    hesap=hesaplamIslemleri.CarpBol(hesap);
                    hesap = hesaplamIslemleri.ToplaCikart(hesap); 
                }
                virgul = ' ';
                textBox2.Text = hesap[0];



            }
            catch (ArgumentOutOfRangeException) { }




            }
            

       

        

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            groupBox1.Visible = false;

        }
        

       

        private void button17_Click(object sender, EventArgs e)
        {



            
            istisna = textBox1.Text.ToCharArray();
            try
            {
                if (textBox1.Text != "")
                {
                    if (istisna[istisna.Length - 1] != '(' && !char.IsDigit(istisna[istisna.Length - 1])&& istisna[istisna.Length - 1]!=')' && istisna[istisna.Length - 1] != ',')
                    {
                        textBox1.Text += "(";
                        istisna = textBox1.Text.ToCharArray();
                        parantez++;

                    }
                }
                else
                {

                    textBox1.Text += "(";
                        parantez++;
                }
                
            }
            catch (IndexOutOfRangeException) { }

            Parantez = parantez;


         

        }

        private void button18_Click(object sender, EventArgs e)
        {

            List<char> istisna1 = new List<char>();
            char[] istisna2;

            istisna2 = textBox1.Text.ToCharArray();

             
         
                if (parantez != 0)
                {

                    textBox1.Text += ')';

                    istisna2 = textBox1.Text.ToCharArray();

                    for (int i = textBox1.Text.IndexOf('('); i < textBox1.Text.Length; i++)
                    {
                        istisna1.Add(istisna2[i]);

                    }

                    int sayac = istisna1.Count;
                    for (int i = 0; i < sayac; i++)
                    {
                        if (istisna1[i] == '-')
                            if (istisna1[i - 1] == '(')
                                istisna1.Insert(i, '0');
                    }
                
                    if (istisna1.Contains('+') || istisna1.Contains('-') || istisna1.Contains('/') || istisna1.Contains('x') || istisna1.Contains('^'))
                    {
                        if ((!char.IsDigit(istisna1[1])|| istisna1[1]=='C'|| istisna1[1]=='S'|| istisna1[1] =='T'|| !char.IsDigit(istisna1[istisna1.IndexOf(')') - 1]))&& (istisna1[1]!='e'&& istisna1[1] != 'π'))
                        {
                           
                                istisna2[istisna2.Length - 1] = '\0';

                        }
                    }
                   if (istisna2[istisna2.Length - 1] ==')'|| parantez!=0)
                    {
                    if (istisna2.Length > 1)
                        if (istisna2[istisna2.Length - 2] == '(')
                        {
                            istisna2[istisna2.Length - 1] = '\0';
                        }else
                            parantez--;
                    

                }
                    else
                        istisna2[istisna2.Length - 1] = '\0';
                }
            try
            {
            }
            catch (IndexOutOfRangeException) { }
            catch (ArgumentOutOfRangeException) { }
            {
              

                textBox1.Text = "";
                foreach (char item in istisna2)
                {
                    textBox1.Text += item;
                }
            }
        }
        //Sil
       private void button19_Click(object sender, EventArgs e)
       {
            char[] sil = textBox1.Text.ToCharArray();

            textBox1.Text = "";
            if (sil[sil.Length - 1] == ')')
            {
                parantez++;
            }
            else if (sil[sil.Length - 1] == '(')
                parantez--;
            else if (sil[sil.Length - 1] == ',')
                virgul = ' ';
            sil[sil.Length - 1]='\0';
            foreach (char del in sil)
            {
                textBox1.Text += del;
            }
        }
        //Virgül istisna
        public void Virgul() {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == ",")
                textBox1.Text = "";
            else
            if (istisna[istisna.Length - 1] == ','|| istisna[istisna.Length - 1] == '+' || istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == 'x')
            {
                
                if ((istisna[istisna.Length - 2] == '+'|| istisna[istisna.Length - 2] == 'x'|| istisna[istisna.Length - 2] == '/'|| istisna[istisna.Length - 2] == '-') && istisna[istisna.Length - 1] == ','|| istisna[istisna.Length - 2] == '(')
                    istisna[istisna.Length - 1] = '\0';
                if (istisna.Length != 0)
                {

                    if (virgul == ',')
                    {
                        if (istisna[istisna.Length - 1] == '+'|| istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == 'x')
                        {
                            virgul = ' ';
                        }

                        else if (!char.IsDigit(istisna[istisna.Length - 1]))
                            istisna[istisna.Length - 1] = '\0';


                    }
                    else if (virgul == ' ')
                    {
                        if (char.IsDigit(istisna[istisna.Length - 2]))
                        {
                            virgul = ',';
                        }



                    }
                }
                else if (istisna[istisna.Length - 1] == ',')
                {
                    istisna[istisna.Length - 1] = '\0';
                    virgul = ' ';
                }
          
                textBox1.Text = "";
                foreach (char item in istisna)
                {
                    textBox1.Text += item;
                }
            }
                
        }

        private void button21_Click(object sender, EventArgs e)
        {

            istisna = textBox1.Text.ToCharArray();
            if (textBox2.Text != "")
            {
                textBox1.Text = textBox2.Text;
                textBox2.Text = "";

                virgul = ' ';
            }
            if (istisna.Length > 0)
            {
                if(char.IsDigit(istisna[istisna.Length - 1])|| istisna[istisna.Length - 1]=='e'|| istisna[istisna.Length - 1] == 'π'|| istisna[istisna.Length - 1] == ')')
                textBox1.Text += "^";
                virgul = ' ';
                
            }

        }
       
       
        private void button22_Click(object sender, EventArgs e)
        {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == "")
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Sin(";
            }else
            if (istisna[istisna.Length-1]=='+' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == 'x' || istisna[istisna.Length - 1] == '(')
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Sin(";
            }
           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == "")
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Cos(";
            }
            else
             if (istisna[istisna.Length - 1] == '+' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == 'x'|| istisna[istisna.Length - 1] == '(')
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Cos(";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == "")
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Tan(";
            }
            else
            if (istisna[istisna.Length - 1] == '+' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == 'x' || istisna[istisna.Length - 1] == '(')
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Tan(";
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == "")
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Cot(";
            }
            else
            if (istisna[istisna.Length - 1] == '+' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == 'x' || istisna[istisna.Length - 1] == '(')
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "Cot(";
            }
        }
       
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void basitHesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            this.Height = 367;
            this.Width = 304;
            textBox1.Width = 261;
            textBox2.Width = 131;
        }

        private void bilimselHesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = 367;
            this.Width = 472;
            textBox1.Width = 428;
            textBox2.Width = 298;
            groupBox1.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == "")
            {
                textBox1.Text += "π";
            }
            else
                if (istisna[istisna.Length - 1] == '+' || istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == 'x' || istisna[istisna.Length - 1] == '(' || istisna[istisna.Length - 1] == 'x' || istisna[istisna.Length - 1] == '(' || istisna[istisna.Length - 1] == '^')
                textBox1.Text += "π";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == "")
            {
                textBox1.Text += "e";
            }else
                if(istisna[istisna.Length-1]=='+'|| istisna[istisna.Length - 1] == '/'|| istisna[istisna.Length - 1] == '-'|| istisna[istisna.Length - 1] == 'x'||istisna[istisna.Length - 1] == '('|| istisna[istisna.Length - 1] == '^')
                 textBox1.Text += "e";
        }
     

        private void button28_Click(object sender, EventArgs e)
        {
            istisna = textBox1.Text.ToCharArray();
            if (textBox1.Text == "")
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "ln(";
            }
            else
            if (istisna[istisna.Length - 1] == '+' || istisna[istisna.Length - 1] == '-' || istisna[istisna.Length - 1] == '/' || istisna[istisna.Length - 1] == 'x')
            {
                parantez++;
                Parantez = parantez;
                textBox1.Text += "ln(";
            }
        }
        public void hata()
        {
          
            textBox2.Text ="Tanımsız";
        }
    }
}



