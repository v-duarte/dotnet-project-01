namespace Biblioteca;
public class Cliente : Persona
{
    //Además, para el caso del cliente, se debe proveer de una propiedad de solo lectura que permita calcular en días, el tiempo desde la última compra del cliente. 

    public DateTime FechaUltimaCompra {get; set;}
    public int diasDesdeUC {get; private set;}

    public Cliente (int dni, string apellido, string nombre, string direccion, DateTime fechaNac, DateTime fechaCompra) : base(dni, apellido, nombre, direccion, fechaNac){
        this.FechaUltimaCompra = fechaCompra;
        this.diasDesdeUC = DiasDesdeFecha(fechaCompra);
    }

    int DiasDesdeFecha(DateTime d1) {
        DateTime hoy = DateTime.Today;
        TimeSpan span = hoy.Subtract(d1);
        return (int)span.TotalDays;
    }

    public override string ToString()    
    {
        return base.ToString() + $"\nFecha Ultima Compra: {FechaUltimaCompra.ToString("dd/MM/yyyy")}";    
    }
}