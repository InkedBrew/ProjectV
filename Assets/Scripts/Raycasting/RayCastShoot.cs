using System.Collections;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using UnityEngine.EventSystems;

public class RayCastShoot : MonoBehaviour
{
    public int gunDamage = 1;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    public float hitForce = 100f;
    public Transform gunEnd;

    public Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(.07f);
    private LineRenderer laserLine;
    RayViewer rayVeiwer;
    RaycastHit hit;
    private float nextFire;
    Vector3 rayOrigin;
    Stats enemyStats;

    public static event System.Action<int> OnGunFire;

    void Start()
    {
        rayVeiwer = GetComponent<RayViewer>();
        laserLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            StartCoroutine(ShotEffect());
            rayOrigin = fpsCam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            laserLine.SetPosition(0, gunEnd.position);
            FireRayCast();
        }
    }

    private IEnumerator ShotEffect()
    {
        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }

    void FireRayCast()
    {
        OnGunFire?.Invoke(gunDamage);

        //Passes if Raycast hit an object
        if (Physics.Raycast(rayOrigin, fpsCam.transform.forward, out hit, weaponRange))
        {
            CheckObjectHit(hit);
            laserLine.SetPosition(1, hit.point);
        }
        else
        {
            laserLine.SetPosition(1, rayOrigin + (fpsCam.transform.forward * weaponRange));
        }
    }

    void CheckObjectHit(RaycastHit hit)
    {
        switch (hit.collider.gameObject.tag)
        {
            case "Enemy":
                enemyStats = hit.collider.gameObject.GetComponent<Stats>();
                enemyStats.hp--;
                print("Enemy hit: " + enemyStats.hp +"/" + enemyStats.maxHP);
                break;
        }
    }
}
