using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// To execute C#, please define "static void Main" on a class
// named Solution.

namespace EventLog {

public class Event
{
public string Name{ get; set; }
public string City{ get; set; }
}

public class Customer
{
public string Name{ get; set; }
public string City{ get; set; }
}

        class Solution
        {
            static  void Main(string[] args)
            {
                var events = new List<Event>{
                new Event{ Name = "Phantom of the Opera", City = "New York"},
                new Event{ Name = "Metallica", City = "Los Angeles"},
                new Event{ Name = "Metallica", City = "New York"},
                new Event{ Name = "Metallica", City = "Boston"},
                new Event{ Name = "LadyGaGa", City = "New York"},
                new Event{ Name = "LadyGaGa", City = "Boston"},
                new Event{ Name = "LadyGaGa", City = "Chicago"},
                new Event{ Name = "LadyGaGa", City = "San Francisco"},
                new Event{ Name = "LadyGaGa", City = "Washington"}
                };



                var customer = new Customer{ Name = "Mr. Femi", City = "New York"};
 
                // events.Where(x=>x.City==customer.City).ToList().ForEach(evt=>AddToEmail(customer, evt));
               
               var distanceCache = new Dictionary<string, int>();
               try  {

 events.OrderBy(
                  x=>{
                      var key=customer.City+x.City;
                      if(distanceCache.ContainsKey(key) )
                      {
                          return distanceCache[key];
                      }
                      else{ 
                        var distance = GetDistance(x.City, customer.City);
                        distanceCache.Add(key, distance);
                        return distance;
                      }
                  }
                ).Take(5).ToList().ForEach(evt=>AddToEmail(customer, evt));
               }catch{
                   //if get distance method fails
events.Where(x=>x.City==customer.City).Take(1).ToList().ForEach(evt=>AddToEmail(customer, evt));
               }
             
//no 5 - adding price as sort 
events.OrderBy(x=>GetPrice(x)).
OrderBy(x=>GetDistance(x.City, customer.City)).ToList().ForEach(evt=>AddToEmail(customer, evt));
               
            }


            public static int GetDistance(string fromCity, string ToCity){
                return 0;
            }


            public static int GetPrice(Event e){
                return 0;
            }


            public static void AddToEmail (Customer c, Event e)
            {

            }       

 }

}
