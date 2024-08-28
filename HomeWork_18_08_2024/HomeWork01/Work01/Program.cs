namespace Work01;

class Program
{
    static void Main(string[] args)
    {
        #region IntExam1
        int number1 = 5;
        int number2 = 20;

        int total = number1 + number2;
        System.Console.WriteLine($"1) {total}");
       #endregion
         
         #region DoubleExam2
         double number3 = 20.5 ;
         double Square = number3 * number3 ;

         System.Console.WriteLine(" 2) Sayının Karesi:"+ Square);

         #endregion

         #region StringandIntExam3
         string name = "Melike";
         int age = 18;
         System.Console.WriteLine($"3) Benim adım {name} ve ben {age} yaşındayım" );
            
         #endregion

         #region CharIntExam4
            char letter = 'M';
            int ascııvalue = (int)letter;
            System.Console.WriteLine($"4) {letter} harfinin ASCII değeri: {ascııvalue}");
         #endregion

         #region BoolExam5
         bool exam01 = true ;
         bool exam02 = false;

         System.Console.WriteLine($" 5) Örnek1: {exam01} ");
         System.Console.WriteLine($" 5) Örnek2: {exam02} ");
         #endregion

         #region ByteIntExam6
         Byte studentPoint = 255;
         int studentPoint2 = studentPoint;
         System.Console.WriteLine($"6) {studentPoint2}");
        #endregion

        #region IntByteExam7
        int numberOfBooks = 20000000;
        byte numberOfBooks2 = (byte)numberOfBooks;
        System.Console.WriteLine($"7) {numberOfBooks2} çıkmasının nedeni C# dilinde bir int tipindeki değişkeni byte tipine dönüştürmeye çalışırken, bu dönüşüm doğrudan yapılabilirse de, veri kaybı riski vardır. byte veri türü 0 ile 255 arasında değerleri temsil edebilirken, int veri türü çok daha geniş bir aralık sunar (-2,147,483,648 ile 2,147,483,647 arasında). Bu nedenle, int tipindeki büyük bir sayıyı byte tipine dönüştürmeye çalışırken, veri kaybı meydana gelebilir.int değerini byte tipine dönüştürdüğümüzde, byte türünün aralığını aşan değerler döngüsel olarak hesaplanır. byte türü 0 ile 255 arasında değerleri temsil edebilir, bu nedenle 20000000 değeri mod 256 (byte'ın kapasitesi) hesaplanarak döndürülür. 20000000 % 256 = 176 olduğu için, byte tipindeki byteDeger değişkeni 176 olarak hesaplanır. Bu, dönüşüm sırasında büyük sayının sadece byte türünün alabileceği aralıkta kalan kısmıdır.");
            
        #endregion

        #region DoubleIntExam8
        double songDuration =3.14;
        int song = (int)songDuration;
        System.Console.WriteLine($"8) Ondalıklı sayı şeklinde {songDuration}");
        System.Console.WriteLine($"8) Tam sayı hali {song}");
        System.Console.WriteLine("8) Double tipinden int tipine dönüşüm yapıldığında, ondalık kısmı (.14) kaybolur ve sadece tam sayı kısmı (3) saklanır. Bu nedenle, int tipindeki piTamSayi değişkeni 3 değerine sahip olur.");
        #endregion

        #region StringIntExam9
        string glass = "35";
        int parseGlass = int.Parse(glass);
        System.Console.WriteLine($"9) {parseGlass}");
            
        #endregion

        #region IntDoubleExam10
        int sisterAge = 5;
        int brotherAge = 10;
        int momAge = 15;
        double average = (sisterAge + brotherAge + momAge) /3.0;
        System.Console.WriteLine($"10) {average}");
        #endregion

        #region DecimalExam11
        decimal abdDolar = 34.03m;
        decimal pound = 44.95m;
        decimal total2 = abdDolar + pound ;
        System.Console.WriteLine($"11) Toplam Para Miktari :{total2}");
        #endregion

        #region FloatDoubleExam12
        float turkishLira = 1.23f;
        double turkishLira2 = turkishLira;
        System.Console.WriteLine($"12) float tipinde değerimiz{turkishLira}");
        System.Console.WriteLine($"12) double tipinde değerimiz {turkishLira2}");
        #endregion

        #region LongIntExam13
        long populationNumber = 999999999999999999;
        int populationNumber2 = (int)populationNumber;
        System.Console.WriteLine($"13) değerimiz bu şekildedir {populationNumber2}");
        #endregion

        #region StringExam14
        string name2 = "Melike";
        string lastName = " Gül";
        string nameAndSurname = name2 + lastName ;
        System.Console.WriteLine($"14) {nameAndSurname}");
        #endregion

        #region StringBoolExam15
        string trial = "true";
        bool trial2 = bool.Parse(trial);
        System.Console.WriteLine($"15) String hali: {trial}");
        System.Console.WriteLine($"15) bool hali:{trial2}");
            
        #endregion

        #region DoubleFloatExam16
        double piNumber = 3.14159 ;
        float pinumber2 = (float)piNumber;
        System.Console.WriteLine($"16) {pinumber2}");
        #endregion

        #region ByteShortIntLongAndSizeOfResearchExam17
        byte number4 = 10;
        short number5 = 10;
        int number6 = 10;
        long number7 = 10;
        Console.WriteLine($"17) byte tipindeki değişkenin bellekte kapladığı alan: {sizeof(byte)} bayt");
        Console.WriteLine($"17)short tipindeki değişkenin bellekte kapladığı alan: {sizeof(short)} bayt");
        Console.WriteLine($"17)int tipindeki değişkenin bellekte kapladığı alan: {sizeof(int)} bayt");
        Console.WriteLine($"17)long tipindeki değişkenin bellekte kapladığı alan: {sizeof(long)} bayt");
        System.Console.WriteLine("17) C# dilinde sizeof() operatörü, belirli veri türlerinin bellekte kapladığı alanı bayt cinsinden döndürür. Bu operatör, temel veri türlerinin boyutlarını belirlemek için kullanılır. sizeof() operatörü, sadece unsafe kod bloklarında kullanılabilir, ancak System.Runtime.InteropServices.Marshal sınıfı ve sizeof operatörü birlikte kullanılarak güvenli bir şekilde veri türlerinin boyutları öğrenilebilir.");
         #endregion

        #region StringIntLengthExam18
        string sentence = "Bugün hava çok güzel";
        int wordsNumber =sentence.Length;
        System.Console.WriteLine($"18) kurduğum cümlenin kelime sayısı{wordsNumber}");
        System.Console.WriteLine("18) sentence.Length özelliği kullanılarak bu string'in karakter sayısı alındı ve wordsNumber adlı int tipinde bir değişkene atandı. Bu özellik, string'deki karakterlerin sayısını döndürür.");
            
        #endregion
    
    
    }
            
}

