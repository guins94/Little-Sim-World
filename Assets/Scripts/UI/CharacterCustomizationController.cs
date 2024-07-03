using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCustomizationController : MonoBehaviour
{
    [Header("ShopController Components References")]
    [SerializeField] ShopUIController Hatshop = null;
    [SerializeField] ShopUIController Faceshop = null;
    [SerializeField] ShopUIController Dagger01shop = null;
    [SerializeField] ShopUIController Torsoshop = null;


    [Header("Change Item Components References")]
    [SerializeField] ChangeSingleItem Hat = null;
    [SerializeField] ChangeSingleItem Face = null;
    [SerializeField] ChangeSingleItem RightArm = null;
    [SerializeField] ChangeSingleItem LeftArm = null;
    [SerializeField] ChangeSingleItem RightLeg = null;
    [SerializeField] ChangeSingleItem LeftLeg = null;
    [SerializeField] ChangeSingleItem Torso = null;
    [SerializeField] ChangeSingleItem Dagger01 = null;


    // Start is called before the first frame update
    void Start()
    {
        Hatshop.AddItem += AddHatToList;
        Faceshop.AddItem += AddFaceToList;
        Torsoshop.AddItem += AddTorsoToList;
        Dagger01shop.AddItem += AddDagger01ToList;

    }

    private void AddHatToList(Sprite newSprite)
    {
        Hat.AddToItemList(newSprite);
    }

    private void AddFaceToList(Sprite newSprite)
    {
        Face.AddToItemList(newSprite);
    }

    private void AddTorsoToList(Sprite newSprite)
    {
        Torso.AddToItemList(newSprite);
    }

    private void AddDagger01ToList(Sprite newSprite)
    {
        Dagger01.AddToItemList(newSprite);
    }
}
