using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{


    [Range(0, 100)]
    public float Speed;
    private Vector2 movement = new Vector2(1, 1);
    [SerializeField]
    public GameObject Player;
    public Rigidbody rb;
    //public bool PlayerGround = true;
    public string movementAxis = "Horizontal";
    //public string youwin;



    public Health health;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float axis = Input.GetAxis(movementAxis);

        Player.transform.Translate(new Vector2(axis * Speed * Time.deltaTime, 0));

       /* if(Input.GetButtonDown("Jump") && PlayerGround)
        {

            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
            PlayerGround = false;
        }
       */
    }
    private void OnCollisionEnter(Collision collision)
    {
       

        /*

        if (collision.gameObject.tag == "Floor")
        {
            PlayerGround = true;
        }
        if (collision.gameObject.tag == "Win")
        {
            SceneManager.LoadScene(youwin);
        }
        */
    }
}
