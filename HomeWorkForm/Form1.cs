using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWorkForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            girilensayiLbl.Visible = false;
            sayiLbl.Visible = false;
            ErrorLabel.Visible = false;

           
        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {
            // hata durumu kontrol i�in try-catch blo�u yazd�m hatay� bir label da g�r�nteledim.
            try {

                //Say� g�r�ntelme ekran�m� her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                say�larLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;


                //Text box a girilen de�eri tip d�n���m� ile int yapt�m i�lemlerde kulland�k
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan k���k olma durumu ve bo� data durmu i�in 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }



                //Fakt�riyel sonucunu Label ekledeim
                factorialLbl.Text = Convert.ToString(Factorial(num));



                // asall�k durumunu kontrol edip yazd�rd�m
                if (IsPrime(num))
                {
                    asalLbl.Text = " Asal Say�d�r ";
                }
                else
                {
                    asalLbl.Text = " Asal De�ildir ";
                }


                //Kendinden �nceki say�lar� yazd�rd�m
                //Bunun i�in y�m say�lar bir string de�i�kenine ekledim ve bu sayede tekte g�sterdim.
                string numbers = "";
                for (int i = 1; i <= num; i++)
                {
                    numbers += i.ToString() + " ";
                }
                say�larLbl.Text = numbers;


                //Girilen say�y� ekstra label da g�sterdik
                //BU k�smlar� butona bas�nca g�r�n�r yapt�m
                girilensayiLbl.Visible = true;
                sayiLbl.Text += inputxtxtbox.Text;
                sayiLbl.Visible = true;


                //Bir sonraki veri giri�i i�in textbox temizledik
                inputxtxtbox.Text = string.Empty;

            }
            catch (FormatException)
            {
                // D�n���m hatas� durumunda buras� �al��acak
                MessageBox.Show("Ge�ersiz formatta bir giri� yap�ld�. L�tfen do�ru formatta bir say� girin.");

            }

        }




        //Factorial Hesab� yapan buton
        private void fctrlBtn_Click(object sender, EventArgs e)
        {
            // hata durumu kontrol i�in try-catch blo�u yazd�m hatay� bir label da g�r�nteledim.
            try
            {

                //Say� g�r�ntelme ekran�m� her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                say�larLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;

                //Text box a girilen de�eri tip d�n���m� ile int yapt�m i�lemlerde kulland�k
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan k���k olma durumu ve bo� data durmu i�in 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }


                //Fakt�riyel sonucunu Label ekledeim
                factorialLbl.Text = Convert.ToString(Factorial(num));



                //Girilen say�y� ekstra label da g�sterdik
                //BU k�smlar� butona bas�nca g�r�n�r yapt�m
                girilensayiLbl.Visible = true;
                sayiLbl.Text += inputxtxtbox.Text;
                sayiLbl.Visible = true;

                //Bir sonraki veri giri�i i�in textbox temizledik
                inputxtxtbox.Text = string.Empty;


            }
            catch (FormatException)
            {
                // D�n���m hatas� durumunda buras� �al��acak
                MessageBox.Show("Ge�ersiz formatta bir giri� yap�ld�. L�tfen do�ru formatta bir say� girin.");

            }

            
        }

        //Asall�k durmunu d�nd�ren ve yazd�ran Buton
        private void asalBtn_Click(object sender, EventArgs e)
        {
            // hata durumu kontrol i�in try-catch blo�u yazd�m hatay� bir label da g�r�nteledim.
            try
            {

                //Say� g�r�ntelme ekran�m� her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                say�larLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;


                //Text box a girilen de�eri tip d�n���m� ile int yapt�m i�lemlerde kulland�k
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan k���k olma durumu ve bo� data durmu i�in 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }




                // asall�k durumunu kontrol edip yazd�rd�m
                if (IsPrime(num))
                {
                    asalLbl.Text = " Asal Say�d�r ";
                }
                else
                {
                    asalLbl.Text = " Asal De�ildir ";
                }



                //Girilen say�y� ekstra label da g�sterdik
                //BU k�smlar� butona bas�nca g�r�n�r yapt�m
                girilensayiLbl.Visible = true;
                sayiLbl.Text += inputxtxtbox.Text;
                sayiLbl.Visible = true;

                //Bir sonraki veri giri�i i�in textbox temizledik
                inputxtxtbox.Text = string.Empty;


            }
            catch (FormatException)
            {
                // D�n���m hatas� durumunda buras� �al��acak
                MessageBox.Show("Ge�ersiz formatta bir giri� yap�ld�. L�tfen do�ru formatta bir say� girin.");

            }

            
        }


        //Kendi �nceki say�lar� yazd�ran Buton
        private void sayilarBtn_Click(object sender, EventArgs e)
        {
            // hata durumu kontrol i�in try-catch blo�u yazd�m hatay� bir label da g�r�nteledim.
            try
            {
                //Say� g�r�ntelme ekran�m� her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                say�larLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;


                //Text box a girilen de�eri tip d�n���m� ile int yapt�m i�lemlerde kulland�k
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan k���k olma durumu ve bo� data durmu i�in 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "L�tfen Ge�erli Bir  Say� Giriniz";
                }

                //Kendinden �nceki say�lar� yazd�rd�m
                //Bunun i�in y�m say�lar bir string de�i�kenine ekledim ve bu sayede tekte g�sterdim.
                string numbers = "";
                for (int i = 1; i <= num; i++)
                {
                    numbers += i.ToString() + " ";
                }
                say�larLbl.Text = numbers;

            }
            catch (FormatException)
            {
                // D�n���m hatas� durumunda buras� �al��acak
                MessageBox.Show("Ge�ersiz formatta bir giri� yap�ld�. L�tfen do�ru formatta bir say� girin.");

            }
            



            //Girilen say�y� ekstra label da g�sterdik
            //BU k�smlar� butona bas�nca g�r�n�r yapt�m
            girilensayiLbl.Visible = true;
            sayiLbl.Text += inputxtxtbox.Text;
            sayiLbl.Visible = true;

            //Bir sonraki veri giri�i i�in textbox temizledik
            inputxtxtbox.Text = string.Empty;
        }




        //Recursive Factorial fonksiyonu
        static long Factorial(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }

        //IsPrime Fonksiyonu asall�k durmunu kontrol ettim
        static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                    return false;
            }

            return true;
        }
    }
}