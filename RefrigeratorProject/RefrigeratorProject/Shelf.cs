
using System.Collections.Generic;
using System.Security.Policy;

namespace RefrigeratorProject
{
    internal partial class Program
    {
        public class Shelf
        {
            private int _id;
            private int _floor;
            private int _spaceInShelf;
            private List<Item> _itemsInShelf;
            public Shelf(int floor, int space) 
            { 
               this._floor = floor;
                this._spaceInShelf = space;
                this._itemsInShelf = new List<Item>();
            }
            public Shelf(int floor, int space, List<Item> items) 
            {
                this._floor = floor;
                this._spaceInShelf = space;
                this._itemsInShelf = new List<Item>();
                AddItem(items);
            }
            private void SetId()
            {
                this._id = numberOfShelfs;
                numberOfShelfs++;
                //this.idShelf = numberOfShelfs++;


            }
            public void AddItem(List<Item> items )
            {
                foreach ( var item in items ) 
                {
                    _itemsInShelf.Add(item);
                }
            }
            
              
        }
       
    }
}
