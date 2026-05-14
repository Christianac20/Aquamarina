using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnableTriggerDialogues : MonoBehaviour
{
    #region VARIABLES
    int sceneIndex;
    Scene currentScene;
    [SerializeField] GameObject[] dialoguesdialogues;
    [SerializeField] DialogueTriggerScene1 dialogueTriggerScene1;
    [SerializeField] DialogueTriggerScene5 dialogueTriggerScene2;
    #endregion

    #region METHODS
    private void Awake()
    {
        dialogueTriggerScene1 = GetComponentInChildren<DialogueTriggerScene1>();
        dialogueTriggerScene2 = GetComponentInChildren<DialogueTriggerScene5>();
    }
    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene(); //Obtiene la escena actual
        sceneIndex = currentScene.buildIndex; //Obtiene el indice de la escena actual (0 es la terrestre)

        SetDialogueTriggers();
    }

    void SetDialogueTriggers()
    {
        switch (sceneIndex)
        {
            case 1: //Si es la escena 1 deja activo el collider de la scene 1 y Desactiva los demas colliders
                if (dialogueTriggerScene1)
                {
                    dialoguesdialogues[0].SetActive(false);
                    dialoguesdialogues[1].SetActive(false);
                }
                else
                {
                    dialoguesdialogues[0].SetActive(true);
                    dialoguesdialogues[1].SetActive(false);
                }

                break;
            case 5: //Si es la escena 2 deja activo el collider de la scene 2 y Desactiva los demas colliders
                if (dialogueTriggerScene2)
                {
                    dialoguesdialogues[0].SetActive(false);
                    dialoguesdialogues[1].SetActive(false);
                }
                else
                {
                    dialoguesdialogues[0].SetActive(false);
                    dialoguesdialogues[1].SetActive(true);
                }

                break;
            default: //Si es la escena 3 deja activo el collider de la scene 3 y Desactiva los demas colliders
                dialoguesdialogues[0].SetActive(false);
                dialoguesdialogues[1].SetActive(false);
                break;
        }
    }
    #endregion
}