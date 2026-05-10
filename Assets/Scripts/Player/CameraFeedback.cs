using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFeedback : MonoBehaviour
{
    #region VARIABLES
    [SerializeField] PlayerController_Equipment playerEquipment;
    [SerializeField] Animator animator;

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        playerEquipment = FindObjectOfType<PlayerController_Equipment>();
    }

    // Update is called once per frame
    void Update()
    {
        TakePhoto();
    }

    void TakePhoto()
    {
        if (playerEquipment.cameraEquipped && playerEquipment.actionAttack.WasPressedThisFrame())
        {
            animator.SetTrigger("TakePhoto");
        }
    }
}
