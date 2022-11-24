using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cave1Colliders : MonoBehaviour
{
    public int score = 1;
    [SerializeField] private GameObject item;
    [SerializeField] private GameObject info;
    [SerializeField]private cave2Manager manager;
    public bool entered;
    private void Awake()
    {
        manager = GameObject.FindObjectOfType<cave2Manager>();
    }
    private void Start()
    {
        entered = false;
        info.SetActive(false);
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
            info.SetActive(false);
            manager.incremntI(score);
            Destroy(item);
        }
    }
}