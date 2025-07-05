namespace Rocket_Challenge_Pratical_CSharp_Module_I;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite seu primeiro nome:");

        string? primeiroNome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");

        string? sobrenome = Console.ReadLine();

        if (string.IsNullOrEmpty(primeiroNome) || string.IsNullOrEmpty(sobrenome))
        {
            Console.WriteLine("Erro: Nome ou sobrenome não pode ser vazio.");
        }
        else
        {
            Console.WriteLine($"Olá, {primeiroNome} {sobrenome}! Bem-vindo ao Rocket Challenge Prático de C# Módulo I.");
        }

        Console.WriteLine("\n--- CALCULADORA ---");

        Console.WriteLine("Digite o primeiro número:");
        if (double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Digite o segundo número:");
            if (double.TryParse(Console.ReadLine(), out double numero2))
            {
                // Operações matemáticas
                double soma = numero1 + numero2;
                Console.WriteLine($"Soma: {numero1} + {numero2} = {soma}");

                double subtracao = numero1 - numero2;
                Console.WriteLine($"Subtração: {numero1} - {numero2} = {subtracao}");

                double multiplicacao = numero1 * numero2;
                Console.WriteLine($"Multiplicação: {numero1} * {numero2} = {multiplicacao}");

                if (numero2 != 0)
                {
                    double divisao = numero1 / numero2;
                    Console.WriteLine($"Divisão: {numero1} / {numero2} = {divisao}");
                }
                else
                {
                    Console.WriteLine("Divisão: Não é possível dividir por zero!");
                }

                double media = (numero1 + numero2) / 2;
                Console.WriteLine($"Média: ({numero1} + {numero2}) / 2 = {media}");
            }
            else
            {
                Console.WriteLine("Erro: O segundo número é inválido!");
            }
        }
        else
        {
            Console.WriteLine("Erro: O primeiro número é inválido!");
        }

        Console.WriteLine("\n--- CONTADOR DE CARACTERES ---");

        Console.WriteLine("Digite uma palavra ou frase:");
        string? texto = Console.ReadLine();

        if (!string.IsNullOrEmpty(texto))
        {
            int totalCaracteres = texto.Length;
            Console.WriteLine($"Total de caracteres (incluindo espaços): {totalCaracteres}");

            int contadorSemEspacos = 0;
            foreach (char caractere in texto)
            {
                if (caractere != ' ')
                {
                    contadorSemEspacos++;
                }
            }

            Console.WriteLine($"Total de caracteres (sem espaços): {contadorSemEspacos}");
        }
        else
        {
            Console.WriteLine("Erro: Nenhum texto foi digitado!");
        }

        Console.WriteLine("\n--- VALIDADOR DE PLACA ---");
        Console.WriteLine("Digite a placa do veículo (formato: ABC1234):");
        string? placa = Console.ReadLine();

        if (!string.IsNullOrEmpty(placa))
        {
            if (placa.Length == 7)
            {
                placa = placa.ToUpper();

                // Validando os 3 primeiros caracteres (devem ser letras)
                bool primeirosCaracteresValidos = true;
                for (int i = 0; i < 3; i++)
                {
                    if (!char.IsLetter(placa[i]))
                    {
                        primeirosCaracteresValidos = false;
                        break;
                    }
                }

                // Validando os 4 últimos caracteres (devem ser números)
                bool ultimosCaracteresValidos = true;
                for (int i = 3; i < 7; i++)
                {
                    if (!char.IsDigit(placa[i]))
                    {
                        ultimosCaracteresValidos = false;
                        break;
                    }
                }

                // Resultado final
                bool placaValida = primeirosCaracteresValidos && ultimosCaracteresValidos;

                if (placaValida)
                {
                    Console.WriteLine("Verdadeiro");
                }
                else
                {
                    Console.WriteLine("Falso");
                }
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
        else
        {
            Console.WriteLine("Falso");
        }

        Console.WriteLine("\n--- FORMATADOR DE DATAS ---");

        // Obtendo a data e hora atual
        DateTime agora = DateTime.Now;

        // 1. Formato completo (dia da semana, dia, mês, ano, hora, minutos, segundos)
        string formatoCompleto = agora.ToString("dddd, dd 'de' MMMM 'de' yyyy, HH:mm:ss");
        Console.WriteLine($"Formato completo: {formatoCompleto}");

        // 2. Apenas a data no formato "01/03/2024"
        string apenasData = agora.ToString("dd/MM/yyyy");
        Console.WriteLine($"Apenas data: {apenasData}");

        // 3. Apenas a hora no formato de 24 horas
        string apenasHora = agora.ToString("HH:mm:ss");
        Console.WriteLine($"Apenas hora (24h): {apenasHora}");

        // 4. A data com o mês por extenso
        string dataComMesExtenso = agora.ToString("dd 'de' MMMM 'de' yyyy");
        Console.WriteLine($"Data com mês por extenso: {dataComMesExtenso}");
    }
}