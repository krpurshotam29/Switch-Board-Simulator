using System.Collections.Generic;
using System;

namespace SwitchBoardSimulation
{
    public class SwitchBoard
    {
        private List<Switch> SwitchList;

        public SwitchBoard(int noOfFans, int noOfACs, int noOfBulbs)
        {
            SwitchList = new List<Switch>();
            int deviceId = (new Random()).Next();
            for (int i = 1; i <= noOfFans; i++)
                SwitchList.Add(new Switch((Appliance)1+" "+i,"D-"+(deviceId++)));
            for (int i = 1; i <= noOfACs; i++)
                SwitchList.Add(new Switch((Appliance)2 + " " + i,"D-"+(deviceId++)));
            for (int i = 1; i <= noOfBulbs; i++)
                SwitchList.Add(new Switch((Appliance)3 + " " + i,"D-"+(deviceId++)));
        }

        public List<Switch> GetSwitcheList()
        {
            return SwitchList;
        }

        public void SwitchTap(string deviceId){
            Switch currentSwitch = SwitchList.Find(e => e.DeviceId==deviceId);
            if(currentSwitch!=null){
                currentSwitch.ApplianceState = !currentSwitch.ApplianceState;
            }else{
                throw(new Exception("Invalid Choice"));
            }
        }
    }
}