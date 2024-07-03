using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : IteractableObject
{
    [Header("Iteractable Object Components References")]
    [SerializeField] Canvas ShopCanvas;

    public override void IteractionEffect()
    {
        ShopCanvas.enabled = true;
    }
}
