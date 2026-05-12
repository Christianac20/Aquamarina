using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetCameraLimits : MonoBehaviour
{
    #region VARIABLES
    int sceneIndex;
    Scene currentScene;
    [SerializeField] GameObject[] cameraLimits;
    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene(); //Obtiene la escena actual
        sceneIndex = currentScene.buildIndex; //Obtiene el indice de la escena actual (0 es la terrestre)

        switch (sceneIndex)
        {
            case 1:
                cameraLimits[0].SetActive(true);
                cameraLimits[1].SetActive(false);
                cameraLimits[2].SetActive(false);
                cameraLimits[3].SetActive(false);
                cameraLimits[4].SetActive(false);
                break;
            case 2:
                cameraLimits[1].SetActive(true);
                cameraLimits[0].SetActive(false);
                cameraLimits[2].SetActive(false);
                cameraLimits[3].SetActive(false);
                cameraLimits[4].SetActive(false);
                break;
            case 3:
                cameraLimits[2].SetActive(true);
                cameraLimits[0].SetActive(false);
                cameraLimits[1].SetActive(false);
                cameraLimits[3].SetActive(false);
                cameraLimits[4].SetActive(false);
                break;
            case 4:
                cameraLimits[3].SetActive(true);
                cameraLimits[0].SetActive(false);
                cameraLimits[1].SetActive(false);
                cameraLimits[2].SetActive(false);
                cameraLimits[4].SetActive(false);
                break;
            case 5:
                cameraLimits[4].SetActive(true);
                cameraLimits[0].SetActive(false);
                cameraLimits[1].SetActive(false);
                cameraLimits[2].SetActive(false);
                cameraLimits[3].SetActive(false);
                break;
        }
    }
    #endregion
}
