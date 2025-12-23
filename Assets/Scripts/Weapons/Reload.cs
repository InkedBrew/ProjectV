using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Reload : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)) ReloadWeapon();
    }
    void ReloadWeapon()
    {
        print("attempted to reload");
        GlobalAmmo.handgunAmmoCount = 10;
    }
}
