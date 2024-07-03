using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomization : IteractableObject
{
    [Header("Iteractable Object Components References")]
    [SerializeField] Canvas CharacterCustomizationCanvas;

    public override void IteractionEffect()
    {
        CharacterCustomizationCanvas.enabled = true;
        GameManager.CinemachineControllerInstance.ZoomCamera();
    }
}
