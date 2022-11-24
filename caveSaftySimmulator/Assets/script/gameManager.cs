using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int curentNoOfItemsCollected=0,noOftotalItems;
    public GameObject doorCollider;
    public GameObject cautionCollider;
    // Start is called before the first frame update
    public void incremntI(int score)
    {
        curentNoOfItemsCollected++;
        print(curentNoOfItemsCollected);
    }

    // Update is called once per frame
    void Update()
    {
        if (curentNoOfItemsCollected >= noOftotalItems)
        {
            Destroy(doorCollider);
            Destroy(cautionCollider);
        }
    }
}
