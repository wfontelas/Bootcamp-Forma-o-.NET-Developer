using ExemploFundamentos.Common.Models;



	//------------------------------------------------------------------------------------------------------------------

	// //Outro exemplo da classe List
	
	// List<string> listaString = new List<string>();
	
	// listaString.Add("SP");
	// listaString.Add("BA");
	// listaString.Add("MG");
	// listaString.Add("RJ");
	
	
	// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
	
	// listaString.Add("SC");
	
	// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
	
	// listaString.Remove("MG");
	
	// Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");


	//-----------------------------------------------------------------------------------------

	// //TRABALHANDO COM LISTAS

	// List<string> listaString = new List<string>();
	
	// listaString.Add("SP");
	// listaString.Add("BA");
	// listaString.Add("MG");
	// listaString.Add("RJ");
	
	// Console.WriteLine($"Percorrendo a lista com o FOR");
	// for(int contador = 0; contador < listaString.Count; contador ++)
	// {
	// 	Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
	// }

	// Console.WriteLine($"Percorrendo a lista com o FOREACH");
	// int contadorForeach = 0;
	// foreach(string item in listaString)
	// {
	// 	Console.WriteLine($"Posição Nº {contadorForeach} - {item}");
	// 	contadorForeach++;
	// }


	//--------------------------------------------------------------------------------------

	// //COPIANDO UM ARRAY PARA O OUTRO

	// int[] arrayInteiros = new int[4];
		
	// 	arrayInteiros[0] = 72;
	// 	arrayInteiros[1] = 64;
	// 	arrayInteiros[2] = 50;
	// 	arrayInteiros[3] = 1;
		
	// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];	
	// Array.Copy(arrayInteiros, arrayInteirosDobrados, arrayInteiros.Length);
		
	// 	Console.WriteLine("Percorrendo o array com FOR");
		
	// 	for(int contador = 0; contador < arrayInteiros.Length; contador ++)
	// 	{			
	// 		Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");			
	// 	}


	
	
	//---------------------------------------------------------------------------------

	// //REDIMENSIONANDO UM ARRAY

	// int[] arrayInteiros = new int[4];
		
	// 	arrayInteiros[0] = 72;
	// 	arrayInteiros[1] = 64;
	// 	arrayInteiros[2] = 50;
	// 	arrayInteiros[3] = 1;
	
	// Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2); 	
		
	// 	Console.WriteLine("Percorrendo o array com FOR");
		
	// 	for(int contador = 0; contador < arrayInteiros.Length; contador ++)
	// 	{			
	// 		Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");			
	// 	}




    //-----------------------------------------------------------------------------------------------------------

	//PERCORRENDO UM ARRAY COM FOREACH

	int[] arrayInteiros = new int[4];
		
		arrayInteiros[0] = 72;
		arrayInteiros[1] = 64;
		arrayInteiros[2] = 50;
		arrayInteiros[3] = 1;
		
		Console.WriteLine("Percorrendo o array com FOR");
		
		for(int contador = 0; contador < arrayInteiros.Length; contador ++)
		{			
			Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");			
		}
		
		Console.WriteLine("Percorrendo o array com FOREACH");
		
		int contadorForeach = 0;        
		foreach(int valor in arrayInteiros)
		{
			Console.WriteLine($"Posição Nº{contadorForeach} - {valor}");
			contadorForeach++;	
		}



	//-----------------------------------------------------------------------------------------

	// //IMPLEMENTANDO UM ARRAY DE INTEIRO

	// int[] arrayInteiros = new int[3];
		
	// 	arrayInteiros[0] = 72;
	// 	arrayInteiros[1] = 64;
	// 	arrayInteiros[2] = 50;
	// 	//arrayInteiros[3] = 1;
		
	// 	for(int contador = 0; contador < arrayInteiros.Length; contador ++)
	// 	{
			
	// 		Console.WriteLine($"Posição Nº{contador} - {arrayInteiros[contador]}");
			
	// 	}



   

   
   //----------------------------------------------------------------------------//-----------------------------------------
   
    // //REFATORANDO O MENU
	
	// string opcao;
	// bool exibirMenu = true;
	
	// while(exibirMenu)
	// {
	// 	Console.WriteLine("Digite a sua opção: ");
	// 	Console.WriteLine("1 - Cadastrar Cliente ");
	// 	Console.WriteLine("2 - Buscar Cliente");
	// 	Console.WriteLine("3 - Apagr Cliente");
	// 	Console.WriteLine("4 - Encerrar");
		
	// 	opcao = Console.ReadLine();
		
	// 	switch(opcao)
	// 	{
	// 		case "1":
	// 			Console.WriteLine("Cadastro de Cliente");
	// 			break;
				
	// 		case "2":
	// 			Console.WriteLine("Busca de clientes");
	// 			break;
				
	// 		case "3":
	// 			Console.WriteLine("Apagar cliente");
    //             break;
				
	// 		case "4":
	// 			Console.WriteLine("Encerrar");
	// 			exibirMenu = false;		//Inserimos a varivel boleana, pois enquanto ela permacer true irá rodar
	// 			//Environment.Exit(0);  //Para Encerrar o programa
	// 			break;
				
	// 		default:
	// 			Console.WriteLine("Opção inválida!");
	// 			break;
	// 	}
		
    // }      
    // Console.WriteLine("	O programa se encerrou");



    // //Vc pode construir um menu interativo utilizando WHILE:
	
	// string opcao;
	
	// while(true)
	// {
	// 	Console.WriteLine("Digite a sua opção: ");
	// 	Console.WriteLine("1 - Cadastrar Cliente ");
	// 	Console.WriteLine("2 - Buscar Cliente");
	// 	Console.WriteLine("3 - Apagar Cliente");
	// 	Console.WriteLine("4 - Encerrar");
		
	// 	opcao = Console.ReadLine();
		
	// 	switch(opcao)
	// 	{
	// 		case "1":
	// 			Console.WriteLine("Cadastro de Cliente");
	// 			break;
				
	// 		case "2":
	// 			Console.WriteLine("Busca de clientes");
	// 			break;
				
	// 		case "3":
	// 			Console.WriteLine("Apagar cliente");
    //             break;
				
	// 		case "4":
	// 			Console.WriteLine("Encerrar");
	// 			Environment.Exit(0);         //Para Encerrar o programa
	// 			break;
				
	// 		default:
	// 			Console.WriteLine("Opção inválida!");
	// 			break;
	// 	}		
	// }

    //---------------------------------------------------

    // int soma = 0, numero = 0;
	
	// do 
	// {
	// 	Console.WriteLine("Digite um número (0 para parar)");
	// 	numero = Convert.ToInt32(Console.ReadLine());
		
	// 	soma += numero;      //+= -- soma = soma + numero
		
	// }while(numero != 0);
	
	// Console.WriteLine($"O Total da soma dos números digitados é: {soma}");
    
    // int numero = 10;
	
	// Console.WriteLine(numero);
	
	// Console.WriteLine("Incrementando o 10");
	// numero ++;   // mesma coisa que numero + numero + 1
	
	// Console.WriteLine(numero);
    //----------------------------------------------------//---------------------------------------

    // Calculadora calc = new Calculadora();
		
	// 	calc.Somar(10, 30);
	// 	calc.Subtrair(10, 50);
	// 	calc.Multiplicar(15,45);
	// 	calc.Dividir(2, 2);
    //     calc.Potencia(3,3);
    //     calc.Seno(30);
	// 	calc.Coseno(30);
	// 	calc.Tangente(30);
    //     calc.RaizQuadrada(9);
    

    //-----------------------------------------------------//---------------------------

    // bool choveu = true;
	// bool estaTarde = true;
	
	// if(!choveu && !estaTarde)   //o sinal do NOT !(exclamção) nega , espera o falso
	// {
	// 	Console.WriteLine("Vou Pedalar");
	// }
	// else
	// {
	// 	Console.WriteLine("Não vou pedalar");
	// }
    
    //---------------------------------------------------------------------------------
    
    // bool possuiPresencaMinima = true;
	// double media = 7.5;
	
	// if(possuiPresencaMinima && media >=7)
	// {
	// 	Console.WriteLine("Aprovado");
	// }
	// else
	// {
	// 	Console.WriteLine("Reprovado");
	// }

    //----------------------------------------------------------------------//-------------------------

    // bool ehMaiorDeIdade = true;
	// bool possuiAutorizacaoDoResponsavel = false;
	
	// if(ehMaiorDeIdade || possuiAutorizacaoDoResponsavel)  
	// {
	// 	Console.WriteLine("Entrada Liberada");
	// }
	// else
	// {
	// 	Console.WriteLine("Entrada não liberada");
	// }


    //--------------------------------------------------//--------------------------------------------

    // Console.WriteLine("Digite uma letra");
	// string letra = Console.ReadLine();

    // switch(letra)
	// {
	// 	case "a":
	// 	case "e":
	// 	case "i":
	// 	case "o":
	// 	case "u":
	// 		Console.WriteLine("Vogal");
	// 		break;
			
	// 	default:
	// 		Console.WriteLine("Não é uma vogal");
	// 		break;
    // }        


    //-----------------------------------------//-----------------------------------------------

    // int quantidadeEstoque = 10;
	// int quantidadeCompra = 4;
	// bool possivelVenda = quantidadeCompra > 0 && quantidadeEstoque >= quantidadeCompra;
	
	// Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque}");
	// Console.WriteLine($"Quantidade em Compra: {quantidadeCompra}");
	// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");
	
	// if(quantidadeCompra == 0)
	// {
	// 	Console.WriteLine("Venda inválida");
    // }    
	
	// else if(possivelVenda)
	// {
	// 	Console.WriteLine("Venda Realizada");
	// }
	// else
	// {
	// 	Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
	
	// }

