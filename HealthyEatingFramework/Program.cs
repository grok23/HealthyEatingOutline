using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthyEatingFramework
{
    public enum DisplayPeriod { day, week, month };
    class Program
    {
        List<Foods> Foods = new List<Foods>();
        
        static void Main(string[] args)
        {


        }
    }
    
    class User
    {
        public string Name { get; set; }
        public string StudentNumber { get; set; }
        public string CourseCode { get; set; }
        public int UserHealth { get; set; }
    }

    class Foods
    {
        public string Name { get; set; }
        public int Protein { get; set; }
        public int Fat { get; set; }

        public int Carbs { get; set; }
        public int OverallHealthRating { get; set; }
        private static int FoodsCount;  //counter for types of food 
        public int FoodID               //assigns a unique number for each type of food added
        {
            get
            {
                return FoodID;
            }
            set
            {
                FoodID = value;
            }
        }

        public Foods()   // Default construct
        {
            FoodsCount++;               // increment the static variable by 1
            FoodID = FoodsCount;        // assign to the employee number attribute
        }

    }

    class FoodPurchases
    {
        public int FoodPID                          //id number for a food type, should match the Foods class object
        {
            get
            {
                return FoodPID;
            }
            set
            {
                FoodPID = value;   //should be set by retreiving the value of FoodID for the associated Foods class object 
            }
        }
        
        public DateTime DatePurchased { get; set; }  //date time of a purchase

        
        //needs methods to read FoodID from a Foods class object.
        public int CheckFoodID(Foods obj)
        {
            int value = obj.FoodID;
            return value;
        }
    }

    class FoodPurchasesManager
    {
        List<FoodPurchases> FoodsPurchased = new List<FoodPurchases>(); 
        public int TrackingPermissions { get; set; }
        
        public void AddPurchases(int foodPID, DateTime date)
        {
            FoodPurchases p1 = new FoodPurchases(){ FoodPID = foodPID, DatePurchased = date };
            FoodsPurchased.Add(p1);
        }

    }

    class applicationDisplay
    {

        public DisplayPeriod periodofdisplay { get; set; }

       public void DisplayRatings(int UserHealth, DisplayPeriod periodofdisplay)
        {
            // will work out the if the user has a good score depending 
            // on what is eating for a given time period.  
        }

        public void DisplayTimetable (string CourseCode)
        {
            //will display the timetable bassed on the coursecode and current date.
        }



    }


}
