using Homework_Extentions_;

class Program
{
    public static void Main(string[] args)
    {
        //bool intResult = StringExtension.IsNumber("1214");
        //Console.WriteLine("Int result: " + intResult);
        //bool dateResult = StringExtension.IsDate("11-11-2000");
        //Console.WriteLine("Date result: " + dateResult);
        //string[] tempArr = "erter sf sag".ToWords();
        //for (int i = 0; i < tempArr.Length; i++)
        //{
        //    Console.Write(tempArr[i] + ", ");
        //}
        StringExtension.CalculateHash("sha256");

        //string plainText = "secret message";
        //string key = "very secret key";
        //string iv = "unique init vect";

        //// Encrypt the plain text
        //string encrypted = StringExtension.Encrypt(plainText, key, iv);
        //Console.WriteLine("Encrypted: " + encrypted);

        //// Decrypt the encrypted text
        //string decrypted = StringExtension.Decrypt(encrypted, key, iv);
        //Console.WriteLine("Decrypted: " + decrypted);
        //Console.WriteLine(0.5.ToPercent()); 
        //Console.WriteLine(235.64.RoundDown());
        //Console.WriteLine(3252.236236.ToDecimal());
        //4.50.IsGreater();
        //4.50.IsLess();
        //DateTime time = DateTime.Now.AddDays(4);
        //Console.WriteLine(time.Min(DateTime.Now.AddDays(3))); 
        //DateTime time = DateTime.Now.AddDays(4);
        //Console.WriteLine(time.Min(DateTime.Now.AddDays(3)));
        //var time = DateTime.Now;
        //Console.WriteLine(time.BeginingOfMonth());
        //Console.WriteLine(time.EndingOfMonth());
    }
}
