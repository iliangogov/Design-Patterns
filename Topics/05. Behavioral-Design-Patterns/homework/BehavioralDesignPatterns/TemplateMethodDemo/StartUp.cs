namespace TemplateMethodDemo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            HeavyLifter amateur = new AmateurLifter("Mosquito");
            HeavyLifter pro = new ProLifter("Arnold");

            amateur.SayHowMuchYouLift();
            pro.SayHowMuchYouLift();
        }
    }
}
