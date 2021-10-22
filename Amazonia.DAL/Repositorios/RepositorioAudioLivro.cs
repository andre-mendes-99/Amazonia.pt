using System;
using System.Collections.Generic;
using System.Linq;
using Amazonia.DAL.Entidades;
using Amazonia.DAL.Repositorios;

public class RepositorioAudioLivro : IRepositorio<AudioLivro>
{
    private List<AudioLivro> Lista;

    public RepositorioAudioLivro()
    {
        Lista = new List<AudioLivro>();
          
        var lotrAud = new AudioLivro
        {
            Nome = "O Senhor dos Aneis",
            Autor = "J.R.R. Tolkien",
            FormatoFicheiro ="audio",
            DuracaoLivro = 120
        };
        Lista.Add(lotrAud);

        
    }
  public void Apagar(AudioLivro obj)
    {
        Lista.Remove(obj);
    }

    public AudioLivro Atualizar(string nomeAntigo, string nomeNovo)
    {
        var temp = ObterPorNome(nomeAntigo);
        temp.Nome = nomeNovo;

        return temp;
    }

    public void Criar(AudioLivro obj)
    {
        Lista.Add(obj);
    }

    public AudioLivro ObterPorNome(string Nome)
    {
        Console.WriteLine("ObterPorNome");
        var resultado = Lista
                        .Where(x => x.Nome == Nome)
                        .FirstOrDefault();
        return resultado;
    }

    public List<AudioLivro> ObterTodos()
    {
        return Lista;
    }
}