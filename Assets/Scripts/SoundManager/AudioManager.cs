using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("------------Audio Source------------")]
    [SerializeField] AudioSource SFXSource;

    [Header("------------Audio Clip------------")]

    // ITEMS
    
    public AudioClip Plastico;
    public AudioClip Cobre;
    public AudioClip Cristal;
    public AudioClip Hierro;
    public AudioClip Oxigeno;
    public AudioClip BombonaOxigeno;
    [Space]
    // MENU

    public AudioClip IniciarJuego;
    public AudioClip MenuClick;

    // PDA
    [Space]

    public AudioClip Casilla;
    public AudioClip AbrirPDA;
    public AudioClip CerrarPDA;
    public AudioClip SeleccionarPDA;

    // PLAYER
    [Space]
    public AudioClip Hurt01Agh;
    public AudioClip Hurt02Uuf;
    public AudioClip DispararRed;
    public AudioClip RecogerRed;


    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }

}
