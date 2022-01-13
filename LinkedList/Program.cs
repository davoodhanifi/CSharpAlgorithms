using LinkedList;

SinglyLinkedList singlyLinkedList = new();
singlyLinkedList.InsertFist(1);
singlyLinkedList.InsertLast(2);
singlyLinkedList.InsertLast(3);
singlyLinkedList.InsertLast(4);
Console.WriteLine("First List:");
singlyLinkedList.DisplayList();
singlyLinkedList.InsertFist(0);
Console.WriteLine("Second List:");
singlyLinkedList.DisplayList();
