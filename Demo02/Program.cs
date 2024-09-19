

using Demo02;

void PrimeraForma()
{
    List<string> materias = new List<string>();
    Estudiante estudiante = new Estudiante
    {
        Nombres = "Ronald",
        Apellidos = "Cueva",
        Materias = materias
    };

    //Agregar materias a mi estudiante
    estudiante.Materias.Add("Lenguaje");
    estudiante.Materias.Add("Matemática");
    estudiante.Materias.Add("Historia");

    Console.WriteLine(estudiante.Nombres);
    Console.WriteLine(estudiante.Apellidos);

    foreach (var item in estudiante.Materias)
    {
        Console.WriteLine(item);
    }
}

void SegundoForma()
{
    List<string> materias = new List<string>();

    materias.Add("Lenguaje");
    materias.Add("Matematica");
    materias.Add("Historia");


    Estudiante estudiante = new Estudiante
    {
        Nombres = "Ronald",
        Apellidos = "Cueva",
        Materias = materias
    };

    Console.WriteLine(estudiante.Nombres);
    Console.WriteLine(estudiante.Apellidos);

    foreach (var item in estudiante.Materias)
    {
        Console.WriteLine(item);
    }
}

void TerceraForma()
{  
    //Crear el objeto estudiante
    Estudiante estudiante = new Estudiante
    {
        Nombres = "Ronald",
        Apellidos = "Cueva",
        Materias = new List<string>() 
    };

    //Asignar materias
    estudiante.Materias.Add("Lenguaje");
    estudiante.Materias.Add("Matematica");
    estudiante.Materias.Add("Historia");

    Console.WriteLine(estudiante.Nombres);
    Console.WriteLine(estudiante.Apellidos);

    foreach (var item in estudiante.Materias)
    {
        Console.WriteLine(item);
    }
}


void CuartaForma()
{

    //Crear el objeto estudiante
    Estudiante estudiante = new Estudiante
    {
        Nombres = "Ronald",
        Apellidos = "Cueva",
        Materias = new List<string>
        {
            "Lenguaje",
            "Matematica",
            "Historia"
        }
    };

    Console.WriteLine(estudiante.Nombres);
    Console.WriteLine(estudiante.Apellidos);

    foreach (var item in estudiante.Materias)
    {
        Console.WriteLine(item);
    }
}


Estudiante estudiante = new Estudiante();
estudiante.Nombres = "Hugp";
estudiante.Apellidos = "Torrico";


Console.Read();



