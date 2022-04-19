using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collectableCoin : MonoBehaviour
{
    bool hasItGathered;
    int index;
    public Picker picker;
    void Start()
    {
        hasItGathered = false;
    }
    void Update()
    {
        if (hasItGathered == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            picker.heightReduction();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
           
        }
        if (other.gameObject.tag == "Saw")
        {
            picker.heightReduction();
            other.gameObject.GetComponent<CapsuleCollider>().enabled = false;
           
        }
    }
    public bool GetHasItGathered()
    {
        return hasItGathered;
    }
    public void toCollect()
    {
        hasItGathered = true;
    }
    public void IndexSet(int index)
    {
        this.index = index;
    }

}
