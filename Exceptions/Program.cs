
class Program
    {
    static void Main()
    {
        uint? edad = null;
        Console.WriteLine("Captura tu edad y presiona 'Enter'");
        string? edadCapturada = Console.ReadLine();
        if (edadCapturada is not null)
        {
            try
            {
                edad = uint.Parse(edadCapturada);
            }
            catch(FormatException)
            {
                Console.WriteLine("Introduce un número bobolon");
            }
            catch(OverflowException)
            {
                Console.WriteLine("No mientas");
            }
        }
        if (edad is not null)
        {
            Console.WriteLine($"Tu edad es {edad}");
        }
        else
        {
            Console.WriteLine("Por favor");
        }
    }
}
