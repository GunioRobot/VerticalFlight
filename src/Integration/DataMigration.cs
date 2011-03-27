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
            _configurationService.ConnectionString = @"Data Source=tcp:sql2k802.discountasp.net;Initial Catalog=SQL2008_809759_ddvff;User ID=SQL2008_809759_ddvff_user;Password=jesika;";
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