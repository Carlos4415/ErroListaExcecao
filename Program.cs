// Este programa declara uma lista de números inteiros e tenta acessar um elemento 
// em um índice que pode não existir. Caso ocorra uma tentativa de acesso inválido,
// o programa trata a exceção apropriada (IndexOutOfRangeException) e exibe uma mensagem
// clara ao usuário, garantindo a estabilidade do programa.
try
{
    List<int> numeros = new List<int> { 1, 2, 3 };
    Console.WriteLine($"Elemento no índice 5: {numeros[5]}");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}