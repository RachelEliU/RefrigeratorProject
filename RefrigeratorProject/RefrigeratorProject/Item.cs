using System;

namespace RefrigeratorProject
{
    internal partial class Program
    {
        public class Item
        {
            public int _id;
            private string _name;
            private Shelf _shelf;
            private string _type;
            private string _Kosher;
            private DateTime _expiryDate;
            private int _space;
            public Item(int id, string name,Shelf shelf, string type, string kosher, DateTime expiryDate, int space) 
            {
                setId();
                this._name=name; 
                this._shelf=shelf; 
                this._type=type;
                this._Kosher=kosher;
                this._expiryDate=expiryDate;
                this._space=space;
            }
            private void setId()
            {
                this._id = numberOfItems;
                numberOfItems++;
            }
           

        }
    }
}
