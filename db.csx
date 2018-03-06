using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Mono.Data.Sqlite;

var conn = new SqliteConnection("Data Source=file:test.db");


conn.Open();

var c = new SqliteCommand();
c.Connection=conn;

c.CommandText = "create table if not exists test (f1 text, f2 text)";

c.ExecuteNonQuery();

c = new SqliteCommand();
c.Connection=conn;

c.CommandText = "insert into test values ('one', 'two');";

c.ExecuteNonQuery();

c = new SqliteCommand();
c.Connection=conn;


c.CommandText = "select * from test";

var reader = c.ExecuteReader();

while (reader.HasRows)
{
  reader.Read();
  Console.WriteLine($"{reader["f1"]}");
}
conn.Close();

