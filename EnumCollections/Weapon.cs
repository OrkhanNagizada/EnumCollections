using EnumCollections.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumCollections
{
    public class Weapon
    {
        private Queue<Bullet> bullets;
        private BulletType bulletType;

        public int Id { get; set; }

        public Weapon(BulletType bulletType, int maxBullets)
        {
            this.bulletType = bulletType;
            bullets = new Queue<Bullet>(maxBullets);
        }


        public void Fill(int numBullets)
        {
            for (int i = 0; i < numBullets; i++)
            {
                bullets.Enqueue(new Bullet(bullets.Count + 1, bulletType));
            }
            Console.WriteLine($"{numBullets} {bulletType.ToString()} silaha doldurulmush gullə {Id}.");
        }

        public void Fire()
        {
            if (bullets.Count > 0)
            {
                Bullet nextBullet = bullets.Dequeue();
                Console.WriteLine($"Fire {nextBullet.Type.ToString()} silahda olan güllə {Id}. Qalan güllə: {bullets.Count}");
            }
            else
            {
                Console.WriteLine("Vurmag ucun gulle qalmadi.");
            }
        }

        public void PullTrigger()
        {
            if (bullets.Count > 0)
            {
                Console.WriteLine($"Silahdan atəsh acmaq uçun novbeti gullə tipi {Id}: {bullets.Peek().Type.ToString()}");
            }
            else
            {
                Console.WriteLine("Vurmag ucun gulle qalmad");
            }
        }
    }
}
