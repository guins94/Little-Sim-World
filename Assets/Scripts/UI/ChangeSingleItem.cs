using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeSingleItem : MonoBehaviour
{
    [Header("Change Item Components References")]
    [SerializeField] SpriteRenderer ItemSpriteRenderer = null;
    [SerializeField] Image ItemHolderImage = null;
    [SerializeField] List<Sprite> ItemListSprite = new List<Sprite>();
    [SerializeField] Sprite sprite = null;
    
    private int itemIndex = 0;

    private void Start()
    {
        ItemHolderImage.sprite = sprite;
    }

    public void PreviousItemImage()
    {
        if (ItemListSprite.Count <= 1) return;
        if (itemIndex < ItemListSprite.Count -1)
        {
            itemIndex ++;
        }
        else
        {
            itemIndex = 0;
        }
        ItemSpriteRenderer.sprite = ItemListSprite[itemIndex];
        ItemHolderImage.sprite = ItemListSprite[itemIndex];
    }

    public void NextItemImage()
    {
        if (ItemListSprite.Count <= 1) return;
        if (itemIndex == 0)
        {
            itemIndex = ItemListSprite.Count -1;
        }
        else
        {
            itemIndex --;
        }
        ItemSpriteRenderer.sprite = ItemListSprite[itemIndex];
        ItemHolderImage.sprite = ItemListSprite[itemIndex];
    }

    public void AddToItemList(Sprite newSprite)
    {
        ItemListSprite.Add(newSprite);
    }
}
