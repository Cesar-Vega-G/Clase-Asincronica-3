
public class ColaSimple
{
    private int[] elementos;
    private int inicio;
    private int fin;
    private int capacidad;

    public ColaSimple(int capacidad)
    {
        this.capacidad = capacidad;
        elementos = new int[capacidad];
        inicio = -1;
        fin = -1;
    }

    public void Agregar(int valor)
    {
        if (fin == capacidad - 1)
        {
            Console.WriteLine("La cola está llena (desbordamiento)");
        }
        else
        {
            if (inicio == -1)
            {
                inicio = 0;
            }
            elementos[++fin] = valor;
        }
    }

    public int Eliminar()
    {
        if (inicio == -1)
        {
            Console.WriteLine("La cola está vacía (subdesbordamiento)");
            return -1;
        }
        else
        {
            int valor = elementos[inicio];
            if (inicio == fin)
            {
                inicio = -1;
                fin = -1;
            }
            else
            {
                inicio++;
            }
            return valor;
        }
    }

    public int VerPrimero()
    {
        if (inicio == -1)
        {
            Console.WriteLine("La cola está vacía");
            return -1;
        }
        else
        {
            return elementos[inicio];
        }
    }
}

public class ColaCircular
{
    private int[] elementos;
    private int inicio;
    private int fin;
    private int capacidad;

    public ColaCircular(int capacidad)
    {
        this.capacidad = capacidad;
        elementos = new int[capacidad];
        inicio = -1;
        fin = -1;
    }

    public void Agregar(int valor)
    {
        if ((fin + 1) % capacidad == inicio)
        {
            Console.WriteLine("La cola está llena (desbordamiento)");
        }
        else
        {
            if (inicio == -1)
            {
                inicio = 0;
            }
            fin = (fin + 1) % capacidad;
            elementos[fin] = valor;
        }
    }

    public int Eliminar()
    {
        if (inicio == -1)
        {
            Console.WriteLine("La cola está vacía (subdesbordamiento)");
            return -1;
        }
        else
        {
            int valor = elementos[inicio];
            if (inicio == fin)
            {
                inicio = -1;
                fin = -1;
            }
            else
            {
                inicio = (inicio + 1) % capacidad;
            }
            return valor;
        }
    }

    public int VerPrimero()
    {
        if (inicio == -1)
        {
            Console.WriteLine("La cola está vacía");
            return -1;
        }
        else
        {
            return elementos[inicio];
        }
    }
}

class Program
{
    static void Main() { }
}


