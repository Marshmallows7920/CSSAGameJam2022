using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PopoutScript : MonoBehaviour
{

    void Start()
{
    Debug.Log("LoadSceneB");
}

public void LoadB(int sceneANumber)
{
    Debug.Log("sceneBuildIndex to load: " + sceneANumber);
    SceneManager.LoadScene(sceneANumber);
}

}
