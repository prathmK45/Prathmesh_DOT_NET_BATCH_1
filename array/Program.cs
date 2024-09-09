using System;
using Array;    // Name of namespace.

class ArrayExample{
    public static void Main(){
        Arrays arr = new Arrays();

        for(int i=0;i < Arrays.MAX_ITEM;i++){
        // we cant access const variable using object so we use direct name of class (MAX_ITEM)
            arr.add(i);                         
        }
        arr.print();
        arr.delete(5);
        arr.print();
        arr.delete(2);
        arr.print();
    }
}

