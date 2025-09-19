using Aurora.Models;

namespace Aurora.Repositorio
{
    public interface IEnderecoRepositorio
    {
        EnderecoModel Adicionar(EnderecoModel endereco);
        List<EnderecoModel> BuscarTodos();
        EnderecoModel BuscarPorId(int id);
        //EnderecoModel Atualizar(EnderecoModel endereco);
        //bool Apagar(int id);
    }
}
