using EnumCollections.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumCollections
{
    public class Bullet
    {
        public int Id { get; set; }
        public BulletType Type { get; set; }

        public Bullet(int id, BulletType type)
        {
            Id = id;
            Type = type;
        }
    }
}
