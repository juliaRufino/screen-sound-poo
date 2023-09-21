public class Podcast
{
    //Construtor
    public Podcast (string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodio { get; set; }

    // Lista para armazenar os episodios
    List<Episodio> episodios = new List<Episodio>();

    //Adicionando episodios na lista
    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
        TotalEpisodio ++;
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"\nNome do Podcast: {Nome}\nHost: {Host} \nLista de episodios:");

        foreach (var episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Titulo);
        }
        Console.WriteLine($"Total de espisódios: {TotalEpisodio}");

    }

}