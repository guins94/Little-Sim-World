using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The player is controlled by input and can interect with the world
/// </summary>
public class PlayerController : MonoBehaviour
{
    [Header("Player Components References")]
    [SerializeField] Rigidbody2D playerRigidbody;
    [SerializeField] Animator playerAnimator;

    [Header("Player Configuration")]
    [SerializeField] float moveSpeed;
    [SerializeField] bool canInteract = false;

    // Cached Components
    public Action IteractWithObject = null;
    private Vector2 playerInput = Vector2.zero; 
    public int coinsColleted = 0;
    
    /// <summary>
    /// Starts to hear for coins gained
    /// </summary>
    void Start()
    {
        ActionGroup.OnGameStart += OnGameStart;
    }

    public void OnGameStart()
    {
        
    }

    void Delete()
    {
        ActionGroup.OnGameStart -= OnGameStart;
    }

    /// <summary>
    /// Get the inputs and update the animator of the player
    /// </summary>
    void Update()
    {
        
        playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")).normalized;
        playerAnimator.SetFloat("Speed", playerInput.magnitude);

        if (Input.GetKeyDown(KeyCode.E) && canInteract)
        {
            HandleInteract();
        }
    
    }

    /// <summary>
    /// Handles map interactions with the player
    /// </summary>
    void HandleInteract()
    {
        IteractWithObject?.Invoke();
    }

    /// <summary>
    /// Actually moves the player setting it's speed
    /// </summary>
    void FixedUpdate()
    {
        Vector2 moveForce = playerInput * moveSpeed;
        playerRigidbody.velocity = moveForce;

        HandlesLookDirection();
    }

    /// <summary>
    /// Makes the player look in the necessary Direction where he is going
    /// </summary>
    void HandlesLookDirection()
    {
        if (playerRigidbody.velocity.x >= 0.01)
        {
            if (this.gameObject.transform.localScale.x < 0)
            {
                FlipCharacter();
            }
        }

        if (playerRigidbody.velocity.x <= -0.01)
        {
            if (this.gameObject.transform.localScale.x > 0)
            {
                FlipCharacter();
            }
        }

    }

    void FlipCharacter()
    {
        this.gameObject.transform.localScale = new Vector3(-this.gameObject.transform.localScale.x, this.gameObject.transform.localScale.y, this.gameObject.transform.localScale.z);
    } 
}
