using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DiceGame : MonoBehaviour
{
    [Header("Dice Game Components")]
    [SerializeField] TextMeshProUGUI FirstDiceText = null;
    [SerializeField] TextMeshProUGUI SecondDiceText = null;
    [SerializeField] Button BetButton = null;

    // Start is called before the first frame update
    void Start()
    {
        BetButton.onClick.AddListener(BetButtonPressed);
    }

    private void BetButtonPressed()
    {
        GameManager.GameManagerInstance.RemoveCoins(1);
        Debug.Log("You paid " + 1 + " coin");

        int a = Random.Range(1, 7);
        int b = Random.Range(1, 7);
        FirstDiceText.text = a.ToString();
        SecondDiceText.text = b.ToString();

        if (a == b)
        {
            int winnedAmount = 0;
            if (a == 6)
            {
                winnedAmount = 100;
            }
            else
            {
                winnedAmount = a*2;
            }
            GameManager.GameManagerInstance.AddCoins(winnedAmount);
            Debug.Log("You Won " + winnedAmount + " coins");
        }
    }
}
