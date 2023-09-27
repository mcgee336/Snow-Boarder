using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] ParticleSystem psfinishEffect; 
    [SerializeField] float flloadDelay = 1f;
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            psfinishEffect.Play(); 
            Invoke("ReloadScene", flloadDelay);
        }    
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
