public class LivroFactorySp : ILivroFactory
{
    public ILivro criarLivro(string tipo)
    {
       if(tipo.Equals("A")){
        return new AventuraSp();
       }
       if(tipo.Equals("F")){
        return new FiccaoSp();
       }
       throw new Exception("livro não encontrado");
    }

    public ILivro montarLivro(string tipo)
    {
        ILivro livro;
        livro = criarLivro(tipo);
        return livro;
    }
}