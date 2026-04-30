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
                VirarParaEsquerda();

            else if (instrucao == 'D')
                VirarParaDireita();

            else if (instrucao == 'M')
                MoverParaFrente();
        }
    }

    private static void VirarParaEsquerda()
    {
        if (orientacao == 'N') orientacao = 'O';
        else if (orientacao == 'O') orientacao = 'S';
        else if (orientacao == 'S') orientacao = 'L';
        else if (orientacao == 'L') orientacao = 'N';
    }

    private static void VirarParaDireita()
    {
        if (orientacao == 'N') orientacao = 'L';
        else if (orientacao == 'L') orientacao = 'S';
        else if (orientacao == 'S') orientacao = 'O';
        else if (orientacao == 'O') orientacao = 'N';
    }

    private static void MoverParaFrente()
    {
        if (orientacao == 'N') posicaoY++;
        else if (orientacao == 'S') posicaoY--;
        else if (orientacao == 'O') posicaoX--;
        else if (orientacao == 'L') posicaoX++;
    }
}
