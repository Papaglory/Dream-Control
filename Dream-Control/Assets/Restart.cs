using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {


    public int nextLevel = 0;

    private void OnCollisionEnter(Collision collision)
    {
        var player = collision.gameObject.GetComponent<CoinCollecter>();
        if (player)
        {
            SceneManager.LoadScene(nextLevel);
        }
    }
}
