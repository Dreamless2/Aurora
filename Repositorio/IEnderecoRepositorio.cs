using Aurora.Models;

namespace Aurora.Repositorio
{
    public interface IEnderecoRepositorio
    {
        EnderecoModel Adicionar(EnderecoModel endereco);
        List<EnderecoModel> Listar();
    }
}
