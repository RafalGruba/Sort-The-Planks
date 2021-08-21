using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip buttonClickedSFX;

    public static SFXManager sfxInstance;

    private void Awake()
    {
        sfxInstance = this;
    }

    public void PlaybuttonClickedSFX()
    {
        SFXManager.sfxInstance.audioSource.PlayOneShot(SFXManager.sfxInstance.buttonClickedSFX);
    }
}
