using System;
using System.Reflection.Metadata;
namespace Estudo01.Models;

public class Curso
{
    public Curso()
    {

    }
    public Curso(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; set; }

    public List<Pessoa> Alunos { get; set; }
    public void AdicionarAluno(Pessoa aluno)
    {
        Alunos.Add(aluno);
    }
    public int MostrarQuantidade()
    {
        int quantidade = Alunos.Count;
        return quantidade;
    }
    public bool RemoverAluno(Pessoa aluno)
    {
        return Alunos.Remove(aluno);
    }
    public void ExibirAlunos()
    {
        Console.WriteLine($"Alunos do curso: {Nome}");
        for (int count = 0; count < Alunos.Count; count++)
        {
            Console.WriteLine($"N° {count+1} - {Alunos[count].NomeCompleto}");
        }

    }
}
