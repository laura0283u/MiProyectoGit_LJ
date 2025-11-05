namespace MiProyectoGit_LJ;

public class MATEMÁTICAS
{

        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
}
