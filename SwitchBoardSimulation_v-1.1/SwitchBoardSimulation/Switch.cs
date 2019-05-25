namespace SwitchBoardSimulation
{
    public class Switch
    {
        public string ApplianceName;
        public bool ApplianceState;
        public string DeviceId;

        public Switch(string appliamceName,string deviceId)
        {
            this.ApplianceName = appliamceName;
            this.ApplianceState = false;
            this.DeviceId = deviceId;
        }
    }
}