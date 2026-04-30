class Program
{
    static void Main()
    {
        Console.Clear();
        Robo.Configurar(1, 2, 'N');

        Console.WriteLine($"Posição inicial: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");

        Robo.Executar("EMEMEMEMM");

        Console.WriteLine($"Posição final: {Robo.posicaoX} {Robo.posicaoY} {Robo.orientacao}");
    }
}