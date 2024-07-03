using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Turns on the canvas and zoom in the cinemachine
/// </summary>
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
