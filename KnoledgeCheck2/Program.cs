using System;
using static KnowledgeCheck2.HikerData;

namespace KnowledgeCheck2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records do you want to add? ");
            var numberOfRecords = int.Parse(Console.ReadLine());

            var recordList = new List<HikerData>();
            for (int i = 0; i < numberOfRecords; i++)
            {
                // In this loop, populate the object's properties using Console.ReadLine()
                var HikerData = new HikerData();

                Console.WriteLine("Enter the Hiker Name: ");
                HikerData.HikerFullName = Console.ReadLine();
                
                Console.WriteLine("Enter the Date of Hike in format MM/DD/YYYY: ");
                HikerData.DateOfHike = DateOnly.Parse(Console.ReadLine());
                
                Console.WriteLine("Enter the name of the Trail hiked: ");
                HikerData.HikingTrailName = Console.ReadLine();
                
                recordList.Add(HikerData);
                
                Console.WriteLine("Hiker data added: " + HikerData.ToString());
            }

                if (recordList.Count > 0)
            {
                Console.WriteLine(" A total of " + numberOfRecords + " Hiker data records were added.");
                foreach (var record in recordList)
                {
                    Console.WriteLine(record.ToString());
                }
            }
            
            // ^^Print out the list of records using Console.WriteLine() ^^
        }
    }
}