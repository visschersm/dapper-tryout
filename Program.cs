using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

var connectionString = "";
using var connection = new SqlConnection(connectionString);

//var version = connection.ExecutScalar<string>("SELECT @@VERSION");
//Console.WriteLine(version);

var dog = new Dog
{
    Name = "Buck"
};

connection.Execute($"INSERT INTO Dog (Name) VALUES('{dog.Name}')");

public class Dog
{
    public int Id { get; set;}
    public string Name {get;set;}
    public int? Age {get;set;}
    public int? Weight {get;set;}
}

