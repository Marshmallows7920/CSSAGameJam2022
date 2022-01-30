using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialoguePopouts : MonoBehaviour
{
    bool pause = false;
    bool currentStatus = false;

    [SerializeField] GameObject pauseMenu;

    void Start()
    {
        Debug.Log("LoadSceneB");
    }

    void update() {
        
    }

    public void LoadB(int sceneANumber)
    {
        Debug.Log("sceneBuildIndex to load: " + sceneANumber);
        SceneManager.LoadScene(sceneANumber);
    }

    private void pauseEnable()
    {
        if (!currentStatus && pause)
        {
            pauseMenu.SetActive(true);
        }
        else if (currentStatus && !pause) {
            pauseMenu.SetActive(false);
        }
    }



}
