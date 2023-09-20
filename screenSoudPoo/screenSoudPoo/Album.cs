class Album
{
    // Criando um construtor para pegarmos o nome do album
    public Album(string nome)
    {
        Nome = nome;
    }

    // Criando uma lista para armazenar as musicas do album
    private List<Musica> musicas = new List<Musica>();

    public string Nome { get; }

    // Atributo para armazenar o total de duracao do album, realizando a soma
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);


    // Criando método para adicionar as músicas ao album
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    // Método para exibir as musicas do album
    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do álbum {Nome}: \n");
        foreach(var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

        Console.WriteLine($"\nPara ouvir este album inteiro você precisa de {DuracaoTotal}");
    }
}