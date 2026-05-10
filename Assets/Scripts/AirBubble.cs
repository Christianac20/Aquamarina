using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirBubble : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] Timer timer;

    #endregion

    #region METHODS
    // Start is called before the first frame update
    void Awake()
    {
        timer = FindObjectOfType<Timer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer != null)
        {
            timer = FindObjectOfType<Timer>();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Detects if player gathers an air bubble
        if (collision.gameObject.tag == ("Player"))
        {
            timer.currentTime += timer.addAir;
            Destroy(this.gameObject);
        }
    }
    #endregion
}
