using CodigoClase08;

Profesor profesor = new Profesor
{
    Apellidos = "Torrico Márquez",
    Nombres = "Hugo Felipe",
    EscalaSalarial = 1,
    TipoDocumento = "DNI"
};

profesor.AsignarSueldo();
Console.WriteLine(profesor.Sueldo);


//Trabajador 1
Trabajador trabajador = new Trabajador
{
    SueldoBruto = 5000
};
Console.WriteLine(trabajador.CalcularSueldoNeto());

//Trabajador 2
Trabajador trabajador2 = new Trabajador
{
    SueldoBruto = 10000
};
Console.WriteLine(trabajador2.CalcularSueldoNeto());


Math.Sqrt(16);
Calculadora.Multiplicar(5, 4);
Calculadora.Multiplicar(8, 7);

Console.Read();