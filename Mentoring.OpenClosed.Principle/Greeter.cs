namespace Mentoring.OpenClosed.Principle
{
    public class Greeter
    {
        public string Greet(Language language)
        {
            switch (language)
            {
                case Language.French:
                    return "Bonjour";
                case Language.Spanish:
                    return "Hola";
                case Language.Italian:
                    return "Ciao";
                case Language.English:
                default:
                    return "Hello";
            }
        }
    }
}
