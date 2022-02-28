using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAferTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("DestroyGameObject", 2f);
    }

    // Update is called once per frame
    void DestroyGameObject()
    {
        Destroy(gameObject);
    }
}
