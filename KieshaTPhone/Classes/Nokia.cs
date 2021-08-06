using System;

namespace KieshaTPhone
{
     public class Nokia : Phone, IRingable
    {
        public string VersionNumber;
        public int BatteryPercentage;
        public string Carrier;
        public string RingTone;
        public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) {}
        public string Ring() 
        {
            // your code here
            return RingTone;
            
        }
        public string Unlock() 
        {
            // your code here
            return $"Nokia {VersionNumber} unlocked with PassCode";
        }
        public override void DisplayInfo() 
        {
            // your code here
        Console.WriteLine("$$$$$$$$$$$$$$");
        Console.WriteLine($"Nokia {VersionNumber}");
        Console.WriteLine($"Battery %: {BatteryPercentage}");
        Console.WriteLine($"Carrier: {Carrier}");
        Console.WriteLine($"Ringtone: {RingTone}");
        Console.WriteLine("$$$$$$$$$$$$$$$");            
        }
    }
       
}