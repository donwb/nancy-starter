using Nancy;

namespace NancyApplication
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get("/", args => "Move along, nothing to see here...");
            Get("/root", args => Root(args));
            Get("/test/{name}", args => new Person() {Name = args.name});
            Get("/person/{name}", args => PersonTest(args));
        }

        private object Root(dynamic o)
        {
            return "From Root...";
        }

        private object PersonTest(dynamic o)
        {
            return new Person() { Name = o.name};
        }
    }


    public class Person
    {
        public string Name {get; set;}

    }
}