namespace Amazonia.DAL
{
    public class Dimensoes
    {
    //Largura em cm
        public float Largura { get; set; }

    //Altura em cm
     public float Altura { get; set; }

    //Profundidade em cm
        public float Profundidade { get; set; }

    //Peso em gramas
     public float Peso { get; set; }

     public float Volume => Largura * Altura * Profundidade;
    }  
}
