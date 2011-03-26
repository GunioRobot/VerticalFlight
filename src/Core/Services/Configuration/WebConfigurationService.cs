using System.Configuration;

namespace VerticalFlight.Core.Services.Configuration
{
    public class WebConfigurationService : ConfigurationService
    {
        public string ConnectionString
        {
            get { return ConfigurationManager.ConnectionStrings["ApplicationServices"].ConnectionString; }
        }
    }
}