Episodio ep1 = new(1, "Iniciando", 76);
// Console.WriteLine(ep1.Resumo);


Episodio ep2 = new(2, "Convidado Especial", 68);
// Console.WriteLine(ep2.Resumo);


Podcast podcast = new("Merda", "João", "Podpah");
podcast.AdcionarEpisodio(ep1);
ep1.AdcionarConvidados("Primo");
ep1.AdcionarConvidados("Jonas Segundo");

podcast.AdcionarEpisodio(ep2);
ep2.AdcionarConvidados("Alfredo");
ep2.AdcionarConvidados("Guilherme");

podcast.ExibirDetalhes();
