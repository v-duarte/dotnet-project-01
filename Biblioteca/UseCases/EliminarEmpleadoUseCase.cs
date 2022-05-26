namespace Biblioteca;

public class EliminarEmpleadoUseCase{
    RepositorioEmpleadoArchTexto repositorio = new RepositorioEmpleadoArchTexto();
    public void Ejecutar(int DNI)
    {
        try{
            Empleado? existe = repositorio.GetEmpleado(DNI);
            if (existe != null){
                repositorio.EliminarEmpleado(DNI);
            }
            else{
                throw new Exception ($"El Empleado con DNI {DNI} no existe.");
            }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}