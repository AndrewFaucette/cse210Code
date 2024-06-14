using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        while(true){
            Console.Clear();
            Console.Write("Menu options:\n\t1. Start Breathing Activity\n\t2. Start Reflecting Activity\n\t3. Start Listing Activity\n\t4. Quit\nSelect a choice from the menu: ");
            string menu = Console.ReadLine();
            BreathingActivity breathingActivity = new BreathingActivity("Breathing");
            if (menu == "1"){
                while (breathingActivity.performActivity()){}
            } else if (menu == "2") {
                ReflectionActivity reflectionActivity = new ReflectionActivity("Reflection");
                while (reflectionActivity.performActivity()){}
            } else if (menu == "3") {
                ListingActivity listingActivity = new ListingActivity("Listing");
                while (listingActivity.performActivity()){}
            } else if (menu == "4") {
                break;
            } else {
                Console.WriteLine("That is not a valid entry. Enter a number 1-4");
                breathingActivity.loadingBar(3);
            }
        }
    }
}