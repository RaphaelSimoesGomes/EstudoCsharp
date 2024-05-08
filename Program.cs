using System.ComponentModel;
using System.Xml;
using Estudo01;
using Estudo01.Models;
using System.Globalization;

new Horario();

new LeituraArquivo(caminho: "Arquivos/arquivoLeitura.txt");


Pessoa p1 = new Pessoa(nome: "Afonso", sobrenome: "Claudio");

Pessoa p2 = new Pessoa(nome: "Raphael", sobrenome: "Simões");

Curso CursoDoFlavio = new Curso(nome: "Ingles");

CursoDoFlavio.Alunos = new List<Pessoa>();

CursoDoFlavio.AdicionarAluno(p1);
CursoDoFlavio.AdicionarAluno(p2);
CursoDoFlavio.ExibirAlunos();

//Usando tupla

Console.WriteLine("\nEstou usando tupla\n");

(int,string,string) info = (1,"Raphael","Simoes");
Console.WriteLine($"Exibir Tupla: {info.Item1} id");


//Se for para usar tupla, utilize assim, pois é mais clara a leitura e traz mais legibilidade ao seu codigo

(int id, string nome, int idade,decimal altura, decimal dinheiro, double porcentagem)tupla = (1,"Raphael Simões Gomes",21, 1.83M,1230.40M,.289);



Console.WriteLine($"Esse é o seu id {tupla.id} e esses são seus valores:\n Nome: {tupla.nome}\nIdade: {tupla.idade}\nAltura: {tupla.altura}\nE o seu saldo no banco é de: {tupla.dinheiro.ToString("c", CultureInfo.CreateSpecificCulture("en-US"))} equivalente a {tupla.porcentagem.ToString("p")} do seu patrimonio");

Console.WriteLine("\nEstou usando Dictionary\n");

//Dictionary é um modelo que de chave e valor 
Dictionary<int,string> dir = new Dictionary<int,string>();
dir.Add(1,"Raphael Simões");
dir.Add(2,"Marcola Andrade");
dir.Add(3,"Bernas Ribeiro");

foreach( var i in dir){
    Console.WriteLine($"Key: {i.Key}\nValor: {i.Value}");
}

//Esse é um modelo de fila, o primeiro a entrar é o primeiro a sair (modelo justo) utilizamos Queue

Console.WriteLine("\nEstou inserindo numa fila\n");

Queue<int> fila = new Queue<int>();
fila.Enqueue(1);
fila.Enqueue(2);
fila.Enqueue(3);
fila.Enqueue(4);

foreach (int i in fila){
    Console.WriteLine(i);
}


//Esse é um modelo de pilha, o ultimo a entrar é o primeiro a sair (Modelo injusto) utilizamos Stack

Console.WriteLine("\nEstou inserindo numa pilha\n");

Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

foreach(int i in stack){
    Console.WriteLine(i);
}

// p1.Idade = 20;
// p1.Apresentar();