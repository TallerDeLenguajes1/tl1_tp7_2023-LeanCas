using EspacioCalculadora;
using EspacioEmpleado;

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


Console.WriteLine("\n\t Ejercicio 2");

Empleado empleado1 = new Empleado("Leandro", "Casavalle", new DateTime(2001, 11, 05), 'c', 'm', new DateTime(2010, 5, 25), 12500.50, cargos.Ingeniero);

Console.WriteLine("\n Sueldo basico de " + empleado1.Apellido + "  " + empleado1.Nombre + " es " + empleado1.Sueldo);

empleado1.calcularSueldo(empleado1);

Console.WriteLine("\n Sueldo total de " + empleado1.Apellido + "  " + empleado1.Nombre + " es " + empleado1.Sueldo);

Empleado empleado2 = new Empleado("Juan", "Armando", new DateTime(1995, 1, 15), 's', 'f', new DateTime(2004, 8, 05), 6500.50, cargos.Especialista);

Console.WriteLine("\n Sueldo basico de " + empleado2.Apellido + "  " + empleado2.Nombre + " es " + empleado2.Sueldo);

empleado2.calcularSueldo(empleado2);

Console.WriteLine("\n Sueldo total de " + empleado2.Apellido + "  " + empleado2.Nombre + " es " + empleado2.Sueldo);

Empleado empleado3 = new Empleado("Leandro", "Casavalle", new DateTime(2001, 11, 05), 'c', 'm', new DateTime(2010, 5, 25), 1500, cargos.Administrativo);

Console.WriteLine("\n Sueldo basico de " + empleado3.Apellido + "  " + empleado3.Nombre + " es " + empleado3.Sueldo);

empleado3.calcularSueldo(empleado3);

Console.WriteLine("\n Sueldo total de " + empleado3.Apellido + "  " + empleado3.Nombre + " es " + empleado3.Sueldo);

double montoTotal = empleado1.Sueldo + empleado2.Sueldo + empleado3.Sueldo;

Console.WriteLine("El monto total a pagar a los empleados es : " + montoTotal);