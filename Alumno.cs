using System;
namespace TP2;

public class Alumno
{
    private int Id {get; set;}
    private string Nombre {get; set;}
    private string Apellido { get; set; }
    private int Dni { get; set; }
    public int Curso { get; set; }

    public Alumno(int _Id, string _Nombre, string _Apellido, int _Dni, int _Curso)
    { 
        Id = _Id;
        Nombre = _Nombre;
        Apellido = _Apellido;
        Dni = _Dni;
        Curso = _Curso;
    }
}