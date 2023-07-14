public class Program{

    public static void Main(string[] args){
        LivroSimpleFactory livro = new LivroSimpleFactory();
       
        var livros = livro.criarLivro("A");
        Console.Write(livros.alocarLivro());
    }
}
