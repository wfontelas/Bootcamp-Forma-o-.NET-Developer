using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

// //ATRIBUINDO TIPO DE VALOR

// int a = 10; //Stack

// int b = a;
// b = 60;

// Console.WriteLine($"Valor de A: {a}");
// Console.WriteLine($"Valor de B : {b}");








//ATRIBUINDO TIPO DE REFERENCIA

// Pessoa p1 = new Pessoa(nome: "William", sobrenome: "Fontelas");
// // Pessoa p2 = new Pessoa(nome: "Alice", sobrenome: "Alcantara");

// Pessoa p2 = p1;
// p2.Nome = "Caroline"; //errado, pois pegara a referencia

// Console.WriteLine($"Nome da pessoa p1: {p1.NomeCompleto}");
// Console.WriteLine($"Nome da pessoa p2: {p2.NomeCompleto}");












// //METODOS DE EXTENSÃO

// int numero = 20;
// bool par = false;

// //IF Ternário
// par = numero.EhPar();

// string mensagem = "O Número " + numero + " " + "é" + (par ? " par " : " impar");

// Console.WriteLine(mensagem);







// //TESTANDO NOSSA CLASSE GENÉRICA

// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// Console.WriteLine(arrayInteiro[0]);


// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("Teste");

// Console.WriteLine(arrayString[0]);








// //TIPO DINÂMICO

// dynamic variavelDinamica = 4;

// Console.WriteLine($"Tipo da Variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "Texto";
// Console.WriteLine($"Tipo da Variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = true;
// Console.WriteLine($"Tipo da Variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = 4.25M;
// Console.WriteLine($"Tipo da Variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");





// //TIPOS ANÔNIMOS EM COLEÇÃO

// //vamos ler o arquivo tipo json e deserializalo em uma lista:

// //Vamos imaginar a seguinte situação em que eu queria somente pegar as seguintes propriedades do arquivo json: Nome e //Preço e construir ele em um objeto do tipo anonimo:

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVenda.Select(x => new { x.Produto, x.Preco });

// foreach(var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }






// //TIPOS ANÔNIMOS (ou variavel Global)

// //Tipos anônimos fornecem um modo conveniente de encapsular propriedades somente leitura

// var tipoAnonimo = new { Nome = "William", Sobrenome = "Fontelas", Altura = 1.87}; //Somente get; (leitura)

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);





//TIPOS NULOS EM PROPRIEDADES

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach(Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
//                       $"{(venda.Desconto.HasValue ? $" Desconto de: {venda.Desconto}" : "")}");
// }



// //TIPOS NULOS NA PRÁTICA

// bool? desejoReceberEmail = null;

// if(desejoReceberEmail.HasValue && desejoReceberEmail.Value)
// {
//     Console.WriteLine("O usuário optou por receber e-mail");
// }
// else
// {
//     Console.WriteLine("O usuário não repsondeu ou optou por não receber e-mail");
// }







// ////DESELIARIZAR

// string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");

// List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVenda)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}");

// }







////SERILALIZAR

// DateTime dataAtual =  DateTime.Now;

// List<Venda> listaVenda = new List<Venda>();

// Venda v1 = new Venda(1, "Material de Escritório", 25.00M, dataAtual);
// Venda v2 = new Venda(2, "Licença de Software", 110.00M,dataAtual);

// listaVenda.Add(v1);
// listaVenda.Add(v2);

// string serializado = JsonConvert.SerializeObject(listaVenda, Formatting.Indented);

// File.WriteAllText("Arquivos/vendas.json", serializado);

// Console.WriteLine(serializado);













// //IF TERNÁRIO

// //uma sintaxe alternativa e mais enxuta para a instrução IF e ELSE
// //Uma alternativa do IF , onde o sinal de ? (if) e o : (else), somente quando tema um caso de if e else.

// int numero = 20;
// bool ehPar = false;

// //IF Ternário
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "impar"));


// //a mesma coisa que o IF abaixo , com menos código 


// // int numero = 20;

// // if(numero % 2 == 0)
// // {
// //     Console.WriteLine($"O numero {numero} é par");
// // }
// // else
// // {
// //     Console.WriteLine($"O numero {numero} é impar");
// // }







////Deconstruct

// Pessoa p1 = new Pessoa("William","Fontelas");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");










// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");

