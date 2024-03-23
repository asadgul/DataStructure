// See https://aka.ms/new-console-template for more information
using CAlgoCodes.Binary_Trees;
using CAlgoCodes.DataStructure;
using CAlgoCodes.DataStructure.Queues;
using CAlgoCodes.DataStructure.StackData_Structure;
//Binary Tree
BinaryTree binaryTree = new BinaryTree();
//Nodes nodes = binaryTree.CreateTree(new int[] { 1, 2, 3, -1, -1, 5, 6, 7, 9, -1, -1, 10 });
Nodes nodes = binaryTree.CreateTree(new int[] { 1, 2, 4, -1, -1, 5, -1, -1, 3, -1,6, -1,-1 });
Console.WriteLine("Preorder");
binaryTree.Preorder(nodes);

Console.WriteLine("Inorder");
binaryTree.Inorder(nodes);
Console.WriteLine("Postorder");
binaryTree.Postorder(nodes);
Console.WriteLine("Total Nodes");
Console.WriteLine( binaryTree.CountofNode(nodes));


//Console.WriteLine(nodes.data);


//StackLinkList stackLinkList = new StackLinkList();
//stackLinkList.push(1);
//stackLinkList.push(2);
//stackLinkList.push(3);
//stackLinkList.push(4);

//StackLinkList.PushElementsAtBotton(5, stackLinkList);
//while (!stackLinkList.IsEmpty())
//{
//    Console.WriteLine(stackLinkList.Peek());
//    stackLinkList.Pop();
//}
//stackLinkList.push(1);
//stackLinkList.push(2);
//stackLinkList.push(3);
//stackLinkList.push(4);
////StackLinkList.PushElementsAtBotton(5, stackLinkList);
//StackLinkList.ReverseStack(stackLinkList);
//while (!stackLinkList.IsEmpty())
//{
//    Console.WriteLine(stackLinkList.Peek());
//    stackLinkList.Pop();
//}
//StackArrayList.StackArrayListImplementation();

//QueueArray queueArray = new QueueArray(4);
//queueArray.EnQueue(1);
//queueArray.EnQueue(2);
//queueArray.EnQueue(3);
//queueArray.EnQueue(4);

//while (!queueArray.IsEmpty())
//{
//    Console.WriteLine(queueArray.Peek());
//    queueArray.Pop();
//}

//Queue Linked List
QueueLinkedList queueLinkedList = new QueueLinkedList();
queueLinkedList.Enqueue(1);
queueLinkedList.Enqueue(2);
queueLinkedList.Enqueue(3);
queueLinkedList.Enqueue(4);

while (!queueLinkedList.IsEmpty())
{
    Console.WriteLine(queueLinkedList.Peek());
    queueLinkedList.Remove();
}
Console.ReadLine();
