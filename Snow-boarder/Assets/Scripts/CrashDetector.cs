using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem pscrashEffect;
    [SerializeField] float flloadDelay = 0.5f;
    [SerializeField] AudioClip sfxcrashSFX;
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            pscrashEffect.Play();
            GetComponent<AudioSource>().PlayOneShot(sfxcrashSFX);
            Invoke("ReloadScene", flloadDelay);
        }
    }
    void ReloadScene()
    { 
        SceneManager.LoadScene(0);
    }
}
