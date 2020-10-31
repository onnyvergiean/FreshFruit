using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreshFruit.Model
{

    interface BucketEventListener
    {
        void OnSucceed(string message);
        void onFailed(string message);
    }
}

