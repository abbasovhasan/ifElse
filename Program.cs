namespace IfElseTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int GPU;
            GPU = int.Parse(s: Console.ReadLine());
            if (GPU >= 91 && GPU <= 100)
            {
                Console.WriteLine("A");
            }
            else if (GPU >= 51 && GPU < 91)
            {
                Console.WriteLine("B");
            }
            else if (GPU >= 0 && GPU < 51)
            {
                Console.WriteLine("Kesir imtahani Salam gonderir");
            }
        }
    }
    #region Tasklar
/*    
int num;
    num = int.Parse(Console.ReadLine());
if (num % 2 == 0)
{
    Console.WriteLine("Even");
}
else
{
    Console.WriteLine("Odd");
}





int num;
num = int.Parse(Console.ReadLine());
if (num > 0)
{
    Console.WriteLine(num + " musbetdir");
}
else
{
    Console.WriteLine(num + " menfidir");
}
*/
    #endregion
}
