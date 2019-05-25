using System.Collections.Generic;
using System;

namespace SwitchBoardSimulation
{
    public class SwitchBoard
    {
        List<Switch> SwitchList;

        public SwitchBoard(int noOfFan, int noOfAC, int noOfBulb)
        {
            SwitchList = new List<Switch>();
            for (int i = 1; i <= noOfFan; i++)
                SwitchList.Add(new Switch((Appliance)1+" "+i));
            for (int i = 1; i <= noOfAC; i++)
                SwitchList.Add(new Switch((Appliance)2 + " " + i));
            for (int i = 1; i <= noOfBulb; i++)
                SwitchList.Add(new Switch((Appliance)3 + " " + i));
        }

        public List<Switch> GetSwitcheList()
        {
            return SwitchList;
        }

        public void SwitchTap(int DeviceId){
            if(DeviceId<SwitchList.Count){
                Switch currentSwitch = SwitchList[DeviceId-1];
                currentSwitch.ApplianceState = !currentSwitch.ApplianceState;
            }else{
                throw(new Exception("Invalid Choice"));
            }
        }
    }
}