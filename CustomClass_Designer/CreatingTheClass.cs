namespace MyCustomClass
{

    public class MyCart
    {

        #region Fields
        // Creating the fields this class gonna have -- in this case, my products and it's respective price
        // You can create infinte fields if you want, just remember to crate the Properties for each new field

        // Laptops
        private int laptopsCount;
        public int laptopPrice = 1299;

        // Phones
        private int phonesCount;
        public int phonePrice = 899;

        // Mouses
        private int mousesCount;
        public int mousePrice = 49;

        // Amount of money -- will be used on the CheckOut method
        private int totalAmount;

        #endregion

        #region Properties
        // Creating only-read properties to display info when needed
        // This properties will be used to allocate custom data from the user without the need to be allocated before.
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
            get { return totalAmount; }
        }


        #endregion

        #region Constructor
        // This constructor is crucial to the program work, it'll deploy a new 'cart' for your user, totally empty and ready to use.
        // Think this as the literal shopping cart you get every time you go buy something on the market.
        public MyCart(int laptopQuantity, int phoneQuantity, int mouseQuantity)
        {
            laptopsCount = laptopQuantity;
            phonesCount = phoneQuantity;
            mousesCount = mouseQuantity;
        }

        #endregion

        #region Methods
        // This is the only method I choose to use, you can create many more if you wanna.
        // This method makes the automatic check-out process. You just need to call it -- as done on the 'UsingTheClass' file.
        public void CheckOut()
        {
            totalAmount = (laptopsCount * laptopPrice) + (phonesCount * phonePrice) + (mousesCount * mousePrice);
        }

        #endregion
    }

}
