using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scene : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.Confined;
    }
    // Start is called before the first frame update
    public void chnage(int sceneNo)
    {
        SceneManager.LoadScene(sceneNo);
    }
    public void quit()
    {
        Application.Quit();
    }
}
