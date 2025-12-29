using UnityEngine;

public class WeaponStats : MonoBehaviour
{
    public static int handgunAmmoCount = 10;
    [SerializeField] GameObject ammoDisplay;
    void Start()
    {
        
    }
    void Update()
    {
        ammoDisplay.GetComponent<TMPro.TMP_Text>().text = "" + handgunAmmoCount;
    }
}
