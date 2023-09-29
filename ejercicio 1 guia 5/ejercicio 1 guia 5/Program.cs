//Ejercio1
Console.WriteLine(@"Realice un programa que permita verificar si el dado el siguiente arreglo de años
evalúe cada dato contenido y diga si es un año bisiesto o no
int[] years = new int[10] {2012,2013,2014,2015,2016,2017,2018,2019,2020};");


int[] years = new int[] { 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021 };

foreach (int Y in years)
{
    bool YBisiesto = DateTime.IsLeapYear(Y);

    Console.WriteLine($"{Y} {(YBisiesto ? "si es" : "no es")} bisiesto");
}