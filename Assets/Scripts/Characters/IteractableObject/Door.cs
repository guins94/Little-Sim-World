using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : IteractableObject
{
    [Header("Iteractable Object Components References")]
    [SerializeField] Collider2D DoorCollider2D;
    [SerializeField] SpriteRenderer DoorSpriteRenderer = null;
    [SerializeField] bool doorOpen = false;


    public override void IteractionEffect()
    {
        if (doorOpen)
        {
            DoorCollider2D.enabled = false;
            DoorSpriteRenderer.enabled = false;
        }
        else
        {
            DoorCollider2D.enabled = true;
            DoorSpriteRenderer.enabled = true;
        }
        doorOpen = !doorOpen;
    }
}
