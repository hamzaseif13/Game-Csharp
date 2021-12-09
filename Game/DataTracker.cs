using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public class DataTracker
    {
        public static MainMenu MainForm;

        public static PlayerObj currentPlayer;
        public static List<PlayerObj> Players;
 
        
        public static void AddPlayer (string name, int age, string gender, string color)
        {           
            PlayerObj lol = new PlayerObj(name, age, gender, color);
            Players.Add(lol);
            
        }
        
       
    }
    public class PlayerObj
    {
        public string Name;
        public int Age;
        public string Gender;
        public string Color;
        public PlayerObj(string name,int age,string gender,string color)
        {           
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Color = color;
        }
        public void EditPlayer(string name, int age, string gender, string color)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Color = color;
            
            for(int j = 0; j < DataTracker.Players.Count; j++)
            {
                if (DataTracker.Players[j] == this)
                {
                    Swap(DataTracker.Players, j, DataTracker.Players.Count - 1);
                }
            }
            
           
            
        }
        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

    }
}
