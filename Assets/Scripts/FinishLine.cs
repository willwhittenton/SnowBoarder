using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float reloadTimer = 0.5f;
    [SerializeField] ParticleSystem finishEffect;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            finishEffect.Play();
            Invoke("ReloadScene", reloadTimer);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
