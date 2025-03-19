Biblioteca biblioteca = new Biblioteca();
Livro livro_1 = new Livro("calculo 1", "prof x", 1822);

Pessoa pessoa_1 = new Pessoa("gabs", "1234");

biblioteca.AdicionarLivro(livro_1);
Console.WriteLine(biblioteca.QtdLivro);

biblioteca.AlugarLivro(pessoa_1, livro_1, biblioteca);
Console.WriteLine(biblioteca.QtdLivro);
Console.WriteLine(pessoa_1.LivroAlugado);
