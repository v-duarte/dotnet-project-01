namespace Biblioteca;
public class ListaDeClientesUseCase{
    RepositorioClienteArchTexto repositorio = new RepositorioClienteArchTexto();
    public List<Cliente> Ejecutar(){
        List<Cliente> lista = repositorio.GetClientes();
        return lista;
    }

}