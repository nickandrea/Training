namespace CheckWebApp.Services
{
    public interface IGreeting
    {
        string getGreting();
    }

    public class Greeting : IGreeting
    {
        public string getGreting()
        {
            return "messageof the day";
        }
    }
}
