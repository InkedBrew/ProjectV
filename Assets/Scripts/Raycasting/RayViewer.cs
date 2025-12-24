using UnityEngine;

public class RayViewer : MonoBehaviour
{
    public float weaponRange = 50f;
    public Camera fpsCam;
    void Start()
    {
        fpsCam = Camera.main;
    }

    public void ShowLineOfFire()
    {
        Vector3 lineOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(lineOrigin, fpsCam.transform.forward * weaponRange, Color.green);
    }
}
