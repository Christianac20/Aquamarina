using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishCapture : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] SpriteRenderer fishStandard;
    [SerializeField] GameObject fishCaptured;
    [SerializeField] Transform player;
    [SerializeField] float speed = 0.1f; // 0 = no movement, 1 = instant
    [SerializeField] Fish fishScript;

    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Start()
    {
        fishStandard = GetComponent<SpriteRenderer>();
        player = GameObject.FindWithTag("FishGatherer").GetComponent<Transform>();
        fishScript = GetComponent<Fish>();

        fishCaptured.GetComponent<SpriteRenderer>().enabled = false;
        fishScript.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Captured()
    {
        fishStandard.enabled = false; //Desactivo sprite normal
        fishCaptured.GetComponent<SpriteRenderer>().enabled = true; //Activo sprite de la version capturada
        fishScript.enabled = true;

        StartCoroutine("MoveToPlayer");
    }

    IEnumerator MoveToPlayer()
    { 
        yield return new WaitForSeconds(0.5f);
        while (transform.position != player.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
        }
    }
    #endregion
}
