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



do
{
    Console.WriteLine("\nPROGRAMA DE CONVERSIÓN DE TEMPERATURA\n\nSeleccione la conversión de temperatura deseada: \n");
    Console.WriteLine("1.- Celsius a Farenheit\n2.- Farenheit a Celsius\n3.- Celsius a Kelvin\n");
    opcion = int.Parse(Console.ReadLine());

    switch (opcion)
    {

        case 1:
            Console.WriteLine("\nPor favor digite la temperatura en °C que desea convertir");
            celsius = double.Parse(Console.ReadLine());
            break;
        case 2:
            Console.WriteLine("\nPor favor digite la temperatura en °Farenheit que desea convertir");
            farenheit = double.Parse(Console.ReadLine());
            break;

        case 3:
            Console.WriteLine("\nPor favor digite la temperatura en °C que desea convertir");
            celsius = double.Parse(Console.ReadLine());
            break;


        default:
            Console.WriteLine("Opción inválida, intente otra vez");
            break;
    }

    if (opcion == 1)
    {
        Console.WriteLine($"\nLa conversión de grados Celcius {celsius} a Farenheit es: {CelsiusAFahrenheit(celsius)}");

    }
    else if (opcion == 2)
    {
        Console.WriteLine($"\nLa conversión de grados Farenheit {farenheit} a Celcius es: {FahrenheitACelsius(farenheit)}");

    }
    else
    {
        Console.WriteLine($"\nLa conversión de grados Celcius {celsius} a Kelvin es: {CelsiusAKelvin(celsius)}");
    }



    Console.WriteLine("\n\n¿Desea realizar otra conversión? Escriba Si para continuar y 'Enter' para terminar");
    repetir = Console.ReadLine();
    Console.Clear();

}

while (repetir == "si" || repetir == "Si" || repetir == "SI" || repetir == "sI");

return;



