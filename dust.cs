using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dust : MonoBehaviour
{   

    [SerializeField] ParticleSystem dustEffect;
    
    void Start()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D other)
    { 
        if(other.gameObject.tag == "ground")
        dustEffect.Play();
    }
        
    private void OnCollisionExit2D(Collision2D other) 
    {
        if(other.gameObject.tag == "ground")
        dustEffect.Stop();
    }
}
