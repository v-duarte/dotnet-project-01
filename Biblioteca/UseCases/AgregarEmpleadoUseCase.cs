namespace Biblioteca;

public class AgregarEmpleadoUseCase{
    RepositorioEmpleadoArchTexto repositorio = new RepositorioEmpleadoArchTexto();
    public void Ejecutar(Empleado emp){
        try{
            Empleado? existe = repositorio.GetEmpleado(emp.DNI);
            if (existe == null){
                repositorio.AgregarEmpleado(emp);
            }
            else{
                throw new Exception ($"El Empleado con DNI {emp.DNI} ya existe.");
            }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}