using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandsHack : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject Hand;
    public Vector3 offsetVector = new Vector3(0.1f,0,0);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Hand.transform.TransformPoint(offsetVector);
        this.transform.rotation = Hand.transform.rotation;
    }
}
