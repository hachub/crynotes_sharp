#region Using

using Autofac;

#endregion

namespace CryNotes.Api
{
    public class WebModule : Module
    {
        private readonly IConfiguration _configuration;
        
        public WebModule(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void Load(ContainerBuilder builder)
        {

        }
    }
}