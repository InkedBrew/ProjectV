using System;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    [SerializeField] AudioSource gunAudio;

    private void Start()
    {
        gunAudio = GameObject.FindWithTag("Gun").GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        GunBehavior.OnGunFire += GunFireSFX;
    }
    private void OnDisable()
    {
        GunBehavior.OnGunFire -= GunFireSFX;
    }

    void GunFireSFX(int gunDamage)
    {
        gunAudio.Play();
    }

}
