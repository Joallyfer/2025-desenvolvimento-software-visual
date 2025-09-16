// 1. Você mantém o "using" para sua classe Produto, que está no arquivo Models/Produto.cs
using API.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// 2. CRIE A LISTA DE PRODUTOS AQUI, como uma variável normal.
// O código agora sabe o que é um "Produto" por causa do "using API.Models;"

var produtos = new List<Produto>
{
    new Produto { Nome = "Notebook Gamer XYZ", Quantidade = 15, Preco = 7599.90 },
    new Produto { Nome = "Mouse Sem Fio Ergonômico", Quantidade = 120, Preco = 149.99 },
    new Produto { Nome = "Teclado Mecânico RGB", Quantidade = 75, Preco = 450.00 },
    new Produto { Nome = "Monitor Ultrawide 34\"", Quantidade = 30, Preco = 2899.50 },
    new Produto { Nome = "SSD NVMe 1TB", Quantidade = 95, Preco = 650.00 },
    new Produto { Nome = "Memória RAM DDR4 16GB", Quantidade = 250, Preco = 380.75 },
    new Produto { Nome = "Cadeira Gamer Confort", Quantidade = 40, Preco = 1350.00 },
    new Produto { Nome = "Headset Surround 7.1", Quantidade = 88, Preco = 599.90 },
    new Produto { Nome = "Webcam Full HD 1080p", Quantidade = 110, Preco = 259.99 },
    new Produto { Nome = "Placa de Vídeo RTX 4070", Quantidade = 25, Preco = 4200.00 }
};

// GET: Pega dados
// POST: Envia/cria dados
// PUT: Atualiza dados inteiros
// PATCH: Atualiza dados parciais
// DELETE: Apaga dados
// HEAD: Pega só os cabeçalhos
// OPTIONS: Consulta métodos permitidos

// Endpoint Raiz

app.MapGet("/", () => "API de Produtos ");

//GET: /api/produto/listar

app.MapGet("/api/produto/listar", () =>
{

    return produtos;

});

//POST: /api/produto/cadastrar
app.MapPost("/api/produto/cadastrar", (Produto produto) =>
{
    produtos.Add(produto);


});


app.Run();