/*
    Teste do algoritmo 1:

    Pos. Inicial:
    X = 1
    Y = 2
    D = N

    Comando = EMEMEMEMM

    -----------------------------

    Teste do algoritmo 2:

    Pos. Inicial:
    X = 3
    Y = 3
    D = L

    Comando = MMDMMDMDDM

    Pos. Final Esperada:
    X = 5
    Y = 1
    D = L
*/

// atributos que irão informar a posição do robô
static class Robo
{
    public static int posicaoX;
    public static int posicaoY;
    public static char orientacao;

    public static void Configurar(int pX, int pY, char o)
    {
        posicaoX = pX;
        posicaoY = pY;
        orientacao = o;
    }

    public static void Executar(string comandoCompleto)
    {
        char[] instrucoes = comandoCompleto.ToCharArray();

        for (int contador = 0; contador < instrucoes.Length; contador++)
        {
            char instrucao = instrucoes[contador];

            if (instrucao == 'E')
            {
                if (orientacao == 'N') orientacao = 'O';
                else if (orientacao == 'O') orientacao = 'S';
                else if (orientacao == 'S') orientacao = 'L';
                else if (orientacao == 'L') orientacao = 'N';
            }
            else if (instrucao == 'D')
            {
                if (orientacao == 'N') orientacao = 'L';
                else if (orientacao == 'L') orientacao = 'S';
                else if (orientacao == 'S') orientacao = 'O';
                else if (orientacao == 'O') orientacao = 'N';
            }
            else if (instrucao == 'M')
            {
                if (orientacao == 'N') posicaoY++;
                else if (orientacao == 'S') posicaoY--;
                else if (orientacao == 'O') posicaoX--;
                else if (orientacao == 'L') posicaoX++;
            }
        }
    }
}

class Program
{
    static void Main()
    {
        Robo.Configurar(1, 2, 'N');

        Console.WriteLine($"Posição inicial: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");

        Robo.Executar("EMEMEMEMM");

        Console.WriteLine($"Posição final: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");
    }
}