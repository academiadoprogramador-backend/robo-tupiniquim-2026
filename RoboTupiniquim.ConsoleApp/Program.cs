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

int posicaoX = 1;
int posicaoY = 2;
char orientacao = 'N';

string comandoCompleto = "EMEMEMEMM";

Console.WriteLine($"Posição inicial: {posicaoX} {posicaoY} {orientacao}");

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

Console.WriteLine($"Posição final: {posicaoX} {posicaoY} {orientacao}");