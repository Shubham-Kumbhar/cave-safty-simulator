using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cave2Manager : MonoBehaviour
{
    [SerializeField]private int curentNoOfItemsCollected = 0, noOftotalItems;
    public GameObject doorCollider;
    public GameObject cautionCollider;
    private void Start()
    {
        doorCollider.SetActive(false);
    }
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
            doorCollider.SetActive(true);
            Destroy(cautionCollider);
        }
    }
}
