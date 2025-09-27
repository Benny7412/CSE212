using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add 3 people with different priorities in the correct order, priorities unordered then dequeue in priority order.
    //REQUIREMENT 1, 2;
    // Expected Result: 
    // "[Tim (Pri:2), Bob (Pri:1), Sue (Pri:3)] 
    // Sue(3), Tim(2), Bob(1)

    // Defect(s) Found: Expected:<Sue>. Actual:<Tim>

    public void TestPriorityQueue_1()
    {

        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Bob", 1);
        priorityQueue.Enqueue("Sue", 3);

        Assert.AreEqual("[Tim (Pri:2), Bob (Pri:1), Sue (Pri:3)]", priorityQueue.ToString()); //Enqueue is adding data toe the back of the queue

        Assert.AreEqual("Sue", priorityQueue.Dequeue()); //Highest Priority
        Assert.AreEqual("Tim", priorityQueue.Dequeue()); //Middle Priority
        Assert.AreEqual("Bob", priorityQueue.Dequeue()); //Low Priority


    }

    [TestMethod]
    // Scenario: Add 3 people, 2 with the same priority, the one closer to the front of the queue should go first, then the one with an equal priority should go next.
    //REQUIREMENT 3;
    // Expected Result: Bob(3), Sue(3), Tim(2) 
    // Defect(s) Found: Expected:<Sue>. Actual:<Bob>.

    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Tim", 2);
        priorityQueue.Enqueue("Bob", 3);
        priorityQueue.Enqueue("Sue", 3);

        Assert.AreEqual("Bob", priorityQueue.Dequeue()); //Highest Priority
        Assert.AreEqual("Sue", priorityQueue.Dequeue()); //Middle Priority
        Assert.AreEqual("Tim", priorityQueue.Dequeue()); //Low Priority
    }



    // Add more test cases as needed below.


    [TestMethod]
    // Scenario: Add 3 people, 2 with the same priority, the one closer to the front of the queue should go first, then the one with an equal priority should go next.
    //REQUIREMENT 4;
    // Expected Result: InvalidOperationException error message
    // Defect(s) Found: None

    public void TestPriorityQueue_3()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
        }
        catch (InvalidOperationException error)
        {
            Assert.AreEqual("The queue is empty.", error.Message); ;
        }
    }
    
}