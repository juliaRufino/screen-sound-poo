class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set;}
    public Genero genero { get; set; }

    //Lambda - Apenas o Get (leitura)
    public string DescricaoResumida => $"A música {Nome} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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
        Console.WriteLine($"Nome da música: {Nome}");
        Console.WriteLine($"Nome do artista: {Artista}");
    }


}
