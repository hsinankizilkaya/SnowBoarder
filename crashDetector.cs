using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class crashDetector : MonoBehaviour
{
    [SerializeField] float loadDelay = 0.5f;
    [SerializeField] ParticleSystem crashEffect;
    [SerializeField] AudioClip crashSFX;

    bool has_crashed = false;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "ground" && !has_crashed)
        {
            has_crashed = true;
            crashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            FindObjectOfType<playerController>().disable_control();
            FindObjectOfType<timer>().Finnish();
            Invoke("reloadScene", loadDelay);
        }
    }
    void reloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
