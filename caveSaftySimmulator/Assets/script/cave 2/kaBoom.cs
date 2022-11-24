using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaBoom : MonoBehaviour
{
    public GameObject item;
    public GameObject info;
    public GameObject explosive;
    public GameObject info2;

    public bool entered;
    private void Start()
    {
        entered = false;
        info.SetActive(false);
        explosive.SetActive(false);
        info2.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("player has entered ");
        info.SetActive(true);
        entered = true;

    }
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("player has entered ");
        info.SetActive(false);
        entered = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && entered)
        {
            Debug.Log("interacted");
            explosive.SetActive(true);
            info.SetActive(false);
            info2.SetActive(true);
            Invoke("info_2", 4f);
            item.SetActive(false);
        }
    }

    private void info_2()
    {
        info2.SetActive(false);
    }
}
