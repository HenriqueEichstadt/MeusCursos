using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Loja.Infra
{
    public class NHibernateHelper
    {
        private static ISessionFactory fabrica = CriaSessionFactory();

        private static ISessionFactory CriaSessionFactory()
        {
            Configuration cfg = RecuperaConfiguracao();
            return cfg.BuildSessionFactory();
        }
               
        public static Configuration RecuperaConfiguracao()
        {
            Configuration cfg = new Configuration();
            cfg.Configure();
            cfg.AddAssembly(Assembly.GetExecutingAssembly());
            return cfg;
        }

        public static void GeraSchema()
        {
            Configuration cfg = RecuperaConfiguracao();
            new SchemaExport(cfg).Create(true, true);
        }

        public static ISession AbreSession()
        {
            
            return fabrica.OpenSession();
        }
    }
}
