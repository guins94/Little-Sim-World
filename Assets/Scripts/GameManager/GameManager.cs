using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Game Manager Controls Many Functions of the game
/// Gets the References of singleton objects
/// </summary>
public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance { get; protected set; } = null;
    public static PlayerController PlayerInstance { get; protected set; } = null;
     public static CinemachineController CinemachineControllerInstance { get; protected set; } = null;
    public int gold { get; protected set; } = 100;

    /// <summary>
    /// Sets the references to singletons
    /// </summary>
    void Awake()
    {
        GameManagerInstance = this;
        PlayerInstance = FindObjectOfType<PlayerController>();
        CinemachineControllerInstance = FindObjectOfType<CinemachineController>();
    }

    /// <summary>
    /// Coin Related Functions
    /// </summary>
    public void AddCoins(int coins)
    {
        gold += coins;
        ActionGroup.CoinCollected?.Invoke(gold);
    }

    public void RemoveCoins(int coins)
    {
        if (gold - coins >= 0)
        {
            gold -= coins;
        }
        ActionGroup.CoinCollected?.Invoke(gold);
    }

    /// <summary>
    /// Quits the game, used on menu
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
