using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostPickup : Pickup
{
    public float boostAmount = 1.25f;

    public override void DoOnPickup(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            var playerController = collision.gameObject.GetComponent<PlayerController>();
            playerController.BoostJump(boostAmount);
            base.DoOnPickup(collision);
        }
    }
}
