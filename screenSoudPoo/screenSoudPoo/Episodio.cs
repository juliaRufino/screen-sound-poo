public class Episodio
{
    public int Duracao { get; }
    public int Ordem { get;}
    public string Titulo { get;}

    List<Convidado> convidados = new List<Convidado>();

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

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
