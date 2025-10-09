using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crystal : Pickup
{
    public int Points = 5;
    // Update is called once per frame

    public override void Picked()
    {
        GameManager.gameManager.AddPoints(Points);
        Destroy(this.gameObject);
    }
    void Update()
    {
        Rotation();
    }
}
