using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamintusApi.Infraestrutura
{
    public class Contexto : DbContext
    {
        public Contexto(ConnectionStringSettings connectionStringSettings)
        {
        }

        protected void AdicionarMapeamentos(DbModelBuilder dbModelBuilder)
        {
        }
    }
}
