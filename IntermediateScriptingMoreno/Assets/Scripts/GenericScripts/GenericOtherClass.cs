using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericOtherClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass myClass = new SomeClass();

        //In order to use this method you must
        //tell the method what type to replace
        //'T' with.
    }
}
