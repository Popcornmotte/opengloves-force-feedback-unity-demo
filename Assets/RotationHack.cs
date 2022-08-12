using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationHack : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject VRCam;
    private float offset = -1.74f;
    private Vector3 temp = new Vector3();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec0 = VRCam.transform.rotation.eulerAngles;
        Quaternion target = Quaternion.Euler(0,vec0.y,0);
        this.transform.rotation = Quaternion.Slerp(transform.rotation,target,Time.deltaTime * 2.5f);
        Vector3 vec1 = VRCam.transform.position;
        this.transform.position = new Vector3(vec1.x,vec1.y+offset,vec1.z);
    }
}
