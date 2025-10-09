using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : Pickup
{
    public bool AddTime;
    public uint time = 5;

    public override void Picked()
    {
        int sign = AddTime ? 1 : -1;
        GameManager.gameManager.AddTime((int)time * sign);
        Destroy(this.gameObject);
    }
    private void FixedUpdate()
    {
        Rotation();
    }
}
