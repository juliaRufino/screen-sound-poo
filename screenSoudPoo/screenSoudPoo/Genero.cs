class Genero
{
    List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    public void adicionarGeneroMusica(Musica musica)
    {
        musicas.Add(musica);
    }


    public void ExibirMusicasDoGenero()
    {
        Console.WriteLine($"Lista de músicas do genêro {Nome}: \n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

    }
}


