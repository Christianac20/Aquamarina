using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirBubble : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] Timer timer; //Script del timer
    [SerializeField] PlayerController_Equipment playerEquipment; //Script del playerEquipment

    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Awake() //Guardo preferencias de objects y componentes/scripts
    {
        timer = FindObjectOfType<Timer>();
        playerEquipment = FindObjectOfType<PlayerController_Equipment>();
    }

    // Update is called once per frame
    void Update() //Si no tiene timer o player equipment, los busca y asigna
    {
        if (!timer || !playerEquipment)
        {
            timer = FindObjectOfType<Timer>();
            playerEquipment = FindObjectOfType<PlayerController_Equipment>();
        }
    }
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        //Detects if player gathers an air bubble
        if (trigger.gameObject.tag == ("Player") && !playerEquipment.cameraEquipped)
        {
            timer.currentTime += timer.addAir; //Añade oxigeno al contador
            Debug.Log("O2 añadido");
            Destroy(this.gameObject); //Destruye la burbuja
        }
    }
    #endregion
}
