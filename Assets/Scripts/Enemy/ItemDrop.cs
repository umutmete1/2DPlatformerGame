using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject pickupPrefab;

    private void OnDestroy()
    {
        if (pickupPrefab != null)
        {
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);
        }
    }
}
