using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp_InjecaoDependencia.Servicos
{
    public class ServicoSingleton
    {
        public int Valor { get; set; }
    }
}

// O tempo de vida singleton vai criar uma instância única que vai usar durante todo o tempo de vida da aplicação
