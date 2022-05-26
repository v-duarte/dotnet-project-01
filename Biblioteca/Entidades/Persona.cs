using System.Collections;

namespace Biblioteca;

public abstract class Persona
{
    public string Nombre {get; set;}
    public string Apellido {get; set;}
    public int DNI {get; set;}
    public string Direccion {get; set;}
    public DateTime FechaNacimiento {get; set;}

    //DNI|Apellido|Nombre|Direccion|FechaDeNacimiento
    protected Persona (int dni, string apellido, string nombre, string direccion, DateTime fecha){
        this.Nombre = nombre;
        this.Apellido = apellido;
        this.DNI = dni;
        this.Direccion = direccion;
        this.FechaNacimiento = fecha;
    }

    public override string ToString()
    {
         return $"DNI: {DNI} \nApellido: {Apellido} \nNombre: {Nombre} \nDireccion: {Direccion} \nFecha de Nacimiento: {FechaNacimiento.ToString("dd/MM/yyyy")}";
    }
}