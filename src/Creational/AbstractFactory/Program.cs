using AbstractFactory;

var sqlServerFactory = new SqlServerFactory();
var sqlServerCLient = new DatabaseClient(sqlServerFactory);
sqlServerCLient.RunQuery();

Console.WriteLine();

var mySqlFactory = new MySqlFactory();
var mySqlClient = new DatabaseClient(mySqlFactory);
mySqlClient.RunQuery();

Console.ReadKey();