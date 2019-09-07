using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    


    // Update is called once per frame
    public void LoadGame()
    {
        SceneManager.LoadScene("Main");
    }
}
