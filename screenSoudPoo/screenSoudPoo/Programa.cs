Album albumDoBrunoMars = new Album();
albumDoBrunoMars.Nome = "24K Magic";

Musica musica01 = new Musica();
musica01.Nome = "That's What I Like";
musica01.Duracao = 273;

Musica musica02 = new Musica();
musica02.Nome = "Versace on the Floor";
musica02.Duracao = 260;

albumDoBrunoMars.AdicionarMusica(musica01);
albumDoBrunoMars.AdicionarMusica(musica02);

Banda banda01 = new Banda();
banda01.Nome = "Bruno Mars";
banda01.AdicionarAlbum(albumDoBrunoMars);

Genero genero01 = new Genero();
genero01.Nome= "Pop";

Genero genero02 = new Genero();
genero02.Nome = "Jazz";

genero01.adicionarGeneroMusica(musica01);
genero02.adicionarGeneroMusica(musica02);
genero01.ExibirMusicasDoGenero();
genero02.ExibirMusicasDoGenero();
