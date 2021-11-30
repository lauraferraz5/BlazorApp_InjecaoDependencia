using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_InjecaoDependencia.Servicos
{
    public class ServicoTransient
    {
        public int Valor { get; set; }
    }
}

// A cada nova solicitação de serviço, ele vai criar uma nova instância 
// Se eu saio da página counter e retorno, o current count e transient são zerados, enquanto singleton e scoped conservam os valores anteriores(eles só mudam se houver atualização da página)