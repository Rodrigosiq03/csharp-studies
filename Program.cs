// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Screen sound
string msg = "Boas vindas ao Screen Sound";

// Verbatim literal
// string screenSound = @"
    
// ░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
// ██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
// ╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
// ░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
// ██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
// ╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
// ";


// List<string> arrayBands = new List<string>(); lista vazia
List<string> arrayBands = new List<string>  { "AC/DC", "U2" };
List<int> arrayNums = new List<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

Dictionary<string, List<int>> signedUpBands = new Dictionary<string, List<int>>();

signedUpBands.Add("Linkin Park", new List<int> {10, 8, 6});
signedUpBands.Add("Beatles", new List<int>());

void styling(string word)
{
    foreach(char letter in word)
    {
        System.Console.Write("*");
    }
    System.Console.Write("\n");
    System.Console.WriteLine(word);
    foreach(char letter in word)
    {
        System.Console.Write("*");
    }
    System.Console.Write("\n");

}

void Welcome(string msg) 
{
    styling(msg);
    Console.Write("\n");
}

void MenuOptions() 
{
    Welcome(msg);
    Console.WriteLine("Digite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string input = Console.ReadLine()!;
    int selectedOption = int.Parse(input);

    switch (selectedOption) 
    {
        case 1: SignUpBand();
            break;
        case 2: ShowBands();
            break;
        case 3: RateBand();
            break;
        case 4: ShowAverageBand();
            break;
        case -1: Console.WriteLine("Você saiu do programa!");
            break;
        default: Console.WriteLine("Você escolheu uma opção que não faz parte do programa!");
            break;
    }
}

void SignUpBand() 
{   
    string title = "Registro de bandas";
    Console.Clear();
    styling(title);
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    string bandSelected = Console.ReadLine()!;
    // arrayBands.Add(bandSelected);
    signedUpBands.Add(bandSelected, new List<int>());
    Console.WriteLine($"A banda {bandSelected} foi registrada");
    Thread.Sleep(2500);
    Console.Clear();
    MenuOptions();

}

void ShowBands()
{   
    string title = "Exibindo todas as bandas registradas";
    Console.Clear();
    styling(title);
    // for (int i = 0; i < arrayBands.Count; i++)
    // {
    //     Console.WriteLine($"Banda: {arrayBands[i]}");
    // }
    System.Console.Write("\n");
    foreach (string band in signedUpBands.Keys)
    {
        Console.WriteLine($"Banda: {band}");
    }

    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    MenuOptions();

}

void RateBand() 
{   
    string title = "Avaliar banda";
    Console.Clear();
    styling(title);
    System.Console.Write("Digite o nome da banda que deseja avaliar: ");
    string bandSelected = Console.ReadLine()!;
    if (signedUpBands.ContainsKey(bandSelected))
    {
        System.Console.Write($"Digite uma avaliação para a banda {bandSelected}: ");
        int rating = int.Parse(Console.ReadLine()!);
        signedUpBands[bandSelected].Add(rating);
        System.Console.WriteLine($"A nota foi registrada com sucesso para a banda {bandSelected}");
        Thread.Sleep(2000);
        Console.Clear();
        MenuOptions();
    } else 
    {
        Console.WriteLine($"A banda {bandSelected} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        MenuOptions();
    }
}

void ShowAverageBand() 
{
    string title = "Média da banda";
    Console.Clear();
    styling(title);
    System.Console.Write("Digite o nome da banda que deseja ver a média: ");
    string bandSelected = Console.ReadLine()!;
    if (signedUpBands.ContainsKey(bandSelected))
    {
        double average = signedUpBands[bandSelected].Average();
        System.Console.WriteLine($"A média da banda {bandSelected} é {average}");
        Thread.Sleep(1000);
        Console.Clear();
        MenuOptions();
    } else 
    {
        Console.WriteLine($"A banda {bandSelected} não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        MenuOptions();
    }

}

MenuOptions();

