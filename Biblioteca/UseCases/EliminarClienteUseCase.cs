namespace Biblioteca;

public class EliminarClienteUseCase{
    RepositorioClienteArchTexto repositorio = new RepositorioClienteArchTexto();
    public void Ejecutar(int DNI)
    {
        try{
            Cliente? existe = repositorio.GetCliente(DNI);
            if (existe != null){
                repositorio.EliminarCliente(DNI);
            }
            else{
                throw new Exception ($"El Cliente con DNI {DNI} no existe.");
            }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}