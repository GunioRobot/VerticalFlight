using FluentNHibernate.Automapping;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Cfg;
using VerticalFlight.Core.Services;

namespace VerticalFlight.Core.Data.NHibernate
{
    public class NHibernateConfiguration
    {
        readonly ConfigurationService _configurationService;

        public NHibernateConfiguration(ConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        public ISessionFactory CreateSessionFactory()
        {
            return Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                    .ConnectionString(_configurationService.ConnectionString)
                    .AdoNetBatchSize(20))
                .Mappings(m =>
                    m.AutoMappings.Add(
                    AutoMap.AssemblyOf<NHibernateRepository>(new MyAutoConfig())
                    .Conventions.Add(
                        Table.Is(x => x.EntityType.Name),
                        PrimaryKey.Name.Is(x => x.EntityType.Name + "ID"),
                        ForeignKey.EndsWith("ID")
                    )))
                    .ExposeConfiguration(cfg=> Configuration = cfg)
                .BuildSessionFactory();
        }

        public Configuration Configuration { get; set; }

        public class MyAutoConfig : DefaultAutomappingConfiguration
        {
            public override bool IsId(FluentNHibernate.Member member)
            {
                return member.Name == member.DeclaringType.Name + "ID";
            }

            public override bool ShouldMap(System.Type type)
            {
                return type.Namespace.EndsWith("Domain");
            }
        }
    }
}