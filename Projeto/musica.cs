class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; } // em segundos
    public bool Disponivel { get; set; }
    public string DescricaoResumida =>
    $"{Nome} - {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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