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
            // hata durumu kontrol için try-catch bloðu yazdým hatayý bir label da görünteledim.
            try {

                //Sayý görüntelme ekranýmý her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                sayýlarLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;


                //Text box a girilen deðeri tip dönüþümü ile int yaptým iþlemlerde kullandýk
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan küçük olma durumu ve boþ data durmu için 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }



                //Faktöriyel sonucunu Label ekledeim
                factorialLbl.Text = Convert.ToString(Factorial(num));



                // asallýk durumunu kontrol edip yazdýrdým
                if (IsPrime(num))
                {
                    asalLbl.Text = " Asal Sayýdýr ";
                }
                else
                {
                    asalLbl.Text = " Asal Deðildir ";
                }


                //Kendinden önceki sayýlarý yazdýrdým
                //Bunun için yüm sayýlar bir string deðiþkenine ekledim ve bu sayede tekte gösterdim.
                string numbers = "";
                for (int i = 1; i <= num; i++)
                {
                    numbers += i.ToString() + " ";
                }
                sayýlarLbl.Text = numbers;


                //Girilen sayýyý ekstra label da gösterdik
                //BU kýsmlarý butona basýnca görünür yaptým
                girilensayiLbl.Visible = true;
                sayiLbl.Text += inputxtxtbox.Text;
                sayiLbl.Visible = true;


                //Bir sonraki veri giriþi için textbox temizledik
                inputxtxtbox.Text = string.Empty;

            }
            catch (FormatException)
            {
                // Dönüþüm hatasý durumunda burasý çalýþacak
                MessageBox.Show("Geçersiz formatta bir giriþ yapýldý. Lütfen doðru formatta bir sayý girin.");

            }

        }




        //Factorial Hesabý yapan buton
        private void fctrlBtn_Click(object sender, EventArgs e)
        {
            // hata durumu kontrol için try-catch bloðu yazdým hatayý bir label da görünteledim.
            try
            {

                //Sayý görüntelme ekranýmý her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                sayýlarLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;

                //Text box a girilen deðeri tip dönüþümü ile int yaptým iþlemlerde kullandýk
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan küçük olma durumu ve boþ data durmu için 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }


                //Faktöriyel sonucunu Label ekledeim
                factorialLbl.Text = Convert.ToString(Factorial(num));



                //Girilen sayýyý ekstra label da gösterdik
                //BU kýsmlarý butona basýnca görünür yaptým
                girilensayiLbl.Visible = true;
                sayiLbl.Text += inputxtxtbox.Text;
                sayiLbl.Visible = true;

                //Bir sonraki veri giriþi için textbox temizledik
                inputxtxtbox.Text = string.Empty;


            }
            catch (FormatException)
            {
                // Dönüþüm hatasý durumunda burasý çalýþacak
                MessageBox.Show("Geçersiz formatta bir giriþ yapýldý. Lütfen doðru formatta bir sayý girin.");

            }

            
        }

        //Asallýk durmunu döndüren ve yazdýran Buton
        private void asalBtn_Click(object sender, EventArgs e)
        {
            // hata durumu kontrol için try-catch bloðu yazdým hatayý bir label da görünteledim.
            try
            {

                //Sayý görüntelme ekranýmý her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                sayýlarLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;


                //Text box a girilen deðeri tip dönüþümü ile int yaptým iþlemlerde kullandýk
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan küçük olma durumu ve boþ data durmu için 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }




                // asallýk durumunu kontrol edip yazdýrdým
                if (IsPrime(num))
                {
                    asalLbl.Text = " Asal Sayýdýr ";
                }
                else
                {
                    asalLbl.Text = " Asal Deðildir ";
                }



                //Girilen sayýyý ekstra label da gösterdik
                //BU kýsmlarý butona basýnca görünür yaptým
                girilensayiLbl.Visible = true;
                sayiLbl.Text += inputxtxtbox.Text;
                sayiLbl.Visible = true;

                //Bir sonraki veri giriþi için textbox temizledik
                inputxtxtbox.Text = string.Empty;


            }
            catch (FormatException)
            {
                // Dönüþüm hatasý durumunda burasý çalýþacak
                MessageBox.Show("Geçersiz formatta bir giriþ yapýldý. Lütfen doðru formatta bir sayý girin.");

            }

            
        }


        //Kendi önceki sayýlarý yazdýran Buton
        private void sayilarBtn_Click(object sender, EventArgs e)
        {
            // hata durumu kontrol için try-catch bloðu yazdým hatayý bir label da görünteledim.
            try
            {
                //Sayý görüntelme ekranýmý her seferinde temizliyorum
                sayiLbl.Text = string.Empty;
                asalLbl.Text = string.Empty;
                factorialLbl.Text = string.Empty;
                sayýlarLbl.Text = string.Empty;
                ErrorLabel.Text = string.Empty;


                //Text box a girilen deðeri tip dönüþümü ile int yaptým iþlemlerde kullandýk
                string strNumber = inputxtxtbox.Text;
                int num = int.Parse(strNumber);

                // 0 dan küçük olma durumu ve boþ data durmu için 
                if (num < 0)
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }
                if (strNumber.Equals(" "))
                {
                    ErrorLabel.Visible = true;
                    ErrorLabel.Text = "Lütfen Geçerli Bir  Sayý Giriniz";
                }

                //Kendinden önceki sayýlarý yazdýrdým
                //Bunun için yüm sayýlar bir string deðiþkenine ekledim ve bu sayede tekte gösterdim.
                string numbers = "";
                for (int i = 1; i <= num; i++)
                {
                    numbers += i.ToString() + " ";
                }
                sayýlarLbl.Text = numbers;

            }
            catch (FormatException)
            {
                // Dönüþüm hatasý durumunda burasý çalýþacak
                MessageBox.Show("Geçersiz formatta bir giriþ yapýldý. Lütfen doðru formatta bir sayý girin.");

            }
            



            //Girilen sayýyý ekstra label da gösterdik
            //BU kýsmlarý butona basýnca görünür yaptým
            girilensayiLbl.Visible = true;
            sayiLbl.Text += inputxtxtbox.Text;
            sayiLbl.Visible = true;

            //Bir sonraki veri giriþi için textbox temizledik
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

        //IsPrime Fonksiyonu asallýk durmunu kontrol ettim
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