using System;
using System.Collections.Generic;

namespace olioohjelmointi
{
    class Amplifier
    {
        public int Volume { get; set; } = 0;
        
        public string GetVolume(int volume, out string message) 
        {
            if(volume >= 0 && volume <= 100) 
            {              
                Volume = volume;
                message = "Volume is set to " + Volume.ToString();
                return message;
            }
            if(volume < 0) 
            {
                message = "Volume is too low - Volume is set to: " + Volume.ToString();
                return message;
            }
            if(volume > 100) 
            {
                message = "Volume is too loud - Volume is set to: " + Volume.ToString();
                return message;
            }
            else
            {
                message = "Enter a valid number of volume";
                return message;
            } 
        }

    }
    public class t14 
    {
        static void T14()
        {
            Amplifier amp = new Amplifier();
            string message = "";
            int volume = 0;
           
          for(int i = 0; i < 5; i++) {
                Console.WriteLine("Give a new volume value 1-100: ");
                volume = Int32.Parse(Console.ReadLine());
                Console.WriteLine(amp.GetVolume(volume, out message));  
            }

        }
    }
}