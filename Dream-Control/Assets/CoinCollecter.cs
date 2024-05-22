using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class CoinCollecter : MonoBehaviour {


    [SerializeField] Text myText = null;
    [SerializeField] Collider myCollider = null;
    [SerializeField] GameObject wall = null;
    [SerializeField] GameObject house = null;

    public int newxtLevelToLoad = 0;

    public int coinsCollected = 0;
    public int coinsNeeded = 11;

    public bool lastScene = false;

	
	// Update is called once per frame
	void Update () {
		if (coinsCollected == coinsNeeded && lastScene == false)
        {
            SceneManager.LoadScene(newxtLevelToLoad);
            //NEW LEVEL
        }



        if (coinsCollected == 4)
        {
            if (wall != null)
            {
                Destroy(wall);
            }
        }

        if (coinsCollected == 5)
        {
            if (house != null)
            {
                house.SetActive(true);
            }
        }

        myText.text = "YOU HAVE: " + coinsCollected +  " of 11";
	}

    private void OnTriggerEnter(Collider collision)
    {
        Coin coinScript = collision.gameObject.GetComponent<Coin>();
        if (coinScript)
        {
            Destroy(coinScript.gameObject);
            coinsCollected++;
        }
    }
}
