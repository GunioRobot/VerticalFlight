using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using VerticalFlight.Core.Data.NHibernate;
using VerticalFlight.Core.Services.Configuration;

namespace Integration
{
    [TestFixture]
    public class DataMigration
    {
        [SetUp]
        public void SetUp()
        {
            _configurationService = new FakeConfigurationService();
            _configurationService.ConnectionString = @"data source=.\SQLEXPRESS;Integrated Security=SSPI;AttachDBFilename=C:\Source\git\VerticalFlight\src\Web.UI\App_Data\VERTICALFLIGHT.MDF;User Instance=true";
            _dbConfiguration = new NHibernateConfiguration(_configurationService);
            _sessionFactory = _dbConfiguration.CreateSessionFactory();
            _repository = new NHibernateRepository(_sessionFactory.OpenSession());
        }

        [Test]
        public void MigrateDatabase()
        {
            new SchemaExport(_dbConfiguration.Configuration).Create(true, true);
        }

        static FakeConfigurationService _configurationService;
        static NHibernateConfiguration _dbConfiguration;
        static NHibernateRepository _repository;
        ISessionFactory _sessionFactory;
    }

    public class FakeConfigurationService : ConfigurationService
    {
        public string ConnectionString { get; set; }
    }
}