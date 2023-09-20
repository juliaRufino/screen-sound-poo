class Genero
{
    // Criando uma lista para armazenar as musicas do genero
    List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }

    // Método para adicionar as musicas ao genero
    public void AdicionarGeneroMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    // Método para exibir as musicas dos generos
    public void ExibirMusicasDoGenero()
    {
        Console.WriteLine($"\nLista de músicas do genêro {Nome}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }

    }
}


