//Passos para resolver o bubble sort.
// 1° - Criar um vetor para receber 100 posições.
// 2° - Criar um laço de repetição para percorrer o vetor.
// 3° - Preencher cada posição com um valor aleatório.
// 4° - Imprimir o vetor com os valores aleatórios.

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

// 5° - Percorrer o vetor com valores aleatórios 
// 6° - Comparar a posição atual com a próxima posição
// 7° - Se a posição atual for maior que a proxima elas trocam de posição. 
// 8° - Imprime o vetor com os valores ordenados.

// bool troca = false;
// do
// {
//     troca = false;
//     for (int i = 0; i < vetor.Length - 1; i++)
//     {
//         int atual = vetor[i];
//         int proximo = vetor[i + 1];
//         if (atual > proximo)
//         {
//             troca = true;
//             int aux = atual;
//             vetor[i] = proximo;
//             vetor[i + 1] = aux;
//         }
//     }

// } while (troca == true);


Array.Sort(vetor);
Console.WriteLine("\n\n");
for (int i = 0; i < tamanhovet; i++)
{
    Console.Write(vetor[i] + " ");
}

