using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape 
{
    public override void UpdateMessage()
    {
        UpdateMessage("This sphere has been clicked "+clickCount+" times. The click count was encapsulated in the shape class and accessed with a property by the sphere class.");
    }
}
