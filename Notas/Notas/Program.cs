Disciplina disciplina = new Disciplina();
Aluno aluno1 = new Aluno();
Aluno aluno2 = new Aluno();


disciplina.Nome = "cálculo";
disciplina.MediaCurso = 7;

aluno1.Nome = "gabs";
aluno2.Nome = "ricardo";

disciplina.AdicionarAluno(aluno1);
disciplina.AdicionarAluno(aluno2);

disciplina.AdicionarNota(aluno1, 8);
disciplina.AdicionarNota(aluno1, 6);

disciplina.AdicionarNota(aluno2, 5);
disciplina.AdicionarNota(aluno2, 5);

disciplina.CalcularMedia(aluno1);
disciplina.CalcularMedia(aluno2);

disciplina.ImprimirDados();

