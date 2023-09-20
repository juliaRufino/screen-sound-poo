//Instânciando as bandas
Banda bts = new Banda("BTS");

Banda oneDirection = new Banda("One Direction");

//Instânciando as músicas
Musica musica01 = new Musica(oneDirection, "Stole My Heart")
{
    Duracao = 140,
    Disponivel = false,
};

Musica musica02 = new Musica(bts, "Boy With Luv")
{
    Duracao = 260,
    Disponivel = true,
};

Musica musica03 = new Musica(bts, "My Time")
{
    Duracao = 100,
    Disponivel = true,
};

Musica musica04 = new Musica(oneDirection, "I Want")
{
    Duracao = 190,
    Disponivel = false,
};

//Instânciando os generos das musicas
Genero genero01 = new Genero();
genero01.Nome = "Pop";

Genero genero02 = new Genero();
genero02.Nome = "Jazz";

Genero genero03 = new Genero();
genero03.Nome = "Kpop";


//Instanciândo os albuns
Album albumDoBTS = new Album("Map of the Soul: 7");

Album albumDoOneDirection = new Album("Up All Night");

Album albumDoBTS2 = new Album("Wings");


//Instânciando os convidados
Convidado convidado01 = new Convidado()
{
    Nome = "Julia",
    Idade = 19,
    Sexo = "F"
};


Convidado convidado02 = new Convidado()
{
    Nome = "Kauanny",
    Idade = 24,
    Sexo = "F"
};

Convidado convidado03 = new Convidado()
{
    Nome = "Julya",
    Idade = 20,
    Sexo = "F"
};

// Instânciando os episodios
Episodio episodio01 = new Episodio()
{
    Titulo = "Piloto",
    Ordem = 1,
    Duracao = 25,
};

Episodio episodio02 = new Episodio()
{
    Titulo = "Serio mesmo?",
    Ordem = 2,
    Duracao = 20,
};

Episodio episodio03 = new Episodio()
{
    Titulo = "Vish maria",
    Ordem = 3,
    Duracao = 30,
};

Episodio episodio04 = new Episodio()
{
    Titulo = "Seja bem-vindo!",
    Ordem = 4,
    Duracao = 30,
};

//Instânciando os podcasts
Podcast podcast01 = new Podcast("Host1", "Programação: O que é isso?");

Podcast podcast02 = new Podcast("Host2", "SMR: Faz sentido?");

// Adicionando as musicas para os generos
genero03.AdicionarGeneroMusica(musica01);
genero03.AdicionarGeneroMusica(musica04);
genero01.AdicionarGeneroMusica(musica02);
genero01.AdicionarGeneroMusica(musica03);

// Adicionando as musicas para o album
albumDoBTS.AdicionarMusica(musica02);
albumDoBTS.AdicionarMusica(musica03);
albumDoOneDirection.AdicionarMusica(musica01);
albumDoOneDirection.AdicionarMusica(musica04);

// Adicionando os albuns para as bandas
bts.AdicionarAlbum(albumDoBTS);
bts.AdicionarAlbum(albumDoBTS2);
oneDirection.AdicionarAlbum(albumDoOneDirection);


// Adicionando os episodios para o podcast
podcast01.AdicionarEpisodio(episodio01);
podcast01.AdicionarEpisodio(episodio02);
podcast02.AdicionarEpisodio(episodio03);
podcast02.AdicionarEpisodio(episodio04);

// Adicionando os convidados dos episodios
episodio01.AdicionarConvidado(convidado03);
episodio01.AdicionarConvidado(convidado01);
episodio01.AdicionarConvidado(convidado02);
episodio02.AdicionarConvidado(convidado02);

// Exibindo os generos e suas musicas
genero01.ExibirMusicasDoGenero();
genero02.ExibirMusicasDoGenero();
genero03.ExibirMusicasDoGenero();

//Exibindo as informaçoes das musicas
musica01.ExibirFichaTecnica();
musica02.ExibirFichaTecnica();
musica03.ExibirFichaTecnica();
musica04.ExibirFichaTecnica();

//Exibir Musicas
musica01.ExibirMusica();
musica02.ExibirMusica();
musica03.ExibirMusica();
musica04.ExibirMusica();

//Exibir discografia das bandas
bts.ExibirDiscografia();
oneDirection.ExibirDiscografia();

// Exibir podcasts
podcast01.ExibirDetalhes();
podcast02.ExibirDetalhes();

//Exibir episódios dos podcasts
episodio01.ExibirEpisodio();
episodio02.ExibirEpisodio();
episodio03.ExibirEpisodio();
episodio04.ExibirEpisodio();

// Exibir os convidados
convidado01.ExibirConvidado();
convidado02.ExibirConvidado();
convidado03.ExibirConvidado();
