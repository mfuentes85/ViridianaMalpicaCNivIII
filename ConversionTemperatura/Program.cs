double celsius = 0;
double farenheit = 0;
int opcion;
string repetir;

double CelsiusAFahrenheit(double celsius)
{
    return (celsius * 1.8) + 32;
}

double FahrenheitACelsius(double farenheit)
{
    return (farenheit - 32) * 0.555;
}
 
 double CelsiusAKelvin(double celsius)
{
    return (celsius + 273.15);

}

Console.WriteLine("\nPROGRAMA DE CONVERSIÓN DE TEMPERATURA\n\nSeleccione la conversión de temperatura deseada: \n");
Console.WriteLine("1.- Celsius a Farenheit\n2.- Farenheit a Celsius\n3.- Celsius a Kelvin\n}");
opcion = int.Parse(Console.ReadLine());


do
{
    switch (opcion)
    {

        case 1:
            Console.WriteLine("\nPor favor digite la temperatura en °C que desea convertir");
            celsius = double.Parse(Console.ReadLine());
        case 2:
            Console.WriteLine("\nPor favor digite la temperatura en °Farenheit que desea convertir");
            farenheit = double.Parse(Console.ReadLine());
        case 3:
            Console.WriteLine("\nPor favor digite la temperatura en °C que desea convertir");
            celsius = double.Parse(Console.ReadLine());


        default:
            Console.WriteLine("Opción inválida, intente otra vez");
            break;
    }

    if (opcion == 1)
    {
    Console.WriteLine($"\nLa conversión de grados Celcius {celsius} a Farenheit es: {CelsiusAFahrenheit}");

    }
    else if (opcion == 2)
    {
        Console.WriteLine($"\nLa conversión de grados Farenheit {farenheit} a Celcius es: {FahrenheitACelsius}");

    }
    else
    {
        Console.WriteLine($"\nLa conversión de grados Celcius {celsius} a Kelvin es: {CelsiusAKelvin}");
    }



    Console.WriteLine("\n\n¿Desea realizar otra conversión? Escriba 1 para Si y 'Enter' para No");
    repetir = Console.ReadLine();

}

while (repetir == "si" || repetir == "Si" || repetir == "SI" || repetir == "sI");

return;


