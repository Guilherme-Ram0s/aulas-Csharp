namespace ConsoleApp1
{
    internal class principal
    {
        static void Main(string[] args)
        {

            Produto teclado = new Produto("teclado", 59, 92.10);
            Produto comida = new Produto("pizza", 10, 40);

            Console.WriteLine(teclado.getDetailProduct());
            Console.WriteLine(comida.getDetailProduct());

            Console.WriteLine(teclado.GetType());
        }
    }
}
