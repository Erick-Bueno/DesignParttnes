public sealed class LivroSimpleFactory
{
    public ILivros criarLivro(string livro){
        ILivros livros;
        if (livro.Equals("A")){
            livros = new Aventura();
            return livros;
        }
        if(livro.Equals("F")){
            livros = new Ficcao();
            return livros;
        }
        throw new Exception("livro não encontrado");
    }
}