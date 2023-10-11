using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour
{
    [SerializeField] float reloadTimer = 0.5f;

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            Invoke("ReloadScene", reloadTimer);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
