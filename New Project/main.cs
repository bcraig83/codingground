using System.IO;
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        candidate1();
    }
    
    static void candidate1()
    {
        //Console.WriteLine(boneill.Utilities.IsPalindrome("ABBA"));
        //boneill.FlightBuilder fb = new boneill.FlightBuilder();
        //boneill.Utilities.FizzBuzz();
    }
}


namespace boneill
{
    public class Utilities
    {
        public static bool? IsPalindrome (string word)
        {
            string reverse = String.Empty;
     
            try
            {
                // loop backwards and get reverse of word
                for (int counter = word.Length; counter >= 0; counter--)   
                {
                    reverse += word[counter].ToString();
                }
         
                // test if reverse is the same as original
                if (word == reverse) return true;
         
                // will only be reached if above if is not met
                return false;
            }
            catch(Exception)
            {
                Console.WriteLine("cp6");
                return null;
            }
        }
        
        /*
        public static void FizzBuzz()
        {
     
            for (counter = 1; counter <= 100; counter++)
            {
                // determine if bizzfizz
                if (counter % 15 == 0) Console.WriteLine('FizzBuzz'); // 3x5=15 e.g. 120 is mod 3 and 5 (and divides by 15)
                else if (counter % 5 == 0) Console.WriteLine('Buzz');
                else if (counter % 3 == 0) Console.WriteLine('Fizz');
                else Console.WriteLine(counter);
            }
        }
        */
        
    }
    
    /*
    public class FlightBuilder : IFlightBuilder
    {
        // ctor
        public FlightBuilder() { }
        
        // ctor
        public FlightBuilder(string carrierCode, int flightNumber, boolean landed)
        {
            this.CarrierCode = carrierCode;
            this.FlightNumber = flightNumber;
            this.Landed = landed;
        }
        
        // private variables
        private string carrierCode;
        private int flightNumber ;
        private boolean landed ;
        
        // public setters & getters
        public string CarrierCode
        {
            set {this.carrierCode = value;}
            get {return this.carrierCode;}
        }
        
        public int FlightNumber
        {
            set {this.flightNumber = value;}
            get {return this.flightNumber;}
        }
        
        public boolean Landed
        {
            set {this.landed = value;}
            get {return this.landed;}
        }
    }
    */
}