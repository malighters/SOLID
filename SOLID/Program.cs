namespace SOLID
{
    // порушено принцип єдиного обов'язку 
    class Item
    {

    }

    interface IOrder
    {
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }

    interface IShow
    {
        
        public void ShowOrder() {/*...*/}
    }

    interface IPrint
    {
        public void PrintOrder() {/*...*/}
    }

    interface ICrud
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }
    
    class Order: IOrder
    {
        private List<Item> itemList;
        internal List<Item> ItemList
        {
            get
            {
                return itemList;
            }

            set
            {
                itemList = value;
            }
        }

        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(Item item) {/*...*/}
        public void DeleteItem(Item item) {/*...*/}
    }


    class Crud : ICrud
    {
        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}   
    }

    class Show : IShow
    {
        public void ShowOrder() {/*...*/}
    }

    class Print : IPrint
    {
        public void PrintOrder() {/*...*/}
    }
    
}