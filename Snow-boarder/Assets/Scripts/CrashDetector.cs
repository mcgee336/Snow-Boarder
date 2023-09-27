using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem pscrashEffect;
    [SerializeField] float flloadDelay = 0.5f;
     void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            pscrashEffect.Play();
            Invoke("ReloadScene", flloadDelay);
        }
    }
    void ReloadScene()
    { 
        SceneManager.LoadScene(0);
    }
}
