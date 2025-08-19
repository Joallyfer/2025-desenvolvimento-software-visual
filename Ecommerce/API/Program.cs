var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//Para criar Funcionalidade - Requisições
// Precisamos de uma URL/Endereço/Caminho
// Um método HTTP

app.MapGet("/", () => "Minha Segunda API em C#!");

app.MapGet("/endereco", () => "Outra Funcionalidade");

app.MapPost("/endereco", () => "Funcionalidade do Post");



app.Run();
