using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerScene5 : MonoBehaviour
{
    #region VARIABLES
    public bool dialogueTriggerScene2Done = false; //Variable de control para mantener siempre desactivado el dialogo una vez visto
    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision) //Si entra el player en la zona pone a correr el dialogo
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            dialogueTriggerScene2Done = true;
        }
    }
    #endregion
}
