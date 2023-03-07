using System;
using System.Collections.Generic;

namespace olioohjelmointi
{
    class Cd
    {
        public string Artist { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }
        public String Songs { get; set; }
        
        
        public Cd(string artist, string name, string genre, double price, string[] songs)
        {
            Artist= artist;
            Name = name;
            Genre = genre;
            Price = price;   
            Songs = String.Join('\n', songs);    
        }


        public override string ToString() { return "CD:\n - Artist: " + Artist + "\n" +  "- Name: " + Name + "\n" + "- Genre: " + Genre + "\n" + "- Price: " + Price + "\n" + "- Songs:\n" + Songs; }

        

    }
    public class t11
    {
        static void T11()
        {
            List<Cd> cds = new List<Cd>();

            string[] songsArray = 
            {   "Are You Ready",
                "No More",
                "A Reason to Fight",
                "In Another Time",
                "Stronger On Your Own",
                "Hold on to Memories",
                "Savior of Nothing",
                "Watch You Burn",
                "The Best Ones Lie",
                "Already Gone",
                "The Sound of Silence (live)",
                "This Venom",
                "Are You Ready? (Sam de Jong remix)",
                "Uninvited Guest"
            };

            string[] songsArray2 = 
            {   "Strangers By Nature",
                "Easy On Me",
                "My Little Love",
                "Cry Your Heart Out",
                "Oh My God",
                "Can I Get It",
                "I Drink Wine",
                "All Night Parking",
                "Woman Like Me",
                "Hold On",
                "To Be Loved",
                "Love Is A Game"
            };

            cds.Add(new Cd("Disturbed", "Evolution", "Hard Rock", 19.2, songsArray));
            cds.Add(new Cd("Adele", "30", "Soul, R&B, pop", 22.50, songsArray2));

            foreach (Cd cd in cds)
            {
                Console.WriteLine(cd);
            }
        }
    }
}
