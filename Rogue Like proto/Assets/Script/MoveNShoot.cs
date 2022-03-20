using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveNShoot : MonoBehaviour
{
    public float speed;
    public float stopdist;
    public float retreatdist;

    Transform target;

    float shotDelay;
    float startDelay = 0.2f;

    public GameObject Projectile;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shotDelay = startDelay;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position,target.position) > stopdist)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, target.position) < stopdist && Vector2.Distance(transform.position, target.position) > retreatdist)
        {
            transform.position = this.transform.position;
        }
        else if(Vector2.Distance(transform.position,target.position) > retreatdist)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if(shotDelay <= 0)
        {
            Instantiate(Projectile, transform.position, Quaternion.identity);
            shotDelay = startDelay;
        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
    }   
}