// if(sucesso)
// {
// 	Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
// 	foreach (string linha in linhasArquivo)
// 	{
// 		Console.WriteLine(linha);
// 	}
// }
// else
// {
// 	Console.WriteLine("Não foi possível ler o arquivo");
// }







////TUPLAS

////É uma coleção , que pode ter difrentes tipos

//(int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "William", "Fontelas", 1.87M);

//Console.WriteLine($"Id: {tupla.Id}");
//Console.WriteLine($"Nome: {tupla.Nome}");
//Console.WriteLine($"Sobrenome :{tupla.Sobrenome}");
// Console.WriteLine($"Altura: {tupla.Altura}");











// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
// estados.Add("RJ", "Rio de Janeiro");

// Console.WriteLine(estados["MG"]);

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("------------------------------");

// estados.Remove("BA");
// estados["SP"] = "São Paulo - Valor Alterado";

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if(estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }










// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }









// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// //sempre vai remover o primeiro(FIFO)

// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }









// // USANDO O THROW

// new ExemploExcecao().Metodo1();






////EXCEÇÃO GENÉRICA E ESPECIFICA  E FINALLY


// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado"
//     + ex.Message);
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou até aqui!");
// }














// //	EXCEÇÕES (EXCEPTIONS)

// //REALIZANDO A LEITURA DE UM ARQUIVO

// //Vamos criar uma nova pasta e nomeá-lá de Arquivos, dentro dela vamos criar um arquivo arquivoLeitura.txt  e inserir algumas linhas

// //Linha 1 do arquivo de leitura
// //Linha 2 do arquivo de leitura - conteudo tal tal

// //na classe Program:

// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach(string linha in linhas)
// {
//    Console.WriteLine(linha);
// }








// //VALIDANDO O RETORNO DO TRYPARSE

// 	string dataString1 = "2022-04-17 18:00";

// 	bool sucesso = DateTime.TryParseExact(dataString1, 
// 						  "yyyy-MM-dd HH:mm,",
// 						   CultureInfo.InvariantCulture,
// 						   DateTimeStyles.None,out DateTime data5);
// 	Console.WriteLine(data5);

// 	if(sucesso)
// 	{
// 		Console.WriteLine($"Conversão com sucesso! Data: {data5}");
// 	}
// 	else
// 	{
// 		Console.WriteLine($"{dataString1} não é válida");
// 	}









// //DATETIME COM TRYPARSE


// //Para fazer uma conversão segura , sem encerrar e apresentar exceção usamos o TryParse:

// string dataString = "2022-04-17 18:00";

// DateTime.TryParseExact(dataString, 
//    				"yyyy-MM-dd HH:mm,",
//                 CultureInfo.InvariantCulture,
//                 DateTimeStyles.None,out DateTime data5);

// Console.WriteLine(data5);








// DateTime data3 = DateTime.Now;
// System.Console.WriteLine(data3.ToShortDateString());

// DateTime data3 = DateTime.Now;
// System.Console.WriteLine(data3.ToShortTimeString());


// //Para converter para o tipo DateTime:

// DateTime data4 = DateTime.Parse("30/04/2022 18:00");
// Console.WriteLine(data4);

// DateTime data4 = DateTime.Parse("32/04/2022 18:00");
// Console.WriteLine(data4);      //Irá apresentar uma exceção pois o dia 32 não é um dia valido





// DateTime data = DateTime.Now;
// Console.WriteLine(data);

// DateTime data1 = DateTime.Now;
// Console.WriteLine(data1.ToString("dd/MM/yyyy HH:mm"));

// DateTime data2 = DateTime.Now;
// Console.WriteLine(data2.ToString("dd/MM/yyyy hh:mm"));








// double porcentagem = .3421;
// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##"));







// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));










// 	CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US");

// 	decimal valorMonetario = 1582.40M;

// 	Console.WriteLine($"{valorMonetario:C}");






// decimal valorMonetario = 1582.40M;

// Console.WriteLine($"{valorMonetario:C}");
















// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);














// Pessoa p1 = new Pessoa(nome: "William", sobrenome: "Fontelas");
// Pessoa p2 = new Pessoa(nome: "Caroline", sobrenome: "Fontelas");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();








// p1.Nome = "William";
// p1.Sobrenome = "Fontelas";
// p1.Idade = 39;
// p1.Apresentar();
