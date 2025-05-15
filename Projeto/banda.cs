class Banda
{
    private List<Album> albums = new List<Album>();
    public string Nome { get; set; }

    public void AdcionarAlbum(Album album)
    {
        // Adiciona o álbum à banda
        albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");
        foreach (var album in albums)
        {
            Console.WriteLine($"Álbum: {album.Nome}");
            Console.WriteLine($"Duração total: {album.DuracaoTotal / 60} minutos e {album.DuracaoTotal % 60} segundos");
        }
    }
}