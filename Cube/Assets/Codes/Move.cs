using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField]
    private float forwardSpeed;
    [SerializeField]
    private float rightLeftSpeed;
    void Start()
    {
        
    }
    void Update()
    {
        float horizontalAxis = Input.GetAxis("Horizontal") * rightLeftSpeed * Time.deltaTime;
        this.transform.Translate(horizontalAxis, 0, forwardSpeed * Time.deltaTime);
    }
}
