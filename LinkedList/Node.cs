namespace LinkedList{
    internal class Node{
        private int data;
        private Node next;
        private Node prev;

        internal Node(){
            data = -1;
            next = null;
            prev = null;
        }
        internal Node(int data){
            this.data = data;
            next = null;
            prev = null;
        }

        internal int Data{
            get {return data;}
            set {data = value;}
        }
        internal Node Next{
            get {return next;}
            set {next = value;}
        }
        internal Node Prev{
            get {return prev;}
            set {prev = value;}
        }
    }
}