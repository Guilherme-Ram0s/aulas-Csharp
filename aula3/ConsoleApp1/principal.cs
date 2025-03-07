namespace ConsoleApp1
{
    internal class principal
    {
        static void Main(string[] args)
        {

            Produto teclado = new Produto("teclado", 59, 92.10);
            Retangulo retangulo = new Retangulo();
            retangulo.Altura = 90;
            retangulo.Largura = 2;

            Console.WriteLine($"temos um retangulo a altura de {retangulo.Altura} e com a largura de {retangulo.Largura}");

            Console.WriteLine(retangulo.Area());
            Console.WriteLine(retangulo.Perimetro());


        }
    }
}
