using UnityEngine;

public class Stats : MonoBehaviour
{
    public int hp;
    public int maxHP = 3;

    private void Start()
    {
        hp = maxHP;
    }

    private void Update()
    {
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
