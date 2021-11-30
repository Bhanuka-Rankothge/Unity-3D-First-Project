using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    int x = 10;
    int y = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(x>y){
            Debug.Log("X is Larger than Y");
        }else{
            Debug.Log("Y is Larger than x");
        }
    }
}
