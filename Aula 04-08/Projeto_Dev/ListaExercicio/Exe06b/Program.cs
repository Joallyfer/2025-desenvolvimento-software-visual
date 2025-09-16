
using System.Collections.Specialized;
using System.Reflection.Emit;
using System.Security.Cryptography;

int tamanhovet = 100;
int[] vetor = new int[tamanhovet];

Random random = new Random();

for (int i = 0; i < tamanhovet; i++)
{
    vetor[i] = random.Next(1000);
}

for (int i = 0; i < tamanhovet; i++)
{
    Console.Write(vetor[i] + " ");
}


Array.Sort(vetor);


Console.WriteLine("\n\n");
for (int i = 0; i < tamanhovet; i++)
{
    Console.Write(vetor[i] + " ");
}

