using System;
using System.Collections.Generic;
using System.Linq;
using Amazonia.DAL.Entidades;
using Amazonia.DAL.Repositorios;

public class RepositorioLivroDigital : IRepositorio<LivroDigital>
{
    private List<LivroDigital> Lista;

    public RepositorioLivroDigital()
    {
        Lista = new List<LivroDigital>();
          
        var lotrEbook = new LivroDigital
        {
            Nome = "O Senhor dos Aneis",
            Autor = "J.R.R. Tolkien",
            TamanhoEmMB = 30,
            FormatoFicheiro = "PDF",
            InformacoesLicenca = "Exemplo"
        };
        Lista.Add(lotrEbook);

        
    }
  public void Apagar(LivroDigital obj)
    {
        Lista.Remove(obj);
    }

    public LivroDigital Atualizar(string nomeAntigo, string nomeNovo)
    {
        var temp = ObterPorNome(nomeAntigo);
        temp.Nome = nomeNovo;

        return temp;
    }

    public void Criar(LivroDigital obj)
    {
        Lista.Add(obj);
    }

    public LivroDigital ObterPorNome(string Nome)
    {
        Console.WriteLine("ObterPorNome");
        var resultado = Lista
                        .Where(x => x.Nome == Nome)
                        .FirstOrDefault();
        return resultado;
    }

    public List<LivroDigital> ObterTodos()
    {
        return Lista;
    }
}