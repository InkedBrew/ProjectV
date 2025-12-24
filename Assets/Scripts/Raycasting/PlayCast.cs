using System.Collections;
using UnityEngine;

/*public class RayCastShoot : MonoBehaviour
{
    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;

    [SerializeField] private AudioSource emptyGun; //New
    [SerializeField] GameObject handgun; //New(for Animation)


    public Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    private AudioSource gunAudio;
    private LineRenderer laserLine;
    private float nextFire;


    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        gunAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ReloadWeapon();
        }

        if (Input.GetButtonDown("Fire1") && GlobalAmmo.handgunAmmoCount <= 0)
        {
            emptyGun.Play();
        }
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            //Reduce Weapon Ammo
            GlobalAmmo.handgunAmmoCount--;

            //Laser + Sound
            StartCoroutine(ShotEffect());

            //Raycasting
            Vector3 rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
            laserLine.SetPosition(0, gunEnd.position);

            if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
            {
                laserLine.SetPosition(1, hit.point);
            }

            else
            {
                laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
            }
        }
    }

    void ReloadWeapon()
    {
        Debug.Log("attempted to reload");
        GlobalAmmo.handgunAmmoCount = 10; // or other max ammo amount
    }
    private IEnumerator ShotEffect()
    {
        gunAudio.Play();
        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }    

}
*/