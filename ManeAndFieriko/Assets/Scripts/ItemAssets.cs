using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemAsstes : MonoBehaviour
{
    public static ItemAsstes Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
    }

    public Transform pfItemWorld;
    public Sprite swordSprite, coinSprite;
}
