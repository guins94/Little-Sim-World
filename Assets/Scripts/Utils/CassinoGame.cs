using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    [Header("Dice Game Components")]
    [SerializeField] TextMeshProUGUI FirstDiceText = null;
    [SerializeField] TextMeshProUGUI CodeDiceText = null;
    [SerializeField] TMP_InputField DiceBetAmount = null;

    [Header("Dice Game Components")]
    [SerializeField] Button Button0 = null;
    [SerializeField] Button Button1 = null;
    [SerializeField] Button Button2 = null;
    [SerializeField] Button Button3 = null;
    [SerializeField] Button Button4 = null;
    [SerializeField] Button Button5 = null;
    [SerializeField] Button Button6 = null;
    [SerializeField] Button Button7 = null;
    [SerializeField] Button Button8 = null;
    [SerializeField] Button Button9 = null;
    //[SerializeField] Button BetButton = null;

    [Header("Dice Game Components")]
    [SerializeField] TextMeshProUGUI[] FirstRow  = null;
    [SerializeField] TextMeshProUGUI[] SecondRow  = null;
    [SerializeField] TextMeshProUGUI[] ThirdRow  = null;
    [SerializeField] TextMeshProUGUI[] LastRow  = null;
    
    //Cached Components
    int[] cypher = new int[] {0, 0, 0};

    int[] code = new int[] {0, 0, 0};

    int row = 1;
    int count = 0;


    // Start is called before the first frame update
    void Start()
    {
        //BetButton.onClick.AddListener(BetButtonPressed);
        Button0.onClick.AddListener(Button0Pressed);
        Button1.onClick.AddListener(Button1Pressed);
        Button2.onClick.AddListener(Button2Pressed);
        Button3.onClick.AddListener(Button3Pressed);
        Button4.onClick.AddListener(Button4Pressed);
        Button5.onClick.AddListener(Button5Pressed);
        Button6.onClick.AddListener(Button6Pressed);
        Button7.onClick.AddListener(Button7Pressed);
        Button8.onClick.AddListener(Button8Pressed);
        Button9.onClick.AddListener(Button9Pressed);

        RandomizeNumber();
    }

    private void RandomizeNumber()
    {
        for (int i = 0; i < cypher.Length ; i++)
        {
            cypher[i] = Random.Range(-1, 11);
        }
    }

    private void AddTextCode(string newText)
    {
        GameManager.GameManagerInstance.RemoveCoins(1);

        code[count] = int.Parse(newText);

        switch (row)
        {
        case 1:
            FirstRow[count].text = newText;
            break;
        case 2:
            SecondRow[count].text = newText;
            break;
        case 3:
            ThirdRow[count].text = newText;
            break;
        case 4:
            LastRow[count].text = newText;
            break;
        default:
            print ("Incorrect intelligence level.");
            break;
        }
        count++;
        if(count >= cypher.Length)
        {
            for(int i = 0; i < cypher.Length; i++)
            {
                switch (row)
                {
                case 1:
                    if (cypher[i] == code[i])
                    {
                        FirstRow[i].color = Color.green;
                    }
                    break;
                case 2:
                    if (cypher[i] == code[i])
                    {
                        SecondRow[i].color = Color.green;
                    }
                    break;
                case 3:
                    if (cypher[i] == code[i])
                    {
                        ThirdRow[i].color = Color.green;
                    }
                    break;
                case 4:
                    if (cypher[i] == code[i])
                    {
                        LastRow[i].color = Color.green;
                    }
                    break;
                default:
                    print ("Incorrect intelligence level.");
                    break;
                }
            }

            count = 0;

            row++;
            if(row >= cypher.Length + 2) row = 1;
        } 
        
        
    }

    private void GuivePrize()
    {
        Debug.Log ("WIN");
        GameManager.GameManagerInstance.AddCoins(50);
        RandomizeNumber();
        row = 1;
        count = 1;

    }

    private void Button0Pressed()
    {
        string newText = "0";
        AddTextCode(newText);
    }

    private void Button1Pressed()
    {
        string newText = "1";
        AddTextCode(newText);
    }

    private void Button2Pressed()
    {
        string newText = "2";
        AddTextCode(newText);
    }

    private void Button3Pressed()
    {
        string newText = "3";
        AddTextCode(newText);
    }

    private void Button4Pressed()
    {
        string newText = "4";
        AddTextCode(newText);
    }

    private void Button5Pressed()
    {
        string newText = "5";
        AddTextCode(newText);
    }

    private void Button6Pressed()
    {
        string newText = "6";
        AddTextCode(newText);
    }

    private void Button7Pressed()
    {
        string newText = "7";
        AddTextCode(newText);
    }

    private void Button8Pressed()
    {
        string newText = "8";
        AddTextCode(newText);
    }
    private void Button9Pressed()
    {
        string newText = "9";
        AddTextCode(newText);
    }

}