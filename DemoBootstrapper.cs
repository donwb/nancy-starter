using System;
using Nancy;
using Nancy.Configuration;

namespace NancyApplication
{

    public class DemoBootstrapper : DefaultNancyBootstrapper
    {
        public DemoBootstrapper()
        {
            
        }

        public override void Configure(INancyEnvironment environment)
        {
            environment.Tracing(
                enabled: true,
                displayErrorTraces: true
            );
        }
    }
}