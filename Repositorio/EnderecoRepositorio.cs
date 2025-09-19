using Aurora.Data;
using Aurora.Models;

namespace Aurora.Repositorio
{
    public class EnderecoRepositorio : IEnderecoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public EnderecoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;

        }
        public EnderecoModel Adicionar(EnderecoModel endereco)
        {
            _bancoContext.Enderecos.Add(endereco);
            _bancoContext.SaveChanges();
            return endereco;
        }

        public EnderecoModel BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<EnderecoModel> BuscarTodos()
        {
            var resultado = _bancoContext.Enderecos.ToList();
            return resultado;
        }
    }
}
