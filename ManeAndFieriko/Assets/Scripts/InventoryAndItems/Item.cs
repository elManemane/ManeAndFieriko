using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Item
{
    public enum ItemType
    {
        Weapon,
        HealthPotion,
        Coin
    }

    public ItemType itemType;
    public int amount;

    public Sprite GetSprite()
    {
        switch (itemType)
        {
            default:
            case ItemType.Weapon: return ItemAsstes.Instance.swordSprite;
            case ItemType.Coin: return ItemAsstes.Instance.coinSprite;
        }
    }
}
