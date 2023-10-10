using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadDelay = 1f;
    [SerializeField] ParticleSystem finishEffect0;
    [SerializeField] ParticleSystem finishEffect1;
    [SerializeField] ParticleSystem finishEffect2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect0.Play();
            finishEffect1.Play();
            finishEffect2.Play();
            GetComponent<AudioSource>().Play();
            Invoke("ReloadScene", reloadDelay);
        }  
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
