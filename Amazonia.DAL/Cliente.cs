using System;
namespace Amazonia.DAL
{
    public class Cliente
    {
     public string Nome { get; set; } 
     public Morada Morada { get; set; }     
    public string Username { get; set; }   
    public string Password { get; set; }  
    public DateTime DataNascimento { get; set; }
    public string NIF { get; set; }


    } 
}