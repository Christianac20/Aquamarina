using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortimer : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] Animator animator; //Animator de Coralius
    [SerializeField] int randomNum; //randomNum que generaremos para ver que animacion sacamos
    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>(); //Almaceno el componente de animator
        InvokeRepeating("GetRandomNum", 5, 5); //Comprobamos el RandomNum para ver si reproducimos una animacion especial
    }

    void GetRandomNum()
    {
        randomNum = Random.Range(0, 10);

        switch (randomNum)
        {
            case 2: //Si sale 2, hacemos LongIdle
                animator.SetTrigger("LongIdle");
                break;
        }
    }
    #endregion
}
