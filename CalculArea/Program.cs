//1.  * *Función `CalcularArea`:**Define una función que reciba como parámetros la base y la altura de una figura y devuelva el área calculada.
//2.  **Menú de opciones:**Presenta un menú al usuario para elegir entre calcular el área de un triángulo, rectángulo o círculo.
//3.  **Solicitar datos:**Pide al usuario que ingrese los datos necesarios según la figura elegida (base y altura para triángulo y rectángulo, radio para círculo).
//4.  **Llamar a la función:**Llama a `CalcularArea` con los datos ingresados y muestra el resultado.

double Fbase = 0;
double Faltura = 0;
double radio = 0;
int figura = 0;
string repetir;

Console.WriteLine("\nPROGRAMA DE CÁCLULO DE ÁREAS\n\nEscriba el número de la figura geométrica de la que desea calcular el área:\n");
Console.WriteLine("1.- Área de un cuadrado\n2.- Área de un rectángulo\n3.- Área de un triángulo\n4.-Área de un círculo\n");
figura = int.Parse(Console.ReadLine());


do
{
    switch (figura)
    {

        case 1:
            Console.WriteLine("\nPor favor digite el valor de la base y altura de la figura (un solo valor");
            Fbase = double.Parse(Console.ReadLine());
            break;
        case 2:
        case 3:

            Console.WriteLine("\nPor favor digite el valor de la base de la figura (en cm)");
            Fbase = double.Parse(Console.ReadLine());
            Console.WriteLine("\nPor favor digite el valor de la altura de la figura (en cm)");
            Faltura = double.Parse(Console.ReadLine());
            break;

        case 4:

            Console.WriteLine("\nPor favor digite el valor radio del circulo");
            radio = double.Parse(Console.ReadLine());
            break;

        default:

            Console.WriteLine("Opción inválida, intente otra vez");
            break;
    }

    Console.WriteLine($"\nEl area de la figura es {CalcularArea(Fbase, Faltura, radio)} cm^2");


    double CalcularArea(double Fbase, double Faltura, double radio)
    {
        double pi = 3.1416;

        if (figura == 1)
        {

            return Fbase * Fbase;
        }
        if (figura == 2)
        {
            return Fbase * Faltura;

        }
        else if (figura == 3)
        {
            return (Fbase * Faltura) / 2;
        }
        else
        {
            return pi * (radio * radio);
        }
    }


Console.WriteLine("\n\n¿Desea calcular el área de otra figura? Escriba 1 para Si y 'Enter' para No");
repetir = Console.ReadLine();

}

while (repetir=="si"|| repetir=="Si"||repetir=="SI"||repetir=="sI");

return;







