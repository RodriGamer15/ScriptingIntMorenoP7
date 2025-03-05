using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple1 : Fruit
{
    public Apple1()
    {
        Debug.Log("1st Apple Constructor Called");
    }

    public virtual void Chop()
    {
        Debug.Log("The apple has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am a apple.");
    }
}
