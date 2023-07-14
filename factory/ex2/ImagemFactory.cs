public class ImagemFactory : IFactory
{
    public IImage criarImagem(string tipo)
    {
        if(tipo.Equals("p")){
            return new Png();
        }
        if(tipo.Equals("j")){
            return new Jpg();
        }
        throw new Exception("Tipo de imagem não suportado");
    } 
}