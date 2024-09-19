using System;
namespace Products{
    public class DisplayPage<T> where T : IProduct , new(){
        T product;
        #region Constructor
        public DisplayPage(){
            product = new T();
            product.DisplayDinningTable();
        }
        #endregion
    }
}