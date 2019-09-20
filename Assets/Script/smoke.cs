using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(death());
    }
            
    void Update()
    {
        
    }

    IEnumerator death()
    {
        yield return new WaitForSeconds(0.4f);
        print("smoke");
        Destroy(gameObject);
    }
}
