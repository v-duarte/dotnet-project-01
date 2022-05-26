namespace Biblioteca;

public class ModificarClienteUseCase{
    RepositorioClienteArchTexto repositorio = new RepositorioClienteArchTexto();
    public void Ejecutar(Cliente cli){
        try{
            Cliente? existe = repositorio.GetCliente(cli.DNI);
            if (existe != null){
                repositorio.ModificarCliente(cli);
            }
            else{
                throw new Exception ($"El Cliente con DNI {cli.DNI} no existe.");
            }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}