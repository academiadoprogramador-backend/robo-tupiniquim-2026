/*
    Teste do algoritmo 1:

    Pos. Inicial:
    X = 1
    Y = 2
    D = N

    Comando = EMEMEMEMM
*/

int posicaoX = 1;
int posicaoY = 2;
char orientacao = 'N';

string comandoCompleto = "EMEMEMEMM";

Console.WriteLine($"Posição inicial: X={posicaoX} Y={posicaoY} O={orientacao}");

char[] instrucoes = comandoCompleto.ToCharArray();

for (int contador = 0; contador < instrucoes.Length; contador++)
{
    char instrucao = instrucoes[contador];
}