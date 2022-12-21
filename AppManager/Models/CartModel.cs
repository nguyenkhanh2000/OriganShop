using System;

namespace AppManager.Models
{
    [Serializable]
    public class CartModel
    {
        public int ProductId { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        
    }
    
}
