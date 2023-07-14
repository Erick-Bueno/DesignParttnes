public class LivroSimpleFactory
{
    public ILivroFactory criarLivraria(string local){
        if(local == "Sp"){
            return new LivroFactorySp();
        }
        if(local == "Rj"){
            return new LivroFactoryRj();
        }
        throw new Exception("livraria não encontrada");
    }
}