// See https://aka.ms/new-console-template for more information


public class DbCommand
{
    private readonly DbConnection _connection;
    private readonly string _instruction;
    public DbCommand(DbConnection connection, string instruction)
    {
        if (connection == null || instruction == null || instruction == "")
            throw new ArgumentNullException();
        _connection = connection;
        _instruction = instruction;

    }

    public void Execute()
    {
        _connection.Open();
        Console.WriteLine(_instruction);
        _connection.Close();
    }
}