int bu_yil = Convert.ToInt32(DateTime.Now.Year);
Console.Write("Doğum yılınızı girin: ");
int dogum_yılı = Convert.ToInt16(Console.ReadLine());
int yas;
yas = bu_yil - dogum_yılı;
Console.Write("Yaşınız= {0}", yas);
Console.ReadKey();