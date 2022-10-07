using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update
    
    public Vector3 myPos;
    public Transform myPlay;
    // Update is called once per frame
    void Update()
    {
         transform.position = myPlay.position + myPos;
    }
}
