using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    private Rigidbody rb;
    public GameObject Bullet;
    public Transform Gun;
    public float shootrate = 0f;
    public float shootForce = 0f;
    private float shootRateTimeStamp = 0f; 


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.Space))
        {
            if (Time.time > shootRateTimeStamp)
            {
                GameObject go = (GameObject)Instantiate(
                    Bullet, Gun.position, Gun.rotation);
                go.GetComponent<Rigidbody>().AddForce(Gun.forward * shootForce);
                shootRateTimeStamp = Time.time + shootrate;



            }




        }








    }
}
