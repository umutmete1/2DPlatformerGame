using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostPickup : Pickup
{
    public float boostAmount = 2f;

    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            var playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.BoostSpeed(boostAmount);
            base.DoOnPickup(collision);
        }
    }
}
