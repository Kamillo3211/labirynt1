using System.Collections;
using System.Collections.Generic;
using UnityEngine;



    public enum KeyColor
    {
        Red,
        Green,
        Gold
    }

public class Key : Pickup
{
    public KeyColor color;

    public override void Picked()
    {
        GameManager.gameManager.AddKey(color);
        Destroy(this.gameObject);
    }
    public void FixedUpdate()
    {
        Rotation();
    }
}
