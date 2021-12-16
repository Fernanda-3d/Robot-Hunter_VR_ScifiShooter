using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSwitcher : MonoBehaviour
{
    public BulletProperties_SO changeToTheseProperties ;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            other.GetComponent<LaserMove>().myProperties = changeToTheseProperties;
        }
    }
}
