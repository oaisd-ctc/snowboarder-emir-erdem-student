using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float timeToRestart = 0.5f;

    [SerializeField] ParticleSystem finishEffect;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            finishEffect.Play();
            Invoke("ReloadScene", timeToRestart);
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
