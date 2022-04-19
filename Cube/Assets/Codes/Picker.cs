using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Picker : MonoBehaviour
{
    public Text coinText;
    int coinMeter = 0;
    GameObject Player;
    int Height;
    void Start()
    {
        Player = GameObject.Find("Player");
    }
    void Update()
    {
        Player.transform.position = new Vector3(transform.position.x, Height, transform.position.z);
        this.transform.localPosition = new Vector3(0, -Height, 0);
    }
    public void heightReduction()
    {
        Height = Height - 1;    
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Plus"&&other.gameObject.GetComponent<collectableCoin>().GetHasItGathered()==false)
        {
            Height += 1;
            other.gameObject.GetComponent<collectableCoin>().toCollect();
            other.gameObject.GetComponent<collectableCoin>().IndexSet(Height);
            other.gameObject.transform.parent = Player.transform;

        }
        if (other.gameObject.tag == "Plus")
        {
            coinMeter++;
            coinText.text = "Coin Meter = " + coinMeter;

        }

    }
}
