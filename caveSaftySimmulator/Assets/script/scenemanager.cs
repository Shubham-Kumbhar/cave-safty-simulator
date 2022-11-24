using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    [SerializeField] private float timeToChange;
    [SerializeField] private int sceneNo;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("colider works");
        Invoke("changeScene", timeToChange);
    }
    public void changeScene()
    {

        SceneManager.LoadScene(sceneNo);
    }
}
