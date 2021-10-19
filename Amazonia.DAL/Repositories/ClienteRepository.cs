using System.Collections.Generic;
using System;
namespace Amazonia.DAL.Repositories
{
    class ClienteRepository : IRepository<Cliente>
    {
        private List<Cliente> ClientList;
        public ClienteRepository()
        {
            ClientList = new List<Cliente>();
            var joao =  new Cliente();
            joao.Nome = "João";
            joao.DataNascimento = new DateTime(2003,03,22);

            var maria = new Cliente {Nome = "Maria", DataNascimento = new DateTime(2003,05,2)};
        
            var marta = new Cliente{Nome = "Marta", DataNascimento = new DateTime(2020,03,22)};
        
            ClientList.Add(joao);
            
            ClientList.Add(maria);
            
            ClientList.Add(marta);
        }

        public void Create(Cliente client)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Cliente client)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> ReadAll()
        {
            return ClientList;
        }

        public Cliente ReadByName(string nome)
        {
            throw new System.NotImplementedException();
        }

        public Cliente Update(Cliente client)
        {
            throw new System.NotImplementedException();
        }
    }

}