using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inflate : MonoBehaviour
{

    [SerializeField] GameObject inflateForGun;
    [SerializeField] GameObject inflatetext;


    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
        this.gameObject.GetComponent<SphereCollider>().enabled = true;

        inflateForGun.GetComponent<SphereCollider>().enabled = false;        
    }

    private void OnCollisionEnter(Collision collision)
    {
        inflateForGun.GetComponent<SphereCollider>().enabled = true;

        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<SphereCollider>().enabled = false;
        inflatetext.SetActive(false);
    }


}
