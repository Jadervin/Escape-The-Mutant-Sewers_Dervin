using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    public NavMeshAgent pathfinding;
    public GameObject muzzle;
    public GameObject projectile;
    public GameObject eyes;
    public float visionRange;
    public bool pursuing = false;
    private GameObject target;


   

    // Update is called once per frame
    void Update()
    {

        if(!pursuing)
        {
                Ray ray = new Ray(eyes.transform.position, eyes.transform.forward * visionRange);

                Debug.DrawRay(ray.origin, ray.direction*visionRange, Color.red);

                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {

                     Debug.Log("I see somethinng");
                     pursuing = true;
                     target = hit.transform.gameObject;

                }
                
        }
        else
        {
            if(target==null)
            {
                pursuing = false;
            }
            pathfinding.SetDestination(target.transform.position);


        }
    }
}
