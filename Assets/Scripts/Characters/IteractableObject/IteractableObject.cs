using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Iteractable Objects can be acessed using "E" button
/// </summary>
[RequireComponent(typeof(Collider2D))]
public abstract class IteractableObject : MonoBehaviour
{
    [Header("Iteractable Object Components References")]
    [SerializeField] Collider2D iteractableAreaCollider2D;
    [SerializeField] SpriteRenderer ChatBoxSpriteRenderer;

    // Cached Components
    public bool canInteract = false;

    public void Start()
    {
        GameManager.PlayerInstance.IteractWithObject += IteractionHandler;
    }

    /// <summary>
    /// Waits for the player to press a button
    /// </summary>
    public void IteractionHandler()
    {
        if (canInteract) IteractionEffect();
    }

    public abstract void IteractionEffect();

    /// <summary>
    /// On Trigger Function makes the Chat Box appear
    /// </summary>
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            EnableIteractionChatBoxHandler();
            canInteract = true;
        } 
    }

    /// <summary>
    /// On Trigger Function makes the Chat Box dissaper
    /// </summary>
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            DisableIteractionChatBoxHandler();
            canInteract = false;
        } 
    }

    private void EnableIteractionChatBoxHandler()
    {
        ChatBoxSpriteRenderer.enabled = true;
    }

    private void DisableIteractionChatBoxHandler()
    {
        ChatBoxSpriteRenderer.enabled = false;
    }
}
