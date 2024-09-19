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

Console.Read();