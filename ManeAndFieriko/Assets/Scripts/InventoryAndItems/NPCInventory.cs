using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCInventory : MonoBehaviour
{
    public LootContainer LC;
    private void Start()
    {
        LC.Containers.Add(gameObject);
    }
}
