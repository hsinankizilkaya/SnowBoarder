using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finish : MonoBehaviour
{
   [SerializeField] float loadDelay = 0.5f;
   [SerializeField] ParticleSystem FinishEffect;
   [SerializeField] ParticleSystem FinishEffect2;
   [SerializeField] AudioClip finishSFX;

   void OnTriggerEnter2D(Collider2D other) 
   {
       if(other.tag == "Player")
       {
           FindObjectOfType<timer>().Finnish();
           FinishEffect.Play();
           FinishEffect2.Play();
           GetComponent<AudioSource>().PlayOneShot(finishSFX);
           Invoke("reloadGame",loadDelay);
       }
   }
   void reloadGame()
   {
       SceneManager.LoadScene(0);
   }

}
