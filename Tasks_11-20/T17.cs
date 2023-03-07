using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioohjelmointi
{
    public class ElectricalDevice  
    {
        public bool OnOff { get; set; } = false;
        public float Power { get; set; } 
    }
    public class Radio : ElectricalDevice
    {
        public int Volume { get; private set; } = 0;
        public double Channel { get; private set; } = 0;
        
        public Radio() {}

        public void Switch() 
        {
            if(OnOff == false) {
                OnOff = true;
            }
            else OnOff = false;
        }

        public string VolumeControl(int volume, string m) 
        {
            if(OnOff == true && volume > 0 && volume < 9) 
            {   
                Volume = volume;
                m = "Volume is set to: " + Volume;
                return m;
             
            }
            else 
            {
                m = "Volume cannot be set";
                return m;
            }
        }

        public string ChannelSelection(double channel, string m) 
        {
            if(OnOff == true && channel > 2000.0 && channel < 26000.0) 
            {
                Channel = channel;
                m = "Channel is set to: " + Channel;
                return m;
            }
            else 
            {
                m = "Channel cannot be set";
                return m;
            }
        }

        public override string ToString() { return $"Radios power is: {Power}, Volume is: {Volume}, Channel is: {Channel}";}

    }

    internal class T17
    {
        public static void Test()
        {
            string message = "";
            Radio radio = new Radio();
            radio.Switch();
            radio.Power = 200;
            Console.WriteLine(radio.VolumeControl(5, message));
            Console.WriteLine(radio.ChannelSelection(2200.0, message));
            Console.WriteLine(radio);

            radio.Switch();
            Console.WriteLine(radio.VolumeControl(6, message));
                 
        }
        static void Task17()
        {
            Test();
        }
    }
}