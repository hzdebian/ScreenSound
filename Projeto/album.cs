class Album
{
    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao); // em segundos
    public void AdcionarMusica(Musica musica)
    {
        // Adiciona a música ao álbum
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        // Exibe as músicas do álbum
        Console.WriteLine($"Músicas do álbum {Nome}:");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }Console.WriteLine($"Duração do álbum: {DuracaoTotal / 60} minutos e {DuracaoTotal % 60} segundos");
        Console.WriteLine($"Total de músicas: {musicas.Count}");
    }
}