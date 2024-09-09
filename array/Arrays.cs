using System;
namespace Array{
    internal class DynamicArray{
        int[] item;
        int index;
        public const int SIZE = 10;
        private int const MULTIPLIER = 2;

        public DynamicArray(){
            item = new item[SIZE];
            index = 0;
        }

        public void Add(int item){
            if(index == Size){
                Expand();
            }
            this.item[index] = item;
            index++;
        }
        public bool Remove(int item){
            int position = IndexOf();

            if(position == -1){
                return false;
            }

            this.item[position] = this.item[index-1];
            index--;
            return true;
        }
        private int IndexOf(int item){
            for(int i=0; i<index; i++){
                if(this.item[i] == item){
                    return i;
                }
            }
            return -1;
        }
        public void Print(){
            for(int i=0; i < index; i++){
                cout<<item[i]<<" ";
            }
            cout<<endl;
        }
        private void Expand(){
            int[] newItem = new int[item.Length * MULTIPLIER];

            for(int i=0; i < item.Length; i++){
                newItem[i] = item[i];
            }
            item = newItem;
        }
    }
}