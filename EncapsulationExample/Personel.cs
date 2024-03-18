using System;

namespace EncapsulationExample
{
    public class Personel
    {
        private string tcKimlikNo;

        public string TCKIMLIKNO
        {
            get
            {
                return tcKimlikNo.Substring(0, 5) + "******";
            }

            set
            {
                bool kontrol = false;

                if (value.Length == 11)
                {
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool sayiMi = char.IsNumber(value[i]);

                        if (sayiMi)
                        {

                        }
                        else
                        {
                            kontrol = true;
                            break;
                        }
                    }

                    if (kontrol)
                    {
                        Console.WriteLine("TC kimlik numaranızda geçersiz karakter bulundu!");
                    }
                    else
                    {
                        tcKimlikNo = value;
                    }
                    
                }
                else
                {
                    Console.WriteLine("Girdiğiniz TC kimlik no 11 karakter değildir!");
                }
            }
        }
    }
}
