using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager GameManagerInstance { get; protected set; } = null;
    public static PlayerController PlayerInstance { get; protected set; } = null;

    public int gold { get; protected set; } = 5;

    void Awake()
    {
        GameManagerInstance = this;
        PlayerInstance = FindObjectOfType<PlayerController>();
    }

    public void AddCoins(int coins)
    {
        gold += PlayerInstance.coinsColleted;
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

    public void QuitGame()
    {
        Application.Quit();
    }
}
