using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    #region VARIABLES
    public string itemName; //Nombre del item a recoger
    public StatToChange statToChange = new StatToChange(); //Funcion para cambiar una stat del player
    public float ammountTOChangeStat; //Cantidad que lo cambia
    [SerializeField] Timer timer; //Script del timer

    #endregion

    #region METHODS
    void Update() //Busca el timer si no lo tiene asignado
    {
        if (timer != null)
        {
            timer = FindObjectOfType<Timer>();
            Debug.Log("Timer found");
        }
        else 
        {
            Debug.LogError("FAH");
        }

    }

    public bool UseItem() //Metodo para usar item desde el inventario
    {
        if(statToChange == StatToChange.health) //Si el scriptable object vale pa cambiar la stat de salud
        {
            Timer timer = GameObject.Find("Player").GetComponent<Timer>(); //Encuentra el timer
            if (timer.currentTime == timer.totalTime) //Si ta a tope no hace nada
            {
                return false;
            }
            else //Si no está a tope, añade la cantidad definida de aire al timer
            {
                timer.AddTime(ammountTOChangeStat);

                Debug.Log("Se añadieron " + ammountTOChangeStat + " puntos de vida");
                return true;
            }
        }
        return false;
    }

    public enum StatToChange //Variables que puede cambiar el scriptable object (Salud solo)
    {
        none,
        health
    };

    #endregion
}
