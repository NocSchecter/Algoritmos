
public class BusquedaBinaria
{
    public List<int> numeros =  new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 25, 30, 35, 42, 49};
    public int objetivo = 35;

    public static void Main()
    {
        BusquedaBinaria busBin = new BusquedaBinaria();

        int indice = busBin.Busqueda(busBin.numeros, busBin.objetivo);

        if (indice == -1)
            Console.WriteLine("El elemento no está en la lista");
        else
        {
            Console.WriteLine("El elemento " + busBin.objetivo + " se encuentra en la posición: " + indice);
        }
    }

    public int Busqueda(List<int> lista, int elemento)
    {

        var minimo = 0;
        var maximo = lista.Count - 1;

        while (minimo <= maximo)
        {

            var medio = (minimo + maximo) / 2;

            if (lista[medio] == elemento)
            {
                return  medio + 1;
            }

            if (lista[medio] > elemento)
            {
                maximo = medio - 1;
            }
            else{
                minimo = medio + 1;
            }
        }

        return -1;
    }
}