using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public void LoadSceneByIndex(int index)
    {
        // Load the scene by its build index
        SceneManager.LoadScene(index);
    }
}
