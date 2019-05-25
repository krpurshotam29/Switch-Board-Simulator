namespace SwitchBoardSimulation
{
    public class Switch
    {
        public string ApplianceName;
        public bool ApplianceState;

        public Switch(string appliamceName)
        {
            this.ApplianceName = appliamceName;
            this.ApplianceState = false;
        }
    }
}