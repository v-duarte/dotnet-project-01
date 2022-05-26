namespace Biblioteca;
class RepositorioClienteArchTexto : IRepositorioCliente
{   
    //void AgregarCliente(Cliente cliente): Agrega al archivo Clientes.txt los datos del cliente quese pasa por parámetro.
    public void AgregarCliente(Cliente cliente)
    {
        string linea = $"{cliente.DNI}|{cliente.Apellido}|{cliente.Nombre}|{cliente.Direccion}|{cliente.FechaNacimiento.ToString("dd/MM/yyyy")}|{cliente.FechaUltimaCompra.ToString("dd/MM/yyyy")}";
        //Cargar linea con los datos de cliente con el formato pedido
        if (!File.Exists("..\\Aplicacion\\Clientes.txt")){ //Si no existe el archivo Clientes.txt.
            using (StreamWriter sw = File.CreateText("..\\Aplicacion\\Clientes.txt")){
                sw.WriteLine(linea);
            }
        }
        else{
            using (StreamWriter sw = new StreamWriter("..\\Aplicacion\\Clientes.txt", true)){
                sw.WriteLine(linea);
            }
        }       
    }

    //void EliminarCliente(int Dni): elimina del archivo Clientes.txt al cliente que posea el DNI que se pasa por parámetro.
    public void EliminarCliente(int Dni)
    {
        string[] datos;
        try
        {
            using (StreamReader sr = new StreamReader("..\\Aplicacion\\Clientes.txt")) //archivo fuente
            using (StreamWriter sw = new StreamWriter("Temporal.txt")){ //archivo temporal
                string? aux;
                while ((aux = sr.ReadLine()) != null){  //Leo una linea del archivo.
                    datos = aux.Split("|");
                    if (int.Parse(datos[0]) != Dni){
                        sw.WriteLine(aux);
                    }
                }
            } 
            File.Delete("..\\Aplicacion\\Clientes.txt"); //Elimino archivo viejo.
            File.Move("Temporal.txt", "..\\Aplicacion\\Clientes.txt");  //Renombro el archivo actualizado como Clientes.txt;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    //Cliente? GetCliente(int DNI): obtiene del archivo Clientes.txt el cliente cuyo DNI se pasa por parámetro. En caso de no existir devuelve null.
    public Cliente? GetCliente(int DNI)
    {
        string? aux;
        string[] datos;
        try
        {
            bool terminado= false;
            using StreamReader sr = new StreamReader("..\\Aplicacion\\Clientes.txt"); //archivo fuente
            aux = sr.ReadLine(); 
            while (aux != null && !terminado){    //Leo una linea del archivo.
                datos = aux.Split("|");
                if (int.Parse(datos[0]) == DNI){
                    terminado = true;
                }
                else   
                    aux = sr.ReadLine();
            }
            if (terminado && aux!=null){
                datos = aux.Split("|");
                Cliente cliente = new Cliente(int.Parse(datos[0]), datos[1], datos[2], datos[3], DateTime.Parse(datos[4]), DateTime.Parse(datos[5]));
                return cliente;
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

    //List<Cliente> GetClientes(): obtiene del archivo Clientes.txt la lista completa de clientes guardados.
    public List<Cliente> GetClientes()
    {
        string? linea;
        string[] datos;
        List<Cliente> lista = new List<Cliente>();
        Cliente actual;
        Console.SetIn(new System.IO.StreamReader("..\\Aplicacion\\Clientes.txt")); //Configuracion para leer del archivo Clientes.txt
        //Carga de datos leidos de archivo .txt a una lista
        while ((linea = Console.ReadLine())!= null){
            datos = linea.Split("|");
            //{cliente.DNI}|{cliente.Apellido}|{cliente.Nombre}|{cliente.Direccion}|{cliente.FechaNacimiento}|{cliente.FechaUltimaCompra}
            actual = new Cliente(int.Parse(datos[0]), datos[1], datos[2], datos[3], DateTime.Parse(datos[4]), DateTime.Parse(datos[5]));
            lista.Add(actual);
        }
        return lista;
    }

    //void ModificarCliente(Cliente cliente): modifica en el archivo Clientes.txt los datos del cliente pasado como parámetro.
    public void ModificarCliente(Cliente cliente)
    {
        EliminarCliente(cliente.DNI);
        AgregarCliente(cliente);
    }
}