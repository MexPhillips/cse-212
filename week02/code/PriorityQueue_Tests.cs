using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue values with different priorities and dequeue them until the queue is empty.
    // Expected Result: Values are returned from highest priority to lowest priority, and each item is removed.
    // Defect(s) Found: The implementation did not remove dequeued items and could miss the final item while finding the highest priority.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("low", 1);
        priorityQueue.Enqueue("high", 3);
        priorityQueue.Enqueue("middle", 2);

        Assert.AreEqual("high", priorityQueue.Dequeue());
        Assert.AreEqual("middle", priorityQueue.Dequeue());
        Assert.AreEqual("low", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Enqueue multiple values with the same highest priority, then dequeue them.
    // Expected Result: Tied values are returned in FIFO order, followed by lower-priority values.
    // Defect(s) Found: The implementation selected the last tied value instead of preserving FIFO order.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 5);
        priorityQueue.Enqueue("second", 5);
        priorityQueue.Enqueue("lower", 1);

        Assert.AreEqual("first", priorityQueue.Dequeue());
        Assert.AreEqual("second", priorityQueue.Dequeue());
        Assert.AreEqual("lower", priorityQueue.Dequeue());
    }

    [TestMethod]
    // Scenario: Dequeue from an empty priority queue.
    // Expected Result: An InvalidOperationException is thrown with the message "The queue is empty.".
    // Defect(s) Found: None. This requirement was already implemented correctly.
    public void TestPriorityQueue_Empty()
    {
        var priorityQueue = new PriorityQueue();

        var exception = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());

        Assert.AreEqual("The queue is empty.", exception.Message);
    }
}