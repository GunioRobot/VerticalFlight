using System.Linq;
using NHibernate;
using StructureMap;
using StructureMap.Configuration.DSL;
using VerticalFlight.Core.Data;
using VerticalFlight.Core.Data.NHibernate;
using VerticalFlight.Core.Services.Configuration;
using VerticalFlight.Core.Services.FileUploader;

namespace VerticalFlight.Core.Dependencies
{
    public static class DependencyRegistrar
    {
        public static void RegisterDependencies()
        {
            ObjectFactory.Initialize(of=>
                {
                    of.AddRegistry<RepositoryRegistry>();
                    of.AddRegistry<ServiceRegistry>();
                });
        }
    }

    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            For<ConfigurationService>().Use<WebConfigurationService>();
            For<FileUploaderService>().Use<HttpFileUploaderService>();
        }
    }

    public class RepositoryRegistry : Registry
    {
        public RepositoryRegistry()
        {
            var pluginTypes = typeof(Repository).Assembly.GetTypes().Where(t => !t.Name.StartsWith("NHibernate") && t.Name.EndsWith("Repository"));
            foreach (var pluginType in pluginTypes) {
                var concreteType =
                    typeof(NHibernateRepository).Assembly.GetTypes()
                        .FirstOrDefault(t =>
                            t.Name.StartsWith("NHibernate") &&
                            t.Name.EndsWith("Repository") &&
                            pluginType.IsAssignableFrom(t));

                if (concreteType != null)
                    For(pluginType).Use(concreteType);
            }

            For<ISessionFactory>().UseSpecial(
                x => x.ConstructedBy(
                    () => ObjectFactory.GetInstance<NHibernateConfiguration>()
                        .CreateSessionFactory()))
                .Singleton();
            
        }
    }
}