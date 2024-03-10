using System;
namespace CSharp
{
    // Class Node đại diện cho mỗi nút trong danh sách liên kết
    public class Node 
    {
        public int data;
        public Node next;
        // Constructor
        public Node (int data)
        {
            this.data = data;
            next = null;
        }
    } 
    // Class LinkedList chứa các method để thao tác với danh sách liên kết
    public class LinkedList
    {
        public Node head; // Node đầu tiên trong Linked list 
        // Phương thức AddNode để thêm một nút vào đầu Linked list 
        public void AddNode(int new_data)
        {
            // Tạo 1 node mới
            Node new_node = new Node(new_data);
            // Gán node tiếp theo của Linked list thành node hiện tại của head 
            new_node.next = head;
            // Đặt head trỏ đến Node mới
            head = new_node;
        }
        public void PrintList()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
    }
    class Program
    {   
        public static void Main(string[] args)
        {
            LinkedList linkedList = new LinkedList();
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            linkedList.AddNode(4);
            linkedList.AddNode(5);
            linkedList.AddNode(6);
            linkedList.AddNode(7);
            linkedList.AddNode(8);
            linkedList.AddNode(9);
            linkedList.AddNode(10);
            linkedList.PrintList();
        }
    }
}



