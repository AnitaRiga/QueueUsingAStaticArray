using System.Collections;

// Creates and initializes a new Queue. Queue Class represents a first-in, first-out collection of objects.
int myQSize = 7;

Queue<string> myQ = new Queue<string>(myQSize);
myQ.Enqueue("Bonn");
myQ.Enqueue("Riga");
myQ.Enqueue("Paris");
myQ.Enqueue("Roma");
myQ.Enqueue("Wien");

// Counts the elements of the Queue.
Console.WriteLine("There are {0} elements in my queue:", myQ.Count);

// Prints the elements of the Queue.
DisplayElements(myQ);

/* Adds elements to the Queue checking whether the Queue is full.
If the Queue is full, the first element is removed, the new one is added.*/
AddANewElement(myQ, myQSize, "London");
AddANewElement(myQ, myQSize, "Madrid");
AddANewElement(myQ, myQSize, "Salzburg");
AddANewElement(myQ, myQSize, "Lisbon");

// Checks whether the Queue is empty.
WhetherQueueIsEmpty(myQ.Count);

// Clears the Queue. Removes all elements the Queue has.
myQ.Clear();
Console.WriteLine("After Clear there is {0} elements in my Queue.", myQ.Count);

WhetherQueueIsEmpty(myQ.Count);

// We can add new elements.
AddANewElement(myQ, myQSize, "Amsterdam");
AddANewElement(myQ, myQSize, "Barcelona");
AddANewElement(myQ, myQSize, "Prague");
AddANewElement(myQ, myQSize, "Bruges");
AddANewElement(myQ, myQSize, "Zurich");

static void DisplayElements(IEnumerable myCollection)
{
    foreach (Object obj in myCollection)
    {
        Console.Write(obj + " / ");
    }
    Console.WriteLine("\r\n");
}

static void AddANewElement(Queue<string> myCollection, int size, string element)
{
    if (size > myCollection.Count)
    {
        myCollection.Enqueue(element);
        Console.WriteLine("'{0}' is added.", element);
        DisplayElements(myCollection);
    }
    else
    {
        string peekElement = myCollection.Peek();
        myCollection.Dequeue();
        myCollection.Enqueue(element);
        Console.WriteLine("The Queue is full. '{0}' is removed. '{1}' is added.", peekElement, element);
        DisplayElements(myCollection);
    }
}

static void WhetherQueueIsEmpty(int count)
{
    if (count != 0)
    {
        Console.WriteLine("My Queue is not empty. There are {0} elements in it." + "\r\n", count);
    }
    else
    {
        Console.WriteLine("My queue is empty." + "\r\n");
    }
}