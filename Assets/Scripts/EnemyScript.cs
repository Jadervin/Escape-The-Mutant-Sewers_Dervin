using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{

    //public NavMeshAgent pathfinding;
    //public GameObject muzzle;
    //public GameObject projectile;
    //public GameObject eyes;
    //public float visionRange;
    //public bool pursuing = false;
    //private GameObject target;


    


    //Enemy Shooting Variables
    public GameObject player;

    private Rigidbody rb;
    public float waitTime;
    private float currentTime;
    public bool shot;
    public GameObject Bullet;
    public Transform Gun;
    public float shootrate = 0f;
    public float shootForce = 0f;
    private float shootRateTimeStamp = 0f;



    public void Start()
    {
        player = GameObject.FindWithTag("Player");
        //Debug.Log("Found You!");



    }

   
    // Update is called once per frame
    void Update()
    {

        this.transform.LookAt(player.transform);


        if (currentTime == 0)
        {
            Shoot();
        }


        if (shot && currentTime < waitTime)
        {
            currentTime += 1 * Time.deltaTime;

        }



        if (currentTime >= waitTime)
        {

            currentTime = 0;
        }






        /*
        if(!pursuing)
        {
                Ray ray = new Ray(eyes.transform.position, eyes.transform.forward * visionRange);

                Debug.DrawRay(ray.origin, ray.direction*visionRange, Color.red);

                RaycastHit hit;

                if(Physics.Raycast(ray, out hit)&&hit.transform.gameObject.tag=="Player")
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

        */
    }




    public void Shoot()
    {
        shot = true;
        if (Time.time > shootRateTimeStamp)
        {
            GameObject go = (GameObject)Instantiate(
                Bullet, Gun.position, Gun.rotation);
            go.GetComponent<Rigidbody>().AddForce(Gun.forward * shootForce);
            shootRateTimeStamp = Time.time + shootrate;



        }
        Debug.Log("SHOT");
    }


}
