using FreshFruit.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFruit.Controller
{
    class BucketController
    {
        private Bucket bucket;
        private BucketEventListener eventListener;

        public BucketController(Bucket bucket, BucketEventListener eventListener)
        {
            this.bucket = bucket;
            this.eventListener = eventListener;
        }

        public void addFruit(Fruit fruit)
        {
            if (bucketIsoverload())
            {
                eventListener.onFailed("Oops, Keranjang Penuh");
            }
            else
            {
                this.bucket.insert(fruit);
                eventListener.OnSucceed("Yey, berhasil ditambahkan");
            }
        }

        public bool bucketIsoverload()
        {
            return bucket.countItems() >= bucket.getCapacity();
        }

        public void removeFruit(Fruit fruit)
        {
            for (int itemPosition = 0; itemPosition < bucket.countItems(); itemPosition++)
            {
                if (bucket.findAll().ElementAt(itemPosition).getName() == fruit.name)
                {
                    bucket.remove(itemPosition);
                    eventListener.OnSucceed("Yey, berhasil dihapus");
                }
            }
          }

        public List<Fruit> findAll()
        {
            return this.bucket.findAll();
        }

        }
    }
