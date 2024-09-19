using System;
namespace Products{
    public abstract class CProduct : IProduct{
        #region Data Members
        protected String brand;
        protected String type;
        protected int id;
        #endregion
    
        #region Constructor
        protected CProduct(){
            
        }
        #endregion


        #region Abstract Methods
        public abstract void DisplayDinningTable();
        #endregion
    }
}