using System;

namespace Collections
{
    class CollectionsExamples
    {
        static void Main()
        {
            //Dimo's way of method presentation
            /* var collection = new Collection<int>(); // New empty collection
             Console.WriteLine("Current collection: " + collection);

             Console.WriteLine("Collection count: " + collection.Count); // Count the collection
             Console.WriteLine("Collection capacity: " + collection.Capacity); // Collection capacity

             collection.Add(5); // Add single integer to the collection
             Console.WriteLine("Current collection: " + collection);

             collection.AddRange(7, 9); // Add range of integers to the collection
             Console.WriteLine("Current collection: " +collection);

             Console.WriteLine("Print the first element: " + collection[0]); // Print element from the collection

             collection[0] = 25; // Change integer from the collection
             Console.WriteLine("Print the first element: " + collection[0]);

             collection.InsertAt(1, 666); // Insert a new integer in the collection on specific place
             Console.WriteLine("Print the second element: " + collection);

             collection.Exchange(0, 2); // Switch indexes places
             Console.WriteLine("Current collection: " + collection);

             collection.Clear(); // Clear everything from the collection
             Console.WriteLine("Current collection: " + collection); */


            // Softuni's way of method presentation
            Console.WriteLine();
            Console.WriteLine("Collection<T> Examples");
            Console.WriteLine("======================");
            Console.WriteLine();

            Collections<int> nums = new Collections<int>();
            Console.WriteLine($"Empty collection: {nums}");
            Console.WriteLine("Empty collection: " + nums);

            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();

            nums = new Collections<int>(new int[] { 10, 20, 30, 40, 50 });
            Console.WriteLine(nums);
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();

            nums.Add(60);
            Console.WriteLine("Added: 60");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums[1] = 2000;
            nums[5] = 6000;
            Console.WriteLine("Changed: nums[1] and nums[5]");
            Console.WriteLine(nums);
            Console.WriteLine();

            Console.WriteLine($"num[0] = {nums[0]}");
            Console.WriteLine($"num[3] = {nums[3]}");
            Console.WriteLine();

            var removedItem = nums.RemoveAt(0);
            Console.WriteLine($"Removed item from position #0. Value = {removedItem}");
            Console.WriteLine(nums);
            Console.WriteLine();

            removedItem = nums.RemoveAt(4);
            Console.WriteLine($"Removed item from position #4. Value = {removedItem}");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums.Exchange(0, 1);
            Console.WriteLine("Exchanged positions #0 and #1");
            Console.WriteLine(nums);
            Console.WriteLine();

            for (int i = 1; i <= 20; i++)
                nums.Add(i);
            Console.WriteLine("Added numbers [1...20]");
            Console.WriteLine(nums);
            Console.WriteLine();

            nums.InsertAt(0, 10);
            nums.InsertAt(1, 15);
            Console.WriteLine("Inserted 10 at the start and 15 after it");
            Console.WriteLine(nums);
            Console.WriteLine($"Count: {nums.Count}. Capacity: {nums.Capacity}");
            Console.WriteLine();
        }
    }
}