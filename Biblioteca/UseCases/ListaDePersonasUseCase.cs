namespace Biblioteca;
public class ListaDePersonasUseCase{
    RepositorioClienteArchTexto repositorioClientes = new RepositorioClienteArchTexto();
    RepositorioEmpleadoArchTexto repositorioEmpleados = new RepositorioEmpleadoArchTexto();
    public List<Persona> Ejecutar(){
        List<Persona> lista = new List<Persona>();
        List<Cliente> listaClientes = new ListaDeClientesUseCase().Ejecutar();
        List<Empleado> listaEmpleados = new ListaDeEmpleadosUseCase().Ejecutar();
        foreach(var cliente in listaClientes){ //Agrego los clientes a la lista de personas
            lista.Add(cliente);
        }
        foreach(var empleado in listaEmpleados){ //Agrego los empleados a la lista de personas
            lista.Add(empleado);
        }
        lista.Sort(new ComparadorDePersonas());
        return lista;               
    }

}