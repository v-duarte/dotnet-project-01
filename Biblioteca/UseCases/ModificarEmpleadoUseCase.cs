namespace Biblioteca;

public class ModificarEmpleadoUseCase{
    RepositorioEmpleadoArchTexto repositorio = new RepositorioEmpleadoArchTexto();
    public void Ejecutar(Empleado emp){
        try{
            Empleado? existe = repositorio.GetEmpleado(emp.DNI);
            if (existe != null){
                repositorio.ModificarEmpleado(emp);
            }
            else{
                throw new Exception ($"El Empleado con DNI {emp.DNI} no existe.");
            }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}