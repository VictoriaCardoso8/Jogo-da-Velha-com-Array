//Enunciado
//Usando matriz, crie o jogo da velha. Inicialmente, as posições são variáveis vazias. 
//O usuário fornece a linha e a coluna e confirma, então é marcado no tabuleiro X ou O 
//(se for o jogador 1 ou jogador 2).

using System.Security.Cryptography.X509Certificates;

string[,] jogo = new string[3, 3];
int numjogadas = 4;
Console.WriteLine("Bem vindo ao jogo da velha com matriz!");
Console.ReadKey();
Console.Clear();

for (int i = 0; i < numjogadas; i++)
{
    Console.Clear();
    Exibir();
    Console.WriteLine("Pressione qualquer tecla para a proxima jogada.");
    Console.ReadKey();
    Jogada1();
    Console.Clear();
    Verificar();
    Exibir(); 
    Console.WriteLine("Pressione qualquer tecla para a proxima jogada.");
    Console.ReadKey();
    Console.Clear();
    Exibir();
    Jogada2();
    Console.Clear();
    Verificar();
    Exibir();
}
Console.WriteLine("EMPATE!");

void Exibir()
{
    Console.WriteLine("   (1)  (2)  (3) ");
    Console.WriteLine($"(1) {jogo[0, 0]}  |  {jogo[0, 1]}  | {jogo[0, 2]} ");
    Console.WriteLine($"(2) {jogo[1, 0]}  |  {jogo[1, 1]}  | {jogo[1, 2]} ");
    Console.WriteLine($"(3) {jogo[2, 0]}  |  {jogo[2, 1]}  | {jogo[2, 2]} ");
}
void Jogada1()
{
    var jogadafeita = 1;
    while (jogadafeita == 1)
    {
        Console.WriteLine("Jogador 1 escolha a posição da linha da casa:");
        int linha1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Jogador 1 escolha a posição coluna da casa:");
        int coluna1 = int.Parse(Console.ReadLine());
        if (jogo[linha1 - 1, coluna1 - 1] == null)
        {
            jogo[linha1 - 1, coluna1 - 1] = "X";
            jogadafeita++;
        }
        else
        {
            Console.WriteLine("Casa já ocupada!");
            Console.ReadKey();
        }
    }
}
void Jogada2()
{
    var jogadafeita = 1;
    while (jogadafeita == 1)
    {
        Console.WriteLine("Jogador 2 escolha a posição da linha da casa:");
        int linha2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Jogador 2 escolha a posição coluna da casa:");
        int coluna2 = int.Parse(Console.ReadLine());
        if (jogo[linha2 - 1, coluna2 - 1] == null)
        {
            jogo[linha2 - 1, coluna2 - 1] = "O";
            jogadafeita++;
        }
        else
        {
            Console.WriteLine("Casa já ocupada!");
            Console.ReadKey();
        }
    }
}
void Verificar()
{
    if((jogo[0, 0] == "X" && jogo[1, 0] == "X" && jogo[2, 0] == "X")  ||
        (jogo[0, 1] == "X" && jogo[1, 1] == "X" && jogo[2, 1] == "X") ||
        (jogo[0, 2] == "X" && jogo[1, 2] == "X" && jogo[2, 2] == "X") ||
        (jogo[0, 0] == "X" && jogo[0, 1] == "X" && jogo[0, 2] == "X") ||
        (jogo[1, 0] == "X" && jogo[1, 1] == "X" && jogo[1, 2] == "X") ||
        (jogo[2, 0] == "X" && jogo[2, 1] == "X" && jogo[2, 2] == "X") ||
        (jogo[0, 0] == "X" && jogo[1, 1] == "X" && jogo[2, 2] == "X") ||
        (jogo[0, 2] == "X" && jogo[1, 1] == "X" && jogo[2, 0] == "X"))
    {
        Console.Clear();
        Console.WriteLine("Jogador 1 VENCEU!");
        Environment.Exit(0);
    }
    if ((jogo[0, 0] == "O" && jogo[1, 0] == "O" && jogo[2, 0] == "O") ||
    (jogo[0, 1] == "O" && jogo[1, 1] == "O" && jogo[2, 1] == "O") ||
    (jogo[0, 2] == "O" && jogo[1, 2] == "O" && jogo[2, 2] == "O") ||
    (jogo[0, 0] == "O" && jogo[0, 1] == "O" && jogo[0, 2] == "O") ||
    (jogo[1, 0] == "O" && jogo[1, 1] == "O" && jogo[1, 2] == "O") ||
    (jogo[2, 0] == "O" && jogo[2, 1] == "O" && jogo[2, 2] == "O") ||
    (jogo[0, 0] == "O" && jogo[1, 1] == "O" && jogo[2, 2] == "O") ||
    (jogo[0, 2] == "O" && jogo[1, 1] == "O" && jogo[2, 0] == "O"))
    {
        Console.Clear();
        Console.WriteLine("Jogador 2 VENCEU!");
        Environment.Exit(0);
    }
}


