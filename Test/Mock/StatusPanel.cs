namespace CSD.Mock
{
    public class StatusPanel
    {
        public bool ThereIsEnoughFuel()
        {
            return false;
        }

        public bool EngineIsRunning()
        {
            // Check engine takes a long time to run
            Thread.Sleep(1000 * 100);
            return false;
        }

        public int GetSpeed()
        {
            return -1;
        }

        public bool IsReady()
        {
            return false;
        }
    }
}