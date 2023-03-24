using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace WebApplication1.Data.Models
{
    public class Car
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longdesc { set; get; }

        public string img { set; get; }

        public ushort price { set; get; }

        public bool isFavourite { set; get; }

        public bool available { set; get; }

        public int categoryID { set; get; }

        public virtual Category Category { set; get; }


    }
}
