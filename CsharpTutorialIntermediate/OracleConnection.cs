


public class OracleConnection : DbConnection
{
    public OracleConnection(string connectionString) : base(connectionString) { }

    public override void Close()
    {
        Console.WriteLine("Oracle Connection closed");
    }

    public override void Open()
    {
        Console.WriteLine("Oracle Connection open");
    }
}