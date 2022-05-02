using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyATK : MonoBehaviour
{
    [Header("Enemy Damage")]
    public int damage;
    public int atkRange;
    public float atkRate;
    public float lastAtkTime;
    public PlayerController2D Character;

    [Header("Enemy HP")]
    public int curhp;
    public int maxhp;

    public GameObject lootdrop;

    // Start is called before the first frame update
    void Start()
    {
        Character = GameObject.Find("Character").GetComponent<PlayerController2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time - lastAtkTime >= atkRate && Vector2.Distance(transform.position, Character.transform.position) < atkRange)
        {
            Attack();
        }
    }
    void Attack()
     {
        lastAtkTime = Time.time;
        Character.TakeDamage(damage);
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            Die();
            LootDrop();
        }
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
