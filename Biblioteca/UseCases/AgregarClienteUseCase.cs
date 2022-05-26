namespace Biblioteca;

public class AgregarClienteUseCase{
    RepositorioClienteArchTexto repositorio = new RepositorioClienteArchTexto();
    public void Ejecutar(Cliente cli){
        try{
            Cliente? existe = repositorio.GetCliente(cli.DNI);
            if (existe == null){
                repositorio.AgregarCliente(cli);
            }
            else{
                throw new Exception ($"El Cliente con DNI {cli.DNI} ya existe.");
            }
        }
        catch (Exception e){
            Console.WriteLine(e.Message);
        }
    }
}