public class Program
{
    public static void Main(string[] args)
    {
        var s1 = AppSettings.getInstance();
        var s2 = AppSettings.getInstance();

        s1.name = "erick";
        Console.WriteLine(s2.name);
    
    }
}
