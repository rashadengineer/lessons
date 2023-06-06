using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Classes
{
    class Vehicle
    {
        //Marka
        //Model
        //İstehsal ili
        //Km
        //Yanacaq növü
        //Sürətlər qutusu
        //Alış qiyməti
        //Satış qiyməti
        //Max endirim məbləği
        //Qiymət(private olması mütləqdir!)


        //Constructor overload'ları aşağıdakı kimi olmalıdır:
        //        1. marka, model
        //        2. marka, model, istehsal ili
        //        3. marka, model, istehsal ili, km
        //        4. bütün property'lər

        //Əlavə olaraq iki methodunuz olacaq hansı ki, birinci method bütün məlumatları ekrana yazacaq və ikinci method isə müəyyən obyektin
        //       satış qiymətini təyin edəcək.Burda biraz baş işlətmək lazımdır. Təyin edilən qiymət, satış qiyməti - max endirim qiyməti qədər
        //       olmalıdır.Yəni, max endirim qiyməti qədər geriyə gedə bilməliyəm.
        //       Məsələn:
        //       Satış qiymətim 10 manatdırsa, maximum endirim qiymətim 2 manatdırsa, mən bu məhsulu ən aşağı 8 manata sata bilməliyəm. 7 manata
        //       satmağa çalışsam xəta mesajı yazsın ekrana (məs: Max.endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!)



        public string Marka;
        public string Model;
        public short Il;
        public int Yurus;
        public string YanacaqNovu;
        public string Suretqutu;
        public int AlisQiy;
        public int SatisQiy;
        public int Discount;
        private int UmumiQiy;

        public Vehicle(string marka,string model)
        {
            Marka = marka;
            Model = model;
        }

        public Vehicle(string marka, string model,short il)
        {
            Marka = marka;
            Model = model;
            Il = il;
        }

        public Vehicle(string marka, string model, short il,int yurus)
        {
            Marka = marka;
            Model = model;
            Il = il;
            Yurus = yurus;
        }

        public Vehicle(string marka, string model, short il, int yurus,string yanacaqNovu,string suretqutu,int alisQiy,int satisQiy,int discount,int umumiQiy)
        {
            Marka = marka;
            Model = model;
            Il = il;
            Yurus = yurus;
            YanacaqNovu = yanacaqNovu;
            Suretqutu = suretqutu;
            AlisQiy = alisQiy;
            SatisQiy = satisQiy;
            Discount = discount;
            UmumiQiy = umumiQiy;
        }

        public void AllProp()
        {

            Console.WriteLine("Marka: {0} , Model: {1}, Il: {2}, Yurus: {3} YanacaqNovu: {4}, Suretqutusu: {5}, Alisqiymeti: {6}, Satisqiymeti: {7}, Endirim: {8}, Umumiqiymeti: {9}", 
               Marka,Model,Il,Yurus,YanacaqNovu,Suretqutu,AlisQiy,SatisQiy,Discount,UmumiQiy
            );

        }

        public void SpecialOffer(int alis,int satis,int endirim)
        {
            SatisQiy = satis;
            AlisQiy = alis;
            Discount = endirim;

            int sonQiy = satis - (satis * endirim / 100);
            if (sonQiy>alis)
            {
                Console.WriteLine("Allah xeirinizi versin");
            }
            else
            {
                Console.WriteLine("Maya deyerinen assagi oldugu ucun satis ede bilmirik");
            }
        }


    }
}
