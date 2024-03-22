// See https://aka.ms/new-console-template for more information
using CAlgoCodes.DataStructure;
using CAlgoCodes.DataStructure.StackData_Structure;
StackLinkList stackLinkList = new StackLinkList();
stackLinkList.push(1);
stackLinkList.push(2);
stackLinkList.push(3);
stackLinkList.push(4);

StackLinkList.PushElementsAtBotton(5, stackLinkList);
while (!stackLinkList.IsEmpty())
{
    Console.WriteLine(stackLinkList.Peek());
    stackLinkList.Pop();
}
stackLinkList.push(1);
stackLinkList.push(2);
stackLinkList.push(3);
stackLinkList.push(4);
//StackLinkList.PushElementsAtBotton(5, stackLinkList);
StackLinkList.ReverseStack(stackLinkList);
while (!stackLinkList.IsEmpty())
{
    Console.WriteLine(stackLinkList.Peek());
    stackLinkList.Pop();
}
StackArrayList.StackArrayListImplementation();


Console.ReadLine();
