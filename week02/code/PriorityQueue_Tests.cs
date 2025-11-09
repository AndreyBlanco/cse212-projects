using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Create a queue with the following people and priority: Tim (2), Sue (3), Bob (1), Sam (2), Joe (3)
    // Run 5 times.
    // Expected Result: Sue, Joe, Tim, Sam, Bob
    // Defect(s) Found: 
    // - Dequeue did not remove the item.
    // - Dequeue did not evaluate the last item.
    public void TestPriorityQueue_1()
    {
        var tim = (name: "Tim", priority: 2);
        var sue = (name: "Sue", priority: 3);
        var bob = (name: "Bob", priority: 1);
        var sam = (name: "Sam", priority: 2);
        var joe = (name: "Joe", priority: 3);

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(tim.name, tim.priority);
        priorityQueue.Enqueue(sue.name, sue.priority);
        priorityQueue.Enqueue(bob.name, bob.priority);
        priorityQueue.Enqueue(sam.name, sam.priority);
        priorityQueue.Enqueue(joe.name, joe.priority);

        List<string> expectedResult = new List<string>() {"Sue", "Joe", "Tim", "Sam", "Bob" };

        for (int i = 0; i < 5; i++)
        {
            var person = priorityQueue.Dequeue();
            Assert.AreEqual(expectedResult[i], person);
        }

    }

    [TestMethod]
    // Scenario: Create a empty queue and try dequeue items from it.
    // Expected Result: "The queue is empty."
    // Defect(s) Found:
    // - Dequeue did not sent a message when the queue was empty.
    public void TestPriorityQueue_2()
    {
        var emptyMessage = "The queue is empty.";

        var priorityQueue = new PriorityQueue();
        var message = priorityQueue.Dequeue();
        Assert.AreEqual(emptyMessage, message);
    }

    // Add more test cases as needed below.
}