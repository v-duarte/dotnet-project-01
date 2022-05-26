namespace Biblioteca;
public class Empleado : Persona
{
    public int Legajo {get; set;}

    public Empleado (int dni, string apellido, string nombre, string direccion, DateTime fecha, int legajo) : base(dni, apellido, nombre, direccion, fecha){
        
        this.Legajo = legajo;  
    }

    public override string ToString()    
    {
        return base.ToString() + $"\nLegajo: {Legajo}";    
    }    
}

