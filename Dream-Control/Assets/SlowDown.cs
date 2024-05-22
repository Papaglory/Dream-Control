using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {


    private void OnTriggerEnter(Collider collision)
    {
        var player = collision.gameObject.GetComponent<Car>();
        if (player)
        {
            Time.timeScale = 0.01f;
        }
    }

}
