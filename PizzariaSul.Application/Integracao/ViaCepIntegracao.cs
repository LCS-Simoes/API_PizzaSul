using PizzariaSul.Application.DTOs.CepDTOs;
using PizzariaSul.Application.Integracao.Interfaces;
using PizzariaSul.Application.Integracao.Refit;


namespace PizzariaSul.Application.Integracao
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {

        private readonly IViaCepIntegracaoRefit _viacepRefit;

        public ViaCepIntegracao(IViaCepIntegracaoRefit refit)
        {
            _viacepRefit = refit;
        }

        public async Task<ViaCepResponse> ObterCep(string cep)
        {
            var responseData = await _viacepRefit.ObterCep(cep);

            if(responseData != null && responseData.IsSuccessStatusCode)
            {
                return responseData.Content;
            }
            return null;    
        }
    }
}
