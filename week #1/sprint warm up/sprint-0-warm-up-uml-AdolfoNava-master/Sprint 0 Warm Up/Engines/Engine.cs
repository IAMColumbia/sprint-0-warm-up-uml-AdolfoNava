namespace Sprint_0_Warm_Up
{
    public class Engine : IEngine
    {
        public bool IsStarted { get; set; }
        public Engine()
        {
            
        }

       

        public virtual string About()
        {
            return "This is a fully functional engine for aerial vehicles only.";
        }
        public void Start()
        {
            IsStarted = true;
        }
        public void Stop()
        {
            IsStarted = false;
        }
    }
}