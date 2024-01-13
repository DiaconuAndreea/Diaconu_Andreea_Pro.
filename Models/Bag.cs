using Diaconu_Andreea_Pro_.Migrations;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Security.Cryptography;
using System.Security.Policy;

namespace Diaconu_Andreea_Pro_.Models
{
    public class Bag
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
       
    }
}
