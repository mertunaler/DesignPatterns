using MongoDB.Driver;
using System.Data.SqlClient;

public interface IConnection
{
    object GetConnection();
}

public class MsSqlConnection : IConnection
{
    public object GetConnection()
    {
        return new SqlConnection("CONNSTRR");
    }
}

public class MongoDbConnection : IConnection
{
    public object GetConnection()
    {
        return new MongoClient("mongodb://localhost:1923");
    }
}

public abstract class ConnectionFactory
{
    public abstract IConnection CreateConnection();
}

public class MongoDbFactory : ConnectionFactory
{
    public override IConnection CreateConnection()
    {
        return new MongoDbConnection(); 
    }
}

public class MsSqlFactory : ConnectionFactory
{
    public override IConnection CreateConnection()
    {
        return new MsSqlConnection();
    }
}

public class Program
{
    static void Main()
    {
        ConnectionFactory _conn = new MsSqlFactory();
        
        _conn.CreateConnection();

        ConnectionFactory _mongoConn = new MongoDbFactory();
        _mongoConn.CreateConnection();
    }
}




