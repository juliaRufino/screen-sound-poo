class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set;}
    public Genero genero { get; set; }

    //Lambda - Apenas o Get (leitura)
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"\nNome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");

        if(Disponivel)
        {
            Console.WriteLine("Dssponível no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }

    public void ExibirMusica()
    {
        Console.WriteLine($"\nNome da música: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista.Nome}");
    }


}
