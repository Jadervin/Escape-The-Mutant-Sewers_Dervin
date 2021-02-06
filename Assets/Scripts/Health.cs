using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    
    public int MaxHP;
    [HideInInspector]
    public int currentHP;
    public string gameover;
    public int NoHP;

    public PlayerMovement playerMove;


    

private void OnTriggerEnter(Collider other)
    {
       

        if (other.gameObject.tag == "Enemy" )
        {
    
               currentHP = currentHP - 1;
                Destroy(other.gameObject);
            if (currentHP == NoHP)
            {
                SceneManager.LoadScene(gameover);

            }
        }
      
            
        if (other.gameObject.tag == "Spike")
        {
            currentHP = currentHP - 10;
            
            SceneManager.LoadScene(gameover);
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
        currentHP = MaxHP;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
