class Musica
{
    public Musica(Banda artista, string nome)
    {
        Nome = nome;
        Artista = artista;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; } // em segundos
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
    $"{Nome} - {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao} segundos");
        if (Disponivel)
        {
            Console.WriteLine("Disponível");
        }
        else
        {
            Console.WriteLine("Indisponível");
        }
    }


}