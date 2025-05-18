class Episodio
{
    private List<string> convidados = new List<string>();
    public int Duracao { get; } // em segundos
    public int Ordem { get; }
       public string Titulo { get; }
    public string Resumo => $"{Ordem}. {Titulo} \nDuração: {Duracao / 60}:{Duracao % 60}\nConvidados: {string.Join(", ", convidados)}\n";
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
        
    }
 

    public void AdcionarConvidados(string convidado)
    {
        convidados.Add(convidado);
        // Adiciona os convidados ao episódio
    }
}