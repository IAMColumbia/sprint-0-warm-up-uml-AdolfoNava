namespace Sprint_0_Warm_Up
{
    public class Engine
    {
        public bool isStarted;
        public Engine()
        {
            this.isStarted = false;
        }
        public string About()
        {
            return "This is a fully functional engine for aerial vehicles only.";
        }
        public void Start()
        {
            isStarted = true;
        }
        public void Stop()
        {
            isStarted = false;
        }
    }
}