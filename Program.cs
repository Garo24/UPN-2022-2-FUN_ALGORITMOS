int num1, num2;
Console.Write("INGRESE NUMERO DE FILAS: ");
num1 = int.Parse(Console.ReadLine());
Console.Write("INGRESE NUMERO DE COLUMNAS: ");
num2 = int.Parse(Console.ReadLine());



for (int i = 1; i <= num1; i++)
{
    for (int j = 1; j <= num2; j++)
    {
        Console.Write("+ ");
    }
    Console.WriteLine("");
}


Console.ReadKey();
