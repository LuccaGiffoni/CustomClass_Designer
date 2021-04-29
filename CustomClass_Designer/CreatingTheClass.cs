using System;

namespace MyCustomClass
{

    public class MyCart
    {

        #region Fields
        // Creating the fields this class gonna have -- in this case, my products and it's respective price

        // Laptops
        private int laptopsCount;
        public int laptopPrice = 1299;

        // Phones
        private int phonesCount;
        public int phonePrice = 899;

        // Mouses
        private int mousesCount;
        public int mousePrice = 49;

        private int totalAmount;

        #endregion

        #region Properties
        // Creating only-read properties to use along the program

        public int Laptop
        {
            get { return laptopsCount; return laptopPrice; }
        }

        public int Phone
        {
            get { return phonesCount; return phonePrice; }
        }

        public int Mouse
        {
            get { return mousesCount; return mousePrice; }
        }

        public int Amount
        { 
            get { return totalAmount;  }
        }


        #endregion

        #region Constructors

        public MyCart(int laptopQuantity, int phoneQuantity, int mouseQuantity)
        {
            laptopsCount = laptopQuantity;
            phonesCount = phoneQuantity;
            mousesCount = mouseQuantity;
        }

        #endregion

        #region Methods

        public void CheckOut()
        {
            totalAmount = (laptopsCount * laptopPrice) + (phonesCount * phonePrice) + (mousesCount * mousePrice);
        }

        #endregion
    }

}
