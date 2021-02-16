using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RatBossScript : MonoBehaviour
{

    //public NavMeshAgent pathfinding;
    //public GameObject muzzle;
    //public GameObject projectile;
    //public GameObject eyes;
    //public float visionRange;
    //public bool pursuing = false;
    //private GameObject target;





    //Enemy Shooting Variables
    public GameObject playerFind;

    private Rigidbody rb;
    public float wTime;
    private float cTime;
    public bool Shot;
    public GameObject bullet;
    public Transform Gun1;
    public Transform Gun2;
    public float shootRate = 0f;
    public float shootforce = 0f;
    private float ShootRateTimeStamp = 0f;



    public void Start()
    {
        playerFind = GameObject.FindWithTag("Player");
        //Debug.Log("Found You!");



    }


    // Update is called once per frame
    void Update()
    {

        this.transform.LookAt(playerFind.transform);


        if (cTime == 0)
        {
            Shooting();
        }


        if (Shot && cTime < wTime)
        {
            cTime += 1 * Time.deltaTime;

        }



        if (cTime >= wTime)
        {

            cTime = 0;
        }







    }




    public void Shooting()
    {
        Shot = true;
        if (Time.time > ShootRateTimeStamp)
        {
            GameObject go = (GameObject)Instantiate(
                bullet, Gun1.position, Gun1.rotation);
            go.GetComponent<Rigidbody>().AddForce(Gun1.forward * shootforce);
            ShootRateTimeStamp = Time.time + shootRate;

            GameObject go2 = (GameObject)Instantiate(
                bullet, Gun2.position, Gun2.rotation);
            go2.GetComponent<Rigidbody>().AddForce(Gun2.forward * shootforce);
            ShootRateTimeStamp = Time.time + shootRate;

        }
        Debug.Log("SHOT");
    }


}
