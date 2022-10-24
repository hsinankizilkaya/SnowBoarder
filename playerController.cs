using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class playerController : MonoBehaviour
{
    
    [SerializeField] float torqueAmount = 2f;
    [SerializeField] float boostedSpeed = 40f;
    [SerializeField] float basedSpeed = 25f;
    Rigidbody2D rb2;
    SurfaceEffector2D surfaceEffector2D;
    bool canMove =  true;
    bool fast = false;

     
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();     
    }

    void Update()
    {
        if(canMove)
        {
            controlPlayer();
            speedBooster();
        }
    }

    void controlPlayer()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2.AddTorque(torqueAmount);
        }
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb2.AddTorque(-torqueAmount);
        }               
    }

    public void disable_control()
    {
        canMove = false;
    }

    void speedBooster()
        {
            if(Input.GetKey(KeyCode.UpArrow))
            {
                fast = true;
                surfaceEffector2D.speed = boostedSpeed;   

            }
            else if (fast == true)
            {
                fast = false;
                surfaceEffector2D.speed = basedSpeed;
            }               
        }

    
    
}



  



















