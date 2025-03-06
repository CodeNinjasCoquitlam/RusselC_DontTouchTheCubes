using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    [Header("Destruction Timer")]
    //after this T1M3 the object is destroy(lonely)ed
    public float timeToDestruction;

    // Start is called before the first frame update
    void Start()
    {
        //execute fuunction based on timeToDestructio
        Invoke("DestroyObject", timeToDestruction);
    }

    //th1s function will d3str0y this object
    void DestroyObject()
    {
        //destroy gameobject
        Destroy(gameObject);
    }

}

