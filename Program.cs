double dividendo, divisor, quociente; // Declaração de variáveis para o dividendo, divisor e quociente.

Console.WriteLine("-----DIVISÃO-----"); // Exibe uma mensagem no console.

Console.WriteLine("DIGITE O DIVIDENDO:"); // Exibe uma mensagem no console pedindo ao usuário para digitar o dividendo.
dividendo = Convert.ToDouble(Console.ReadLine()!); // Lê o valor digitado pelo usuário e converte para double, atribuindo à variável dividendo.

Console.WriteLine("DIGITE O DIVISOR:"); // Exibe uma mensagem no console pedindo ao usuário para digitar o divisor.
divisor = Convert.ToDouble(Console.ReadLine()!); // Lê o valor digitado pelo usuário e converte para double, atribuindo à variável divisor.

// "!" é um operador de nulabilidade usado para indicar que o valor lido de Console.ReadLine() não será nulo.

bool ehValido = divisor == 0; // Verifica se o divisor é igual a zero e atribui o resultado à variável booleana ehValido.

// A partir daqui começa uma estrutura condicional:

// Se o divisor for igual a zero, ou seja, ehValido for verdadeiro...
if (ehValido)
{
    Console.WriteLine("NÃO É POSSÍVEL DIVIDIR POR ZERO"); // Exibe uma mensagem no console informando que não é possível dividir por zero.
}
// Senão, se o divisor for diferente de zero, ou seja, ehValido for falso...
else
{
    quociente = dividendo / divisor; // Realiza a divisão do dividendo pelo divisor e atribui o resultado à variável quociente.
    Console.WriteLine($"A DIVISÃO DE {dividendo:N1} por {divisor:N1} é {quociente:N1}."); // Exibe no console o resultado da divisão formatado com uma casa decimal.
}

Console.WriteLine("OBRIGADO !!!"); // Exibe uma mensagem no console para finalizar o programa.
