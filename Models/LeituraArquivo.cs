public class LeituraArquivo{
    public LeituraArquivo(string caminho){
        try
        {
            string[] linhas = File.ReadAllLines(caminho);
            foreach (string linha in linhas){
            Console.WriteLine(linha);
            }
        
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            throw;
        }
    }
}