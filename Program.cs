using EspacioCalculadora;

//Interfaz de usuario

int eleccion = 0;

double num;

Calculadora calculador = new Calculadora();

while (eleccion != 7)
{

    Console.WriteLine("\n\n\tCalculadora\n1-Sumar\n2-Resta\n3-Multiplicar\n4-Dividir\n5-Limpiar\n6-Resultado\n7-Salir");

    eleccion = int.Parse(Console.ReadLine());

    switch (eleccion)
    {

        case 1:
            Console.Write("\nIngrese el numero a sumar: ");
            num = double.Parse(Console.ReadLine());
            calculador.Sumar(num);
            break;
        case 2:
            Console.Write("\nIngrese el numero a restar: ");
            num = double.Parse(Console.ReadLine());
            calculador.Restar(num);
            break;
        case 3:
            Console.Write("\nIngrese el numero a multiplicar: ");
            num = double.Parse(Console.ReadLine());
            calculador.Multiplicar(num);
            break;
        case 4:
            Console.Write("\nIngrese el numero a dividir: ");
            num = double.Parse(Console.ReadLine());
            calculador.Dividir(num);
            break;
        case 5:
            Console.Write("\nLimpiado... ");
            calculador.Limpiar();
            break;
        case 6:
            Console.Write("Resultado : " + calculador.Resultado);
            break;
    }



}