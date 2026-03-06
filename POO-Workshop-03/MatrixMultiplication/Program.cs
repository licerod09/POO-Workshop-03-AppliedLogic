using Shared;

int m = ConsoleExtension.GetInt("Enter the value of m: ");
int n = ConsoleExtension.GetInt("Enter the value of n: ");
int p = ConsoleExtension.GetInt("Enter the value of p: ");

// Declare matrices A (m x n), B (n x p) and C (m x p)
int[,] A = new int[m, n];
int[,] B = new int[n, p];
int[,] C = new int[m, p];

// Fill matrix A using formula: A[i,j] = (i + 1) * j
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        A[i, j] = (i + 1) * j;
    }
}

// Fill matrix B using formula: B[i,j] = (j + 1) * i
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < p; j++)
    {
        B[i, j] = (j + 1) * i;
    }
}

Console.WriteLine("*** A ***");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(A[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("*** B ***");
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < p; j++)
    {
        Console.Write(B[i, j] + " ");
    }
    Console.WriteLine();
}

// Multiply A x B and store the result in C
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < p; j++)
    {
        for (int k = 0; k < n; k++)
        {
            C[i, j] += A[i, k] * B[k, j];
        }
    }
}

Console.WriteLine("*** C ***");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < p; j++)
    {
        Console.Write(C[i, j] + " ");
    }
    Console.WriteLine();
}