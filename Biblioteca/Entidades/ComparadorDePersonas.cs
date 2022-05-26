namespace Biblioteca;
class ComparadorDePersonas: IComparer<Persona>
{
    public int Compare(Persona? x, Persona? y)
    {
        int result = 1;
        if (x is Persona && y is Persona)                  // Comparo 2 personas por Apellido.
        {           
		    string apellido1 = ((Persona)x).Apellido;
            string apellido2 = ((Persona)y).Apellido;
            result = apellido1.CompareTo(apellido2);
            if (result == 0)                                   //Si el apellido coincide Comparo por Nombre.
	        {
	            string nombre1 = ((Persona)x).Nombre;
                string nombre2 = ((Persona)y).Nombre;
                result = nombre1.CompareTo(nombre2);
	        }
        }       
    return result;
    }
}