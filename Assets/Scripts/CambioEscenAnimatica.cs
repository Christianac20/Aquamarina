using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Carga librerias gestión de escenas

public class CambioEscenAnimatica : MonoBehaviour
{
    public float delay;
    public int escenaACambiar;

    // Start is called before the first frame update
    public void Start()
    {
        Invoke("IniciarCarga", delay); // Ejecuta la función IniciarCarga pasados 10 segundos
    }


    public void IniciarCarga()
    {
        SceneManager.LoadScene(escenaACambiar); //Carga una escena
    }
}
