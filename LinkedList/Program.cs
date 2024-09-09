using System;
using LinkedList;

public class List{
    public static void Main(string[] args){
        DoublyCircularLinkedList dcll = new DoublyCircularLinkedList();

        dcll.InsertAtBegin(10);
        dcll.InsertAtEnd(20);
        dcll.InsertAtEnd(30);
        dcll.PrintList(); // 10 20 30 

        dcll.InsertAtPosition(40,3);
        dcll.InsertAtPosition(50,5);
        dcll.PrintList(); // 10 20 40 30 50

        Console.WriteLine(dcll.DeleteBegin()); // 10 
        Console.WriteLine(dcll.DeleteEnd());  // 50
        dcll.PrintList(); // 20 40 30

        Console.WriteLine(dcll.DeleteAtPosition(4)); // -1
        Console.WriteLine(dcll.DeleteAtPosition(2)); // 40
        dcll.PrintList(); // 20 30
        Console.WriteLine(dcll.Length()); // 2

        dcll.InsertAfter(50,30);
        dcll.InsertAfter(40,30);
        dcll.PrintList(); // 20 30 40 50

        Console.WriteLine(dcll.DeleteData(40)); // 40
        Console.WriteLine(dcll.Length()); // 3
        Console.WriteLine(dcll.FindData(40)); // false
    }
}