using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
            case ItemType.Weapon: return InventoryItemIcons.Instance.swordSprite;
            case ItemType.Coin: return InventoryItemIcons.Instance.coinSprite;
        }
    }
}
