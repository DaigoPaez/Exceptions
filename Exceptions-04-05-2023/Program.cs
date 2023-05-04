class MiException : Exception 
{
    public MiException(string message) : base(message)
    {}
    public MiException() : this("Error")
    {}
}

Internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            throw new MiException("Error");
        }
        catch (MiException e) 
        { }
    }
}