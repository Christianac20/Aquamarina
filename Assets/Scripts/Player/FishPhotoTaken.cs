using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FishPhotoTaken : MonoBehaviour
{
    #region VARIABLES
    // VARIABLES BOOL
    bool pezPayaso = false;
    bool caballitoDeMar = false;
    bool pezGlobo = false;
    bool pezCirujanoAzul = false;
    bool medusaLuna = false;
    bool anchoa = false;
    bool raya = false;
    bool pezCometa = false;
    bool atun = false;
    bool barracuda = false;
    bool delfin = false;
    bool tortugaBoba = false;
    bool tiburonBlanco = false;
    bool pezLuna = false;
    bool orca = false;
    bool angelMarino = false;
    bool pezHacha = false;
    bool pezFantasmaAzul = false;
    bool pezFantasmaNaranja = false;
    bool pezFantasmaRojo = false;
    bool pezFantasmaRosa = false;
    bool pezGema = false;
    bool pezFoco = false;
    bool gamba = false;
    bool pulpo = false;
    bool pezComecocos = false;
    bool calamar = false;
    bool pezqueleto = false;
    bool pezBala = false;
    bool pezLinterna = false;
    bool pezFosil = false;
    bool anguilaPelicano = false;
    bool pezGato = false;

    // VARIABLES BUTTONS
    [SerializeField] Button[] buttonsPecesRegistro;

    // VARIABLES IMAGE
    [SerializeField] Image[] imagesPecesRegistro;

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

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        //Detects if player gathers an air bubble
        switch (trigger.gameObject.tag)
        {
            case "PezPayaso":
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "CaballitoDeMar":
                if (!caballitoDeMar)
                {
                    caballitoDeMar = true;
                    buttonsPecesRegistro[1].enabled = true;
                    imagesPecesRegistro[1].color = Color.white;
                }
                break;

            case "PezGlobo":
                if (!pezGlobo)
                {
                    pezGlobo = true;
                    buttonsPecesRegistro[2].enabled = true;
                    imagesPecesRegistro[2].color = Color.white;
                }
                break;

            case "PezCirujanoAzul":
                pezCirujanoAzul = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Anchoa":
                anchoa = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "MedusaLuna":
                medusaLuna = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Raya":
                raya = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezCometa":
                pezCometa = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Atun":
                atun = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Barracuda":
                barracuda = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Delfin":
                delfin = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "TortugaBoba":
                tortugaBoba = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "TiburonBlanco":
                tiburonBlanco = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezLuna":
                pezLuna = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Orca":
                orca = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "AngelMarino":
                angelMarino = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezHacha":
                pezHacha = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezFantasmaAzul":
                pezFantasmaAzul = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezFantasmaNaranja":
                pezFantasmaNaranja = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezFantasmaRojo":
                pezFantasmaRojo = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezFantasmaRosa":
                pezFantasmaRosa = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Gamba":
                gamba = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezFoco":
                pezFoco = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Pulpo":
                pulpo = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Calamar":
                calamar = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezComecocos":
                pezComecocos = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "AnguilaPelicano":
                anguilaPelicano = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezBala":
                pezBala = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezLinterna":
                pezLinterna = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezGato":
                pezGato = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezGema":
                pezGema = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "Pezqueleto":
                pezqueleto = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;

            case "PezFosil":
                pezFosil = true;
                if (!pezPayaso)
                {
                    pezPayaso = true;
                    buttonsPecesRegistro[0].enabled = true;
                    imagesPecesRegistro[0].color = Color.white;
                }
                break;
        }
    }
    #endregion
}
