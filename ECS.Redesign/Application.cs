namespace ECS.Redesign
{
    public class Application
    {
        public static void Main(string[] args)
        {
            var tempSensor = new TempSensor();
            var heater = new Heater();

            var ecs = new ECS(28,tempSensor,heater);

            ecs.Regulate();

            ecs.SetThreshold(20);

            ecs.Regulate();
        }
    }
}
