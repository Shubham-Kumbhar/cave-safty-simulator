using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cautionScript : MonoBehaviour
{
    public GameObject caution;

    private void Start()
    {
        caution.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        caution.SetActive(true);
    }
    public void OnTriggerExit(Collider other)
    {
        caution.SetActive(false);
    }
}
