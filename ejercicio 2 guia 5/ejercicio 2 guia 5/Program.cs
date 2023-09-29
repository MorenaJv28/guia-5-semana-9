//Ejercicio 1
Console.WriteLine(@"Se adquiere un préstamo de $3,000 para cubrir los gastos de colegiatura del ciclo
2-2023 del estudiante Juan Perez de la UNAB Chalatenango, el préstamo es a un
plazo de 6 meses, la fecha de pago de la primera cuota es el dia de hoy, hacer un
programa que muestre las fechas de pago futuras y la cuota a pagar del préstamo.");

double prestamo = 3000.0; 
int PMeses = 6;
DateTime FActual = DateTime.Now;

Console.WriteLine($"Fecha de inicio: {FActual.ToString("dd-MM-yyyy")}");
Console.WriteLine();
Console.WriteLine($"Monto: {prestamo}$");
Console.WriteLine();
Console.WriteLine($"Plazo: {PMeses} meses");
Console.WriteLine();
Console.WriteLine("\nFechas de pago y cuotas:");
Console.WriteLine();

double Dividendo = prestamo / PMeses;

for (int i = 1; i <= PMeses; i++)
{
    FActual = FActual.AddMonths(1);
    Console.WriteLine($"{FActual.ToString("dd-MM-yyyy")}: ${Dividendo.ToString("0.00")}");
}

