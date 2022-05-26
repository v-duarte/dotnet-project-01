namespace Biblioteca;
public class ListaDeEmpleadosUseCase{
    RepositorioEmpleadoArchTexto repositorio = new RepositorioEmpleadoArchTexto();
    public List<Empleado> Ejecutar(){
        List<Empleado> lista = repositorio.GetEmpleados();
        return lista;
    }

}