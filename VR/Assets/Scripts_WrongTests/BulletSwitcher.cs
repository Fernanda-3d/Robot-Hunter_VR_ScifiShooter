using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSwitcher : MonoBehaviour
{
    public BulletProperties_SO changeToTheseProperties;
    public GameObject gun;

    private void Start()
    {
        gun.GetComponent<FireGun>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Something entered the trigger");
        if (other.CompareTag("Player"))
        {
            Debug.Log("The Player entered the trigger");
           // gun.currentBulletProperties = changeToTheseProperties;
            Debug.Log(gun.name);
          //  Debug.Log(gun.currentBulletProperties);
            Debug.Log(changeToTheseProperties);
        }

    }
}
