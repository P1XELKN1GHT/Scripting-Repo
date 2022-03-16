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
    float startDelay;

    public GameObject projectile;

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
            Transform.position = Vector2.Movetowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if(Vector2.Distance(transform.position, target.position) < stopdist && Vector2.Distance(transform.position, targetposition) > retreatdist)
        {
            transform.positionm= this.transform.position;
        }
        else if(Vector2.Distance(transform.position,target.position) > retreatdist)
        {
            Transform.position = Vector2.Movetowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
