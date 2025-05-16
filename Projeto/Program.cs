Banda Queen = new Banda("Queen");
Album QueenAlbum = new Album("A Night at the Opera");

Musica musica1 = new Musica(Queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = true,
};
Musica musica2 = new Musica(Queen, "Love of My Life")
{
    Duracao = 220,
    Disponivel = false,
};

QueenAlbum.AdcionarMusica(musica1);
QueenAlbum.AdcionarMusica(musica2);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
QueenAlbum.ExibirMusicasDoAlbum();
Queen.AdcionarAlbum(QueenAlbum);
Queen.ExibirDiscografia();