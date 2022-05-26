namespace Biblioteca;
class RepositorioEmpleadoArchTexto : IRepositorioEmpleado
{
    public void AgregarEmpleado(Empleado empleado)
    {
        string linea = $"{empleado.DNI}|{empleado.Apellido}|{empleado.Nombre}|{empleado.Direccion}|{empleado.FechaNacimiento.ToString("dd/MM/yyyy")}|{empleado.Legajo}";
        //Cargar linea con los datos de cliente con el formato pedido
        if (!File.Exists("..\\Aplicacion\\Empleados.txt")){ //Si no existe el archivo Clientes.txt.
            using (StreamWriter sw = File.CreateText("..\\Aplicacion\\Empleados.txt")){
                sw.WriteLine(linea);
            }
        }
        else{
            using (StreamWriter sw = new StreamWriter("..\\Aplicacion\\Empleados.txt", true)){
                sw.WriteLine(linea);
            }
        }  
    }

    public void EliminarEmpleado(int Dni)
    {
        string[] datos;
        try
        {
            using (StreamReader sr = new StreamReader("..\\Aplicacion\\Empleados.txt")) //archivo fuente
            using (StreamWriter sw = new StreamWriter("Temporal.txt")){ //archivo temporal
                string? aux;
                while ((aux = sr.ReadLine()) != null){  //Leo una linea del archivo.
                    datos = aux.Split("|");
                    if (int.Parse(datos[0]) != Dni){
                        sw.WriteLine(aux);
                    }
                }
            } 
            File.Delete("..\\Aplicacion\\Empleados.txt"); //Elimino archivo viejo.
            File.Move("Temporal.txt", "..\\Aplicacion\\Empleados.txt");  //Renombro el archivo actualizado como Empleados.txt;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public Empleado? GetEmpleado(int DNI)
    {
        string? aux;
        string[] datos;
        try
        {
            bool terminado= false;
            using StreamReader sr = new StreamReader("..\\Aplicacion\\Empleados.txt"); //archivo fuente
            aux = sr.ReadLine();   
            while (aux != null && !terminado){   //Leo una linea del archivo.
                datos = aux.Split("|");
                if (int.Parse(datos[0]) == DNI){
                    terminado = true;
                }
                else   
                    aux = sr.ReadLine();
            }
            if (terminado && aux!=null){
                datos = aux.Split("|");
                Empleado empleado = new Empleado(int.Parse(datos[0]), datos[1], datos[2], datos[3], DateTime.Parse(datos[4]), int.Parse(datos[5]));
                return empleado;
            }
            else
                return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return null;

        }
    }

    public List<Empleado> GetEmpleados()
    {
        string? linea;
        string[] datos;
        List<Empleado> lista = new List<Empleado>();
        Empleado actual;
        Console.SetIn(new System.IO.StreamReader("..\\Aplicacion\\Empleados.txt")); //Configuracion para leer del archivo Clientes.txt
        //Carga de datos leidos de archivo .txt a una lista
        while ((linea = Console.ReadLine())!= null){
            datos = linea.Split("|");
            actual = new Empleado(int.Parse(datos[0]), datos[1], datos[2], datos[3], DateTime.Parse(datos[4]), int.Parse(datos[5]));
            lista.Add(actual);
        }
        return lista;
    }

    public void ModificarEmpleado(Empleado empleado)
    {
        EliminarEmpleado(empleado.DNI);
        AgregarEmpleado(empleado);
    }
}
