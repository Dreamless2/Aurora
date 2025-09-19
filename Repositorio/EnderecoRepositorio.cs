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

        public EnderecoModel Atualizar(EnderecoModel endereco)
        {
          var enderecoDB =  BuscarPorId(endereco.Id);

            if (enderecoDB == null) throw new Exception("Endereço nao encontrado");
            enderecoDB.Nome = endereco.Nome;
            enderecoDB.Endereco = endereco.Endereco;
            enderecoDB.Numero = endereco.Numero;
            enderecoDB.Complemento = endereco.Complemento;
            enderecoDB.Bairro = endereco.Bairro;
enderecoDB.Cidade = endereco.Cidade;
            enderecoDB.Estado = endereco.Estado;
            enderecoDB.Cep = endereco.Cep;
            enderecoDB.Telefone = endereco.Telefone;
            _bancoContext.Enderecos.Update(enderecoDB);
            _bancoContext.SaveChanges();
            return enderecoDB;
        }

        public EnderecoModel BuscarPorId(int id)
        {
            var resultado = _bancoContext.Enderecos.FirstOrDefault(x => x.Id == id);
            return resultado!;
        }

        public List<EnderecoModel> BuscarTodos()
        {
            var resultado = _bancoContext.Enderecos.ToList();
            return resultado;
        }
    }
}
