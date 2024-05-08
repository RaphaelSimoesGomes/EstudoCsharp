using System.Runtime.CompilerServices;
using System.Data;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

public class Horario{
    public Horario(){
        //ele  vai pegar com base na hora e data do seu pc
        DateTime date = new DateTime();
        Console.WriteLine(date);
    }
    public Horario(string dia, string mês, string ano, string hora, string minuto){
        string dataString = $"{ano}-{mês}-{dia} {hora}:{minuto}";
        
        DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
        
        Console.WriteLine(data);
        
        // DateTime date02 = DateTime.Parse("31/01/2003  18:00");
        // Console.WriteLine(date02);

        //Existe esses modelos de formatação de hora/dia
        // int numero = 123456;
        
        //o 'toString' está recebendo a funcão de umm molador, ele que vai dar formato que queremos
        // Console.WriteLine(numero.ToString("##-##-##"));

        // int dataNascimento = 31012003;
        // Console.WriteLine(dataNascimento.ToString("##-##-####"));
    }
}