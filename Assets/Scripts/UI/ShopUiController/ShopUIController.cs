using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopUIController : MonoBehaviour
{
    [SerializeField] Sprite[] vectorItemSprite = null;
    [SerializeField] Image imageHolder = null;
    [SerializeField] Button buyButton = null;
    [SerializeField] TextMeshProUGUI goldTextReference = null;
    [SerializeField] Image avaiabilityImage = null;
    [SerializeField] int[] goldPrice = new int[] {5, 6, 5, 10, 12, 20, 1, 60, 110, 120};
    [SerializeField] bool[] itemAvailable = new bool[] {true, true, true, true, true, true, true};
    
    private int itemIndex = 0;

    void Start()
    {
        buyButton.onClick.AddListener(BuyItem);

        imageHolder.sprite = vectorItemSprite[itemIndex];
        goldTextReference.text = "" + goldPrice[itemIndex];
        UpdateItemAvaiabilityImage();
    }

    void Delete()
    {
        buyButton.onClick.RemoveListener(BuyItem);
    }

    void BuyItem()
    {
        if (itemAvailable[itemIndex] )
        {
            if (GameManager.GameManagerInstance.gold >= goldPrice[itemIndex])
            {
                GameManager.GameManagerInstance.RemoveCoins(goldPrice[itemIndex]);
                itemAvailable[itemIndex] = false;
                UpdateItemAvaiabilityImage();
            }
            else
            {
                Debug.Log("Not Enough Gold");
            }
        }
        else
        {
            Debug.Log("item not available");
        }
    }

    private void UpdateItemAvaiabilityImage()
    {
        avaiabilityImage.enabled = !itemAvailable[itemIndex];
    }

    public void PreviousItemImage()
    {
        if (itemIndex < vectorItemSprite.Length - 1)
        {
            itemIndex ++;
        }
        else
        {
            itemIndex = 0;
        }
        imageHolder.sprite = vectorItemSprite[itemIndex];
        goldTextReference.text = "" + goldPrice[itemIndex];
        UpdateItemAvaiabilityImage();
    }

    public void NextItemImage()
    {
        if (itemIndex == 0)
        {
            itemIndex = vectorItemSprite.Length - 1;
        }
        else
        {
            itemIndex --;
        }
        imageHolder.sprite = vectorItemSprite[itemIndex];
        goldTextReference.text = "" + goldPrice[itemIndex];
        UpdateItemAvaiabilityImage();
    }
}
