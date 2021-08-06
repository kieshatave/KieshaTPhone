using System;

namespace KieshaTPhone
{
    public class Galaxy : Phone, IRingable 
    {
        public string VersionNumber;
        public int BatteryPercentage;
        public string Carrier;
        public string RingTone;
        public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone) 
            : base(versionNumber, batteryPercentage, carrier, ringTone) 
        {
            RingTone = ringTone;
            VersionNumber = versionNumber;
            BatteryPercentage = batteryPercentage;
            Carrier = carrier;
        }
        public string Ring() 
        {
            // your code here
            return RingTone;
        }
                    
        public string Unlock() 
        {
            // your code here
            return $"Galaxy {VersionNumber} unlocked with finger.";
        }
        public override void DisplayInfo() 
        {
            // your code here
            Console.WriteLine("#############");
            Console.WriteLine($"Galaxy {VersionNumber}");
            Console.WriteLine($"Battery %: {BatteryPercentage}");
            Console.WriteLine($"Carrier: {Carrier}");
            Console.WriteLine($"Ringtone: {RingTone}");
            Console.WriteLine("#############");    
        }
    }
        
}