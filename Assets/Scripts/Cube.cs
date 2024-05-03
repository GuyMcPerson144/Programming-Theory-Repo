using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cube : Shape
{
    
    public override void UpdateMessage()
    {
        UpdateMessage("The default text has been overridden by the cube class.");
    }
}