//--------------------------------------------------------------------------------------

    // int quantidadeEstoque = 10;
	// int quantidadeCompra = 4;
	// bool possivelVenda = quantidadeEstoque >= quantidadeCompra;
	
	// Console.WriteLine($"Quantidade em Estoque: {quantidadeEstoque}");
	// Console.WriteLine($"Quantidade em Compra: {quantidadeCompra}");
	// Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");
	
	// if(possivelVenda)
	// {
	// 	Console.WriteLine("Venda Realizada");
	// }
	// else
	// {
	// 	Console.WriteLine("Desculpe, não temos a quantidade desejada em estoque.");
	
	// }


//----------------------------------------------//------------------------
// string a = "15-";
	
// 	int b = 0;				    	//int b = 0;
// 	int.TryParse(a, out b);    //ou   int.TryParse(a, out int b)
	
// 	Console.WriteLine(b);
// 	Console.WriteLine("Conversão realizada com sucesso");
//--------------------------------------//---------------------------

// DateTime dataAtual = DateTime.Now.AddDays(5);
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));

//----------------------------------//----------------------------

// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.87;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("O valor da variável quantidade é : " + quantidade);
// Console.WriteLine("O valor da variável altura é : " + altura.ToString("0.00"));
// Console.WriteLine("O valor da variável preço é : " + preco);
// Console.WriteLine("O valor da variável condição é : " + condicao);

//--------------------//--------------------------//------------------


// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "William";
// pessoa1.Idade = 39;
// pessoa1.Apresentar();
