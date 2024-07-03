using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

/// <summary>
/// Handles the coin UI max amount and current amount
/// </summary>
public class CoinUIUpdate : MonoBehaviour
{
    [Header("Coin UI Components")]
    [SerializeField] TextMeshProUGUI coinCurrentText = null;

    /// <summary>
    /// At the start listens for coin update
    /// </summary>
    void Start()
    {
        if (coinCurrentText != null) coinCurrentText.text = GameManager.GameManagerInstance.gold.ToString();

        ActionGroup.CoinCollected += CoinTextUpdate;
    }

    private void CoinTextUpdate(int coins)
    {
        StartCoroutine(UpdateUI());
        
        IEnumerator UpdateUI()
        {
            yield return new WaitForSeconds(.1f);
            if (coinCurrentText != null) coinCurrentText.text = coins.ToString();
        }
    }
}
