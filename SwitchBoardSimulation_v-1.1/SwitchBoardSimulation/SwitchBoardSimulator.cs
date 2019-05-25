using System.Collections.Generic;
using System;

namespace SwitchBoardSimulation
{
    public class SwitchBoardSimulator
    {
        SwitchBoard switchBoard;

        public SwitchBoardSimulator()
        {
            string NoOfFan,NoOfAC,NoOfBulb;

            do{
                Console.WriteLine("Enter the numberof Fan : ");
                NoOfFan = Console.ReadLine();
            }while(!IsValidNumber(NoOfFan));
            do{
                Console.WriteLine("Enter the numberof AC : ");
                NoOfAC = Console.ReadLine();
            }while(!IsValidNumber(NoOfAC));
            do{
                Console.WriteLine("Enter the numberof Bulb : ");
                NoOfBulb = Console.ReadLine();
            }while(!IsValidNumber(NoOfBulb));

            switchBoard = new SwitchBoard(int.Parse(NoOfFan), int.Parse(NoOfAC), int.Parse(NoOfBulb));
        }

        public void MainMenu(){
            Console.WriteLine("**********  Welcome to Switch Board Simulator Application  **********");
            while(true){
                DisplayConfiguration();
                string choice;
                do{
                    Console.Write("Choose your Device to Tap : ");
                    choice = Console.ReadLine();
                }while(!IsValidNumber(choice));
                try{
                    switchBoard.SwitchTap(switchBoard.GetSwitcheList()[int.Parse(choice)-1].DeviceId);
                }catch(Exception e){
                    Console.WriteLine(e);
                }
            }
        }

        private void DisplayConfiguration()
        {
            List<Switch> switchList = switchBoard.GetSwitcheList();
            Console.WriteLine("\n\n");
            foreach(Switch @switch in switchList)
            {
                Console.WriteLine((switchList.IndexOf(@switch)+1)+" : "+@switch.ApplianceName + " " + (@switch.ApplianceState ? "On" : "Off"));
            }
        }

        private bool IsValidNumber(string s){
            try{
                int n = int.Parse(s);
                if(n>0 && n<int.MaxValue)
                    return true;
            }catch(Exception){
                Console.WriteLine("Invalid Number");
            }
            return false;
        }
    }
}