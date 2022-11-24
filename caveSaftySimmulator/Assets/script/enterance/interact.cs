using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public int score = 1;
    public GameObject item;
    public gameManager manager;
    public bool entered;
    private void Awake()
    {
        manager = GameObject.FindObjectOfType<gameManager>();
    }
    private void Start()
    {
        entered = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log("player has entered ");
        entered = true;
        
    }
    public void OnTriggerExit(Collider other)
    {
        Debug.Log("player has entered ");
        entered = false;
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && entered)
        {
            Debug.Log("interacted");
            manager.incremntI(score);
            Destroy(item);
        }
    }
}
