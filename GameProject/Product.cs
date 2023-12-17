using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    internal class Product
    {
        public int Id { get; set; }
        public required string GameName { get; set; }
        public required string GameType { get; set; }
        public int GamePrice {  get; set; }
    }
}
