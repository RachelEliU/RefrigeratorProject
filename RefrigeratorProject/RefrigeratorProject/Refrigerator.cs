using System.Collections.Generic;
using System.Globalization;
using System.Security.Policy;
using static RefrigeratorProject.Program;

namespace RefrigeratorProject
{
    public class Refrigerator
    {
        private int id { get; set; }
        private string model { get; set; }
        private string color;
        private int numberOfShelfs;
        private List<Shelf> _shelfs;
        public Refrigerator( string modelRefrigerator, string colorRefrigerator, int shelfNumber)
        {
            SetId();
            this.model = modelRefrigerator;
            this.color = colorRefrigerator;
            this.numberOfShelfs = shelfNumber;
            this._shelfs = new List<Shelf>(shelfNumber);
        }
        
        private void SetId()
        {
            this.id = numberOfItems;
            numberOfItems++;
        }
       
    }
}
