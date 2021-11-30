using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_InjecaoDependencia.Servicos
{
    public class ServicoScoped
    {
        public int Valor { get; set; }
    }
}

// Tem comportamento similar ao singleton, pois está em uma aplicação do lado do cliente, não tem requisição para servidor

