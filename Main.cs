using System;
namespace TP2;

public static class Program
{ 
    public static void Main(string[] args)
    {
        Alumno a1;
        
        // Alunmo Variables
        int Id, Dni, Curso;
        string Nombre, Apellido;

        try
        {
            Console.WriteLine("    _________");
            Console.WriteLine("___| ALUMNOS |__________");

            Console.WriteLine(" - Ingrese Id: ");
            Id = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine(" - Ingrese DNI: ");
                Dni = Convert.ToInt32(Console.ReadLine());

            } while (Dni < 0 && Dni > 999999999);

            do
            {
                Console.WriteLine(" - Ingrese Curso: ");
                Curso = Convert.ToInt32(Console.ReadLine());

            } while (Curso < 0 && Curso > 2);

            Console.WriteLine(" - Ingrese Nombre: ");
            Nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine(" - Ingrese Apellido: ");
            Apellido = Convert.ToString(Console.ReadLine());

            a1(Id, Nombre, Apellido, Dni, Curso);

            using (StreamWriter sr = new StreamWriter(Get_Route(a1)))
            {
                Write_Alumno(a1, sr);
            }

            sr.Close(); 

        }
        catch (FormatException)
        {
            Console.WriteLine("Error de formato!");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error de representacion!");
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("Error archivo no encontrado!");
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception encontrada! ", e);
        }
    }

    static string Get_Route(Alumno a0)
    {
        string? ruta0;

        switch (a0.Curso)
        {
            case 0: 
                ruta0 = @"C:\Users\joaqu\Desktop\Transportar\2Anio_2C\Taller_de_Lenguajes_II\tl2-tp2-2022-joaquinaguerotrevisan\Atletismo.csv";
                break;

            case 1: 
                ruta0 = @"C:\Users\joaqu\Desktop\Transportar\2Anio_2C\Taller_de_Lenguajes_II\tl2-tp2-2022-joaquinaguerotrevisan\Voley.csv";
                break;

            case 2: 
                ruta0 = @"C:\Users\joaqu\Desktop\Transportar\2Anio_2C\Taller_de_Lenguajes_II\tl2-tp2-2022-joaquinaguerotrevisan\Football.csv";
                break;
        }

        return ruta0;
    }

    static void Write_Alumno(Alumno a0, StreamWriter sr)
    {
        sr.WriteLine(a0.Id + ";" + a0.Nombre + ";" + a0.Apellido + ";" + a0.Dni);
    }

}