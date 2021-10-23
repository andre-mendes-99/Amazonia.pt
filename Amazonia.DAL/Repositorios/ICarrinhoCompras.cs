using System.Collections.Generic;
using Amazonia.DAL.Entidades;
namespace Amazonia.DAL.Repositorios 
{


interface ICarrinhoCompras
{
decimal CalcularPreco(List<Livro> livro);
decimal AplicarDesconto(int valorDesconto);

}
}