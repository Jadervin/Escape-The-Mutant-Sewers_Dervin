using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
    public GameObject Player;
    //public Health healthstat;
    public float expiryTime = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, expiryTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
            if (collision.gameObject.tag == "Enemy")
            {

                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                Debug.Log("DESTROYED");
            }

        if (collision.gameObject.tag == "Player")
        {

            
            Destroy(this.gameObject);
            
        }

    }
    /*
    private void OnTriggerEnter(Collider collide)
    {
        if (collide.gameObject.tag == "Player")
        {

                Player.GetComponent<Health>().currentHP = Player.GetComponent<Health>().currentHP - 1;

                if (Player.GetComponent<Health>().currentHP == Player.GetComponent<Health>().NoHP)
                {
                    SceneManager.LoadScene(Player.GetComponent<Health>().gameover);

                }

                //Destroy(collision.gameObject);
                Destroy(this.gameObject);
                Debug.Log("DESTROYED");
        }

    
    }

    */








}
