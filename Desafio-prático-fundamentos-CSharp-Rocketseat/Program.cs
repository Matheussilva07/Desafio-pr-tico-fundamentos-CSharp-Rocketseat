using System.Security.AccessControl;

internal class Program
{
    private static void Main(string[] args)
    {
        //Primeiro desafio:

        string? userName;

        Console.WriteLine("PRIMEIRO DESAFIO:\n\n");
        Console.WriteLine("Please, type your name below:\n");

        userName = Console.ReadLine();

        Console.WriteLine($"You are welcome,{userName}!");

        //Segundo desafio:

        string firstName, lastName;

        Console.WriteLine("SEGUNDO DESAFIO:\n\n");
        Console.WriteLine("Type your first name and your last name below:\n");

        firstName = Console.ReadLine();
        lastName = Console.ReadLine();

        Console.WriteLine(firstName + " " + lastName);

        //Terceiro desafio:

        double number1, number2;

        Console.WriteLine("TERCEIRO DESAFIO:\n\n");
        Console.WriteLine("Insira dois valores quaisquer que que as operações aritimeticas sejam realizadas:\n");

        number1 = Convert.ToDouble(Console.ReadLine());
        number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Esta é a soma dos valores: " + (number1 + number2));
        Console.WriteLine("Esta é a subtração dos valores: " + (number1 - number2));
        Console.WriteLine("Esta é a multiplicação dos valores: " + (number1 * number2));
        Console.WriteLine("Esta é a divisão dos valores: " + (number1 / number2));
        Console.WriteLine("Esta é a média dos valores: " + (number1 + number2) / 2);

        //Quarto desafio:

        string randomWord;

        Console.WriteLine("QUARTO DESAFIO:\n\n");
        Console.WriteLine("Digite uma palavra ou palavras quaisquer para ver a quantidade de caracteres:\n");

        randomWord = Console.ReadLine();

        string wordWithoutWhiteSpace = randomWord.Trim();

        int amountCaracters = wordWithoutWhiteSpace.Count();


        Console.WriteLine(amountCaracters);

        //Quinto desafio:

        Console.WriteLine("QUINTO DESAFIO:\n\n");
        Console.WriteLine("Digite uma placa de veiculo para verificar sua validade:\n");


        string placa = Console.ReadLine();
        int qtdCaracteres = placa.Count();

        bool placaValida;

        if (qtdCaracteres == 7)
        {
            string tresCaracteresInicias = placa.Substring(0, 3);

            if (tresCaracteresInicias.All(char.IsLetter))
            {
                string quatroCaracteresFinais = placa.Substring(placa.Length - 4);

                if (quatroCaracteresFinais.All(char.IsNumber))
                {
                    placaValida = true;

                    Console.WriteLine(placaValida);
                }
                else
                {
                    placaValida = false;
                    Console.WriteLine(placaValida);
                    return;
                }

            }
            else
            {
                placaValida = false;
                Console.WriteLine(placaValida);
                return;
            }
        }
        else
        {
            Console.WriteLine("Placa inválida");
            return;
        }


        //Sexto desafio:

        Console.WriteLine("SEXTO DESAFIO\n\n");
        Console.WriteLine("Exibir a data atual em diferentes formatos:data atual em diferentes formatos:\n");

        DateTime dateTime = DateTime.Now;
        Console.WriteLine(dateTime.ToString("dddd, dd/MM/yyyy, H:mm:ss"));
        Console.WriteLine(dateTime.ToString("dd/MM/yyyy"));
        Console.WriteLine(dateTime.ToString("H:mm"));
        Console.WriteLine(dateTime.ToString("dd/MMMM/yyyy"));
    }
}