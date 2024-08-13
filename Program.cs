

System.Console.WriteLine();
System.Console.WriteLine("====Calculadora====");
System.Console.WriteLine("Escolha uma Operacao");
System.Console.WriteLine("1 -  Soma");
System.Console.WriteLine("2 - Subtração");
System.Console.WriteLine("3 - Divisão");
System.Console.WriteLine("4 - Multiplicação");
System.Console.WriteLine("0 - Sair");
System.Console.WriteLine();
System.Console.WriteLine("Digite a operação desejada: ");
string operacaoEscolhida =  Console.ReadLine();

System.Console.WriteLine("Digite o primeiro valor: ");
 double numero1 = double.Parse(Console.ReadLine());

System.Console.WriteLine("Digite o seundo valor: ");
double numero2 = double.Parse( Console.ReadLine());

var soma = numero1+numero2;
var subtracao = numero1 - numero2;
var divisao = numero1 / numero2;
var mutiplicacao = numero1 * numero2;

double resultado;
switch(operacaoEscolhida)
{
    case"1":
    resultado = soma;
    System.Console.WriteLine("Operação selecionada foi a Soma");
    System.Console.WriteLine($"O Resltado da soma de {numero1} + {numero2}  é {soma}");
    break;
    case "2":
    resultado = subtracao;
    System.Console.WriteLine("Operação selecionada foi a Subtração");
    System.Console.WriteLine($"O Resltado da subtrcao de {numero1} + {numero2}  é {subtracao}");
    break;
    case "3":
    resultado = divisao;
     System.Console.WriteLine("Operação selecionada foi a Divisão");
    System.Console.WriteLine($"O Resltado da divisão de {numero1} + {numero2}  é {divisao}");
    break;
    case "4":
    resultado = mutiplicacao;
     System.Console.WriteLine("Operação selecionada foi a Mutiplicação");
    System.Console.WriteLine($"O Resltado da multiplicao de {numero1} + {numero2}  é {mutiplicacao}");
    break;
    case "0":
    System.Console.WriteLine("O sistema será encerrado.....");
    break;
    default:
    System.Console.WriteLine("Opecao não encotrada");
    break;   
   



}

