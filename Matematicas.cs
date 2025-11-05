using System;

namespace MiProyectoGit_LJ
{
  public static int Sumatorio(int n)
{
    int suma = 0;
    for (int i = 1; i <= n; i++) suma += i;
    return suma;
}
  public static int Factorial(int n)
{
    int resultado = 1;
    for (int i = 1; i <= n; i++)
    {
        resultado *= i;
    }
    return resultado;
}
}
