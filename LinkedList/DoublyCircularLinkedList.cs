using System;

namespace LinkedList{
    public class DoublyCircularLinkedList{
        private Node headNode;

        public DoublyCircularLinkedList(){
            headNode = new Node();
            headNode.Next = headNode;
            headNode.Prev = headNode;
        }

        public bool InsertAtBegin(int data){
            Node newNode = new Node(data);

            GenericInsert(headNode, newNode, headNode.Next);
            return true;
        }
        public bool InsertAtEnd(int data){
            Node newNode = new Node(data);

            return GenericInsert(headNode.Prev, newNode, headNode);
        }
        public bool InsertAtPosition(int data, int pos){
            if(pos <= 0)
                return false;
            Node newNode = new Node(data);
            
            Node temp = headNode.Next;
            int count = 1;
            while(count < pos && temp != headNode){
                temp = temp.Next;
                count++;
            }
            if(count != pos)
                return false;
            
            return GenericInsert(temp.Prev, newNode, temp);
        }
        public bool InsertAfter(int data, int dataAfter){
            Node temp = headNode.Next;

            while(temp.Data != dataAfter && temp != headNode)
                temp = temp.Next;

            if(temp == headNode)
                return false;

            Node newNode = new Node(data);
            return GenericInsert(temp, newNode, temp.Next);
        }

        public int DeleteBegin(){
            if(headNode.Next == headNode)
                return -1;
            
            return GenericDelete(headNode.Next);
        }
        public int DeleteEnd(){
            if(headNode.Prev == headNode)
                return -1;

            return GenericDelete(headNode.Prev);
        }
        public int DeleteAtPosition(int pos){
            if(headNode.Next == headNode)
                return -1;
            
            Node temp = headNode.Next;
            int count = 1;

            while(count < pos && temp != headNode){
                temp = temp.Next;
                count++;
            }
            if(count != pos || temp == headNode)
                return -1;

            return GenericDelete(temp);
        }
        public int DeleteData(int data){
            if(headNode.Next == headNode)
                return -1;

            Node temp = headNode.Next;
            while(temp.Data != data && temp != headNode)
                temp = temp.Next;
            
            if(temp == headNode)
                return -1;
            
            return GenericDelete(temp);

        }
        public int Length(){
            if(headNode.Next == headNode)
                return 0;

            Node temp = headNode.Next;
            int length = 0;
            while(temp != headNode){
                temp = temp.Next;
                length++;
            }
            
            return length;
        }
        public bool FindData(int data){
            if(headNode.Next == headNode)
                return false;

            Node temp = headNode.Next;
            while(temp != headNode){
                if(temp.Data == data)
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        private bool GenericInsert(Node start, Node mid, Node end){
            start.Next = mid;
            mid.Next = end;
            end.Prev = mid;
            mid.Prev = start;

            return true;
        }
        private int GenericDelete(Node deleteNode){
            deleteNode.Prev.Next = deleteNode.Next;
            deleteNode.Next.Prev = deleteNode.Prev;

            return deleteNode.Data;
        }

        public void PrintList(){
            if(headNode.Next == headNode)
                return;

            Node temp = headNode.Next;
            while(temp != headNode){
                Console.Write("[" + temp.Data + "]->");
                temp = temp.Next;
            }
            Console.WriteLine("[END]");
        }
    }
    
}