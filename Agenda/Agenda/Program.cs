Agenda agenda = new Agenda();
Contato contato_1 = new Contato("gabs", "gabs@gmail.com", "1198282");
Contato contato_2 = new Contato("bela", "bela@gmail.com", "1193232");
Contato contato_3 = new Contato("joao", "joao@gmail.com", "119666");

agenda.AdicionarContato(contato_1);
agenda.AdicionarContato(contato_2);
agenda.AdicionarContato(contato_3);
agenda.ImprimirDados();

agenda.RemoverContato(contato_1);
agenda.ImprimirDados();

agenda.BuscarContato("joao@gmail.com");
agenda.BuscarContato("gabs");
