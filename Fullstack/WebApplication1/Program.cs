using System.Data.SqlClient;
using Dapper;
using WebApplication1.Model;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();

var connection = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyTextObjects;Integrated Security=True";

app.MapGet("/textobject", async() =>
{
    var conn = new SqlConnection(connection);
    var textobjects = await conn.QueryAsync<TextObject>("SELECT * FROM TextObject");
    return textobjects;
});

app.MapPost("/textobject", async (TextObject textobject) =>
{
    var conn = new SqlConnection(connection);
    var rowsAffected = await conn.ExecuteAsync("INSERT INTO TextObject VALUES (@Index, @Text, @ForeColor, @BackColor)", textobject);
});
app.UseStaticFiles();
app.Run();

