using System;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Reflection.Metadata;
namespace Estudo01;

public class Pessoa
{
    public Pessoa(){
        
    }
    public Pessoa(string nome, string sobrenome){
        Nome = nome;
        Sobrenome = sobrenome;
    }
    private string _nome;
    public string Nome
    {
        get => _nome;

        set
        {
            if (value == "")
            {
                throw new ArgumentException("Seu nome está vazio");
            }
            _nome = value;
        }
    }
    public string Sobrenome {
         get; set;
        }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    private int _idade;
    public int Idade
    {
        get
        {
            return _idade;
        }
        set
        {
            if(value <0){
                throw new ArgumentException("Sua idade não pode ser menor do que 0");
            }
            if (value.GetType() == typeof(string))
            {
                throw new ArgumentException("Sua idade não pode ser uma string");
            }
            _idade = value;
        }

    }
    public void Apresentar()
    {
        Console.WriteLine($"Ola {NomeCompleto} tem {Idade}");
    }
}
