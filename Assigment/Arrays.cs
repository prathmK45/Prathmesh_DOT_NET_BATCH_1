using System;
namespace Array{
    internal class Arrays{
        int[] arr;
        int index;
        public const int MAX_ITEM = 10;

        public Arrays(){
            arr = new int[MAX_ITEM];
        }

        public void add(int data){
            if(index == arr.Length)
                expand();
            arr[index++] = data;
        }
        public void delete(int data){
            int location = indexOf(data);
            if(location == -1)
                return;
            arr[location] = arr[index-1];
            index--;
        }
        public int indexOf(int data){
            for(int i=0;i<index;i++){
                if(arr[i] == data)
                    return i;
            }
            return -1;
        }
        public void print(){
            for(int i=0;i<index;i++){
                Console.Write("[ "+ arr[i] + " ] -> " );
            }
            Console.WriteLine();
        }
        private void expand(){
            int[] newItem = new int[item.Length * 2];

            for(int i=0;i<item.Length;i++){
                newItem[i] = item[i];
            }
            item = newItem;
        }
    }
}