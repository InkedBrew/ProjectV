using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandgunFire : MonoBehaviour
{

    [SerializeField] private AudioSource emptyGun;
    [SerializeField] GameObject handgun;
    [SerializeField] bool canFire = false;
    InputAction fire = new InputAction(binding: "<Mouse>/leftButton");
    InputAction reload = new InputAction(binding: "<Keyboard>/r");
    // Call to activate on player input when firing weapon

    void OnEnable() => fire.Enable();
    void OnDisable() => fire.Disable();
    //private void OnEnable() => reload.Enable();
    //void OnDisable() => reload.Disable();
    IEnumerator FiringGun()
    {
        GlobalAmmo.handgunAmmoCount -= 1;
        handgun.GetComponent<Animator>().Play("HandgunFire");
        yield return new WaitForSeconds(0.1f);
        handgun.GetComponent<Animator>().Play("New State");
        yield return new WaitForSeconds(0.1f);
        //canFire = true;
    }

    void Update()
    {
       if (fire.triggered)
        {
            if(GlobalAmmo.handgunAmmoCount > 0)
            {
                StartCoroutine(FiringGun());
            }
            else
            {
                //If ammo is 0 > Play empty sound
                emptyGun.Play();
            }
            //canFire = true;
        }
       /*
        if (canFire == true)
        {
            canFire = false;
            StartCoroutine(FiringGun());
        }*/
    }


}