public class Program2
{
    public static void Main(string[] args)
    {
        ImagemFactory imagemFactory = new ImagemFactory();
        IImage image = imagemFactory.criarImagem("j");
        Console.WriteLine(image.criarImagem());
    }
}