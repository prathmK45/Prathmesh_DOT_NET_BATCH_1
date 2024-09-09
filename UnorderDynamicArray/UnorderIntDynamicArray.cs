using System;

namespace DynamicArray{
    public class UnorderIntDynamicArray : IntDynamicArray{

        public UnorderIntDynamicArray() : base (){}

        public override void Add(int data){
            if(count == item.Length){
                Expand();
            }
            item[count] = data;
            count++;
        }
        public override bool Remove(int data){
            int position = IndexOf(data);

            if(position == -1){
                return false;
            }
            item[position] = item[count-1];
            count--;
            return true;
        }
        public override int IndexOf(int data){
            for(int i=0; i < count; i++){
                if(item[i] == data){
                    return i;
                }
            }
            return -1;
        }
    }
}
