Album QueenAlbum = new Album();
QueenAlbum.Nome = "A Night at the Opera";

Musica musica1 = new Musica();
musica1.Nome = "Bohemian Rhapsody";
musica1.Duracao = 354;
Musica musica2 = new Musica();
musica2.Nome = "Love of My Life";
musica2.Duracao = 213;

Banda Queen = new Banda();
Queen.Nome = "Queen";
Queen.AdcionarAlbum(QueenAlbum);
Queen.ExibirDiscografia();