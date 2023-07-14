public class Program
{
    public static void Main(string[] args)
    {
       LivroSimpleFactory livroSimpleFactory = new LivroSimpleFactory();
       ILivroFactory livraria = livroSimpleFactory.criarLivraria("Sp");
       var livro = livraria.montarLivro("A");
       Console.WriteLine(livro.alocarLivro());
    }
}
