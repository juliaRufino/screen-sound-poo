public class Episodio
{
    public int Duracao { get; set; }
    public int Ordem { get; set; }
    public string Titulo { get; set; }

    List<Convidado> convidados = new List<Convidado>();

    public string Resumo => $"Número: {Ordem}, título: {Titulo}, duração: {Duracao}, total de convidados: {convidados.Count()}";

    public void AdicionarConvidado(Convidado convidado)
    {
        convidados.Add(convidado);
    }

    public void ExibirEpisodio()
    {
        Console.WriteLine($"\n{Resumo}");
    }

}
