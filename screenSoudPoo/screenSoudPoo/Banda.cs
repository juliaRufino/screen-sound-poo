class Banda
{
    // Criando um construtor para pegarmos o nome da banda
    public Banda(string nome)
    {
        Nome = nome;
    }

    // Lista para armazenas os albuns da banda
    private List<Album> albuns = new List<Album>();
    public string Nome { get; }

    // Método para adicionar os albuns a banda
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    // Método para exibir os albuns da banda
    public void ExibirDiscografia()
    {
        Console.WriteLine($"\nDiscografia da banda {Nome}");
        foreach(Album album in albuns)
        {
            Console.WriteLine($"Album: {album.Nome} \n Duração total: {album.DuracaoTotal}");
        }
    }
}
