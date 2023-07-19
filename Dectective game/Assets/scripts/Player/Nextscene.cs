using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Nextscene : MonoBehaviour
{
    public string sceneName;
    public void NewScene(string nextscene)
    {
        SceneManager.LoadScene(nextscene);
    }
    public void SceneUpdate()
    {
        SceneManager.LoadScene(sceneName);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NewScene(sceneName);
    }
}
