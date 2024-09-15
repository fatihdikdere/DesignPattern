using Adapter;

DatabaseClient databaseClient;

IDatabaseAdapter sqlServerAdapter = new SqlServerAdapter();
databaseClient = new DatabaseClient(sqlServerAdapter);
databaseClient.ConnectionTest();

IDatabaseAdapter mySqlAdapter = new MySqlAdapter();
databaseClient = new DatabaseClient(mySqlAdapter);

databaseClient.ConnectionTest();

Console.ReadKey();