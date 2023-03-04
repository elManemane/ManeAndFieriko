using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryItemIcons : MonoBehaviour
{
    public static InventoryItemIcons Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Sprite swordSprite, coinSprite;
}
