using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasFade : MonoBehaviour
{

    [SerializeField] Image image = null;

    [SerializeField] float fadeSpeed = 0.2f;
    float currentAlpha = 255;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        var tempColor = image.color;
        tempColor.a -= fadeSpeed;
        image.color = tempColor;

        if (Time.timeSinceLevelLoad > 8)
        {
            this.gameObject.SetActive(false);
        }
    }
}
