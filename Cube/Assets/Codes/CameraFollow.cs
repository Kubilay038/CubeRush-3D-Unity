using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject Target;
    public Vector3 Distance;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, Target.transform.position + Distance, Time.deltaTime);
    }
}
