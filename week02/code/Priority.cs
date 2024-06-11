public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        // var priorityQueue = new PriorityQueue();
        // Console.WriteLine(priorityQueue);

        // Test Cases

        // Test 1
        // Scenario: Create a queue with the values and priorities: (Study 30 mins, 2), (Sleep 4 hours, 5), (Play Game, 0)
        // Expected Result: [Study 30 min (Pri:2), Sleep 4 hours (Pri:5), Play Game (Pri:0)]
        Console.WriteLine("Test 1");
        var priority = new PriorityQueue();
        priority.Enqueue("Study 30 min", 2);
        priority.Enqueue("Sleep 4 hours", 5);
        priority.Enqueue("Play Game", 0);
        Console.WriteLine(priority);


        // Defect(s) Found:
        /*
            No defects
        */

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Deque items with the values and priorities: (Study 30 mins, 2), (Sleep 4 hours, 5), (Play Game, 0)
        // Expected Result: Sleep 4 hours, Study 30 mins, Play Game
        Console.WriteLine("Test 2");

        priority = new PriorityQueue();
        priority.Enqueue("Study 30 min", 2);
        priority.Enqueue("Sleep 4 hours", 5);
        priority.Enqueue("Play Game", 0);

        var dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);
        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);
        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);

        // Defect(s) Found: 
        /*
            The highest priority values are correctly identified but not removed.
            Use RemoveAt to remove it.
        */

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Dequeue and Empty Queue
        // Result: The queue is empty
        Console.WriteLine("Test 3");

        priority = new PriorityQueue();
        priority.Dequeue();

        // Defects
        /*
            No defects
        */

        Console.WriteLine("---------");

        //Test 4
        // Scenario: 
        // Result:
        Console.WriteLine("Test 4");

        priority = new PriorityQueue();
        priority.Enqueue("Attend class", 10);
        priority.Enqueue("Study 30 min", 2);
        priority.Enqueue("Sleep 4 hours", 5);
        priority.Enqueue("Play Game", 0);
        priority.Enqueue("Watch Movies", 0);
        priority.Enqueue("Do research", 5);

        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);
        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);
        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);
        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);
        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);
        dequeueValue = priority.Dequeue();
        Console.WriteLine(dequeueValue);

        // Defects
        /* 
            There were defects related to how the items were returned
            because of wrong signs in the for loop and if statement
            inside the Dequeue method
        */

        Console.WriteLine("---------");

    }
}