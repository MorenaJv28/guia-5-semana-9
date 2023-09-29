// Ejercicio 3
Console.WriteLine(@"Crea un programa en C# que le indique al usuario cuantos días faltan a partir de hoy,
para su próximo cumpleaños, puede pedir la fecha que la ingrese el usuario o dejar
su propia fecha, en cualquier caso que decida, debe de mostrar la fecha ingresada o
establecida y los días restantes a partir de la evaluación
");

Console.Write("Por favor, ingrese su fecha de cumpleaños (DD-MM): ");
if (DateTime.TryParse(Console.ReadLine(), out DateTime fechaNacimiento))
{
    DateTime fechaActual = DateTime.Today;

    if (fechaNacimiento < fechaActual)
    {
        fechaNacimiento = fechaNacimiento.AddYears(1);
    }

    TimeSpan tiempoRestante = fechaNacimiento - fechaActual;

    Console.WriteLine($"Su próximo cumpleaños es el {fechaNacimiento.ToString("dd-MM-yyyy")}.");
    Console.WriteLine($"Faltan {tiempoRestante.Days} días hasta su próximo cumpleaños.");
}
else
{
    Console.WriteLine("Fecha ingresada no válida. Por favor, utilice el formato DD-MM.");
}
