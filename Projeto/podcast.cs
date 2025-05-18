using System.Runtime.InteropServices;

class Podcast
{
    private List<Episodio> episodios = new List<Episodio>();
    public string Nome { get; }
    public string Artista { get; }
    public string Host { get; }
    public int TotalEpisodios => episodios.Count; // Total de episódios
    
    public void AdcionarEpisodio(Episodio episodio)
    {
        // Adiciona o episódio ao podcast
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        System.Console.WriteLine($"Podcast {Nome} apresentado por {Host}");
        Console.WriteLine("\nEpisódios:");
        foreach (var episodio in episodios)
        {
            // Console.WriteLine($"Episódio: {episodio.Titulo}");
            // Console.WriteLine($"Duração: {episodio.Duracao} segundos");
            Console.WriteLine($"{episodio.Resumo}");
        }
        Console.WriteLine($"\n\nTotal de episódios: {episodios.Count}");
    }

    public Podcast(string nome, string artista, string host)
    {
        Nome = nome;
        Artista = artista;
        Host = host;
    }

}