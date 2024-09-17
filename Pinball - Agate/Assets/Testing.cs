using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shape1;

namespace Example { 
    public class Testing : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            Shape shape = new Shape();

            shape.Display();
        }
    }

}
