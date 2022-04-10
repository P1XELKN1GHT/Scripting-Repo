using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enmy : MonoBehaviour
{   
    [Header("Enemy Health")]
    public int curHp;
    public int maxHp;

    [Header("Enemy Attack")]
    public int dmg;
    public float atkRange;
    public int atkRate;
    public float lastAtkTime;
    public Controller Player;

    [Header("Loot Drop")]
    public GameObject lootdrop;


    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player").GetComponent<Controller>();
    }
        
    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastAtkTime >= atkRate && Vector2.Distance(transform.position, Player.transform.position) < atkRange)
        {
            Attack();
        }
    }
    public void TakeDamage(int dmg)
    {
        curHp -= dmg;

        if(curHp <= 0)
        {
            Die();
            LootDrop();
        }
    }
    void Attack()
    {
        lastAtkTime = Time.time;
        Player.TakeDamage(dmg);
        
    }
    void Die()
    {
        Destroy(gameObject);
    }
    void LootDrop()
    {
        Instantiate(lootdrop, transform.position, Quaternion.identity);
    }
    
}
