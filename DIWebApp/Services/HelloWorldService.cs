using DIWebApp.Interfaces;

namespace DIWebApp.Services
{
    public class HelloWorldService:IHelloWorldService
    {
        public HelloWorldService() { }

        public string SayHello()
        {
            return "Wish you a very happy Day......";
        }
    }
}
