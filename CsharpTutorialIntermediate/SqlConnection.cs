


public class SqlConnection : DbConnection
{
    public SqlConnection(string connectionString) : base(connectionString) { }

    public override void Open()
    {
        Console.WriteLine("SQL Connection open");
    }

    public override void Close()
    {
        Console.WriteLine("SQL Connection closed");
    }
}
