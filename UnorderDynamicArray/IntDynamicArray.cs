using System;
using System.Text;

namespace DynamicArray{
    public abstract class IntDynamicArray{
        public int[] item;
        public int count;
        public const int SIZE = 5;
        private const int MULTIPLIER_FACTOR = 2;

        protected IntDynamicArray(){
            item = new int[SIZE];
            count = 0;
        }

        public abstract void Add(int data);
        public abstract bool Remove(int data);
        public abstract int IndexOf(int data);

        public override String ToString(){
            StringBuilder str = new StringBuilder();

            for(int i=0; i < count; i++){
                str.Append(item[i]);
                if(i < count - 1){
                    str.Append(",");
                }
            }

            return str.ToString();
        }

        public void Expand(){
            int[] newItem = new int[item.Length * MULTIPLIER_FACTOR];

            for(int i = 0; i < item.Length; i++){
                newItem[i] = item[i];
            }
            item = newItem;
        }

        protected void Clear(){
            count = 0;
        }
    }
}