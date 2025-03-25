Predio predio = new Predio();
Elevador elevador = new Elevador(8);
Pessoa pessoa = new Pessoa(80);

pessoa.ChamarElevador(elevador, 2);

//pessoa.ChamarElevador(elevador, 2);
elevador.AbrirPorta();

pessoa.EntrarElevador(elevador);

elevador.FecharPorta();
elevador.Subir(4);
elevador.Descer(1);