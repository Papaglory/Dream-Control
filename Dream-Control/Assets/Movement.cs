using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Movement : MonoBehaviour {

    public bool crash = false;
    [SerializeField] float speed = 2f;
    [SerializeField] float myTime = 7f;
    [SerializeField] Rigidbody rb = null;

    bool fade = false;
    public float fadeTime = 20;

    [SerializeField] CanvasFade canvasFade = null;

    [SerializeField] Image image = null;

    [SerializeField] float fadeSpeed = 0.2f;
    float currentAlpha = 255;

    public GameObject fadePanel = null;

    public AudioSource audioSource = null;

    bool action = false;
    float myBoiTimer = 10;

    // Update is called once per frame
    void Update () {
        if (crash == false)
        {
            Vector3 newPos = this.transform.position;
            newPos.z += speed * Time.deltaTime;
            this.transform.position = newPos;
        }
        else
        {
            rb.AddForce(-Vector3.right * 40);
            //NOTHING
        }

        if (Time.timeSinceLevelLoad > myTime)
        {
            crash = true;
        }



        if (crash == true)
        {
            if (Time.timeSinceLevelLoad > myBoiTimer)
            {
                audioSource.Play();
                myBoiTimer = 999999;
            }

        }

        if (Time.timeSinceLevelLoad > fadeTime)
        {
            SceneManager.LoadScene(0);
        }

        if (fade)
        {
            SceneManager.LoadScene(0);

        }

    }
}
