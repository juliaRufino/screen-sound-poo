public class Podcast
{
    public Podcast (string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    List<Episodio> episodios = new List<Episodio>();

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nNome do Podcast: {Nome}\nHost: {Host} \nLista de episodios:");

        foreach (var episodio in episodios)
        {
            Console.WriteLine(episodio.Titulo);
        }
        
    }

}