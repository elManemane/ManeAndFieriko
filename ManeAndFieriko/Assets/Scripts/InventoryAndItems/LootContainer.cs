using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootContainer : MonoBehaviour
{
    public List<GameObject> Containers;
    public List<GameObject> NearContainers;
    public GameObject NearestContainer;

    float dist = 10f;

    private void Start()
    {
        StartCoroutine("CheckNearestContainer");
    }

    IEnumerator CheckNearestContainer()
    {
        NearContainers.Clear();
        foreach(GameObject Container in Containers)
        {
            if((transform.position - Container.transform.position).sqrMagnitude < dist * dist)
            {
                NearContainers.Add(Container);
                Debug.Log("CloseContainers");
            }
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("CheckNearestContainer");
    }
}
