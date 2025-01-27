using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pipespawner : MonoBehaviour
{
    public GameObject Pipes;

    public void RestartScene()
    {
        // Get the current scene
        Scene currentScene = SceneManager.GetActiveScene();
        
        // Reload the current scene
        SceneManager.LoadScene(currentScene.name);
    }

    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }

    void Start()
    {
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(-1f, 4f);
            GameObject newPipes = Instantiate(Pipes, new Vector3(2, rand, 0), Quaternion.identity);
            Destroy(newPipes, 10);
        }
    }
}
