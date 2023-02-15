using System;
namespace olioohjelmointi
{
    class Television
    {
        public bool IsTvOn { get; set; }
        public int Channel { get; set; }
        public int Volume { get; set; }

        public void ChangeVolume(char vol)
        {
            if (IsTvOn == true)
            {
                if(vol == '+')
                {
                    Volume += 1;   
                }
                else
                {
                    Volume -= 1;
                }    
            }
            else
            {
                return;
            }
        }

        public String GetSettings()
        {
            if (IsTvOn == true)
            {
                return "Current channel is " + Channel + " and volume is set to " + Volume;
            }
            else
            {
                return "Television is off";
            }
        }
    }
    public class t8
    {
        static void Main()
        {
            Television viewing = new Television();
            viewing.IsTvOn = true;
            viewing.Channel = 1;
            viewing.Volume = 10;
            Console.WriteLine(viewing.GetSettings());

            Console.WriteLine("To change the channel type a number 1-13: ");
            string ans = Console.ReadLine();
            viewing.Channel = Int32.Parse(ans);
            Console.WriteLine("To change the volume type + or - ");
            string vol = Console.ReadLine();
            viewing.ChangeVolume(char.Parse(vol));
            Console.WriteLine(viewing.GetSettings());
        }
    }
}

