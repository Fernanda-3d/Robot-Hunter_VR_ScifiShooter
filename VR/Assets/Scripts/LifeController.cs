using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public GameObject life1, life2, life3, life4, life5, life6, life7, life8, life9, life10;
    public static int health;

    // Start is called before the first frame update
    void Start()
    {
        health = 10;
        life1.gameObject.SetActive(true);
        life2.gameObject.SetActive(true);
        life3.gameObject.SetActive(true);
        life4.gameObject.SetActive(true);
        life5.gameObject.SetActive(true);
        life6.gameObject.SetActive(true);
        life7.gameObject.SetActive(true);
        life8.gameObject.SetActive(true);
        life9.gameObject.SetActive(true);
        life10.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (health > 10)
            health = 10;

        switch (health)
        {
            case 10:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(true);
                life5.gameObject.SetActive(true);
                life6.gameObject.SetActive(true);
                life7.gameObject.SetActive(true);
                life8.gameObject.SetActive(true);
                life9.gameObject.SetActive(true);
                life10.gameObject.SetActive(true);
                break;

            case 9:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(true);
                life5.gameObject.SetActive(true);
                life6.gameObject.SetActive(true);
                life7.gameObject.SetActive(true);
                life8.gameObject.SetActive(true);
                life9.gameObject.SetActive(true);
                life10.gameObject.SetActive(false);
                break;

            case 8:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(true);
                life5.gameObject.SetActive(true);
                life6.gameObject.SetActive(true);
                life7.gameObject.SetActive(true);
                life8.gameObject.SetActive(true);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 7:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(true);
                life5.gameObject.SetActive(true);
                life6.gameObject.SetActive(true);
                life7.gameObject.SetActive(true);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 6:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(true);
                life5.gameObject.SetActive(true);
                life6.gameObject.SetActive(true);
                life7.gameObject.SetActive(false);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 5:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(true);
                life5.gameObject.SetActive(true);
                life6.gameObject.SetActive(false);
                life7.gameObject.SetActive(false);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 4:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(true);
                life5.gameObject.SetActive(false);
                life6.gameObject.SetActive(false);
                life7.gameObject.SetActive(false);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 3:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(true);
                life4.gameObject.SetActive(false);
                life5.gameObject.SetActive(false);
                life6.gameObject.SetActive(false);
                life7.gameObject.SetActive(false);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 2:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(true);
                life3.gameObject.SetActive(false);
                life4.gameObject.SetActive(false);
                life5.gameObject.SetActive(false);
                life6.gameObject.SetActive(false);
                life7.gameObject.SetActive(false);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 1:
                life1.gameObject.SetActive(true);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                life4.gameObject.SetActive(false);
                life5.gameObject.SetActive(false);
                life6.gameObject.SetActive(false);
                life7.gameObject.SetActive(false);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

            case 0:
                life1.gameObject.SetActive(false);
                life2.gameObject.SetActive(false);
                life3.gameObject.SetActive(false);
                life4.gameObject.SetActive(false);
                life5.gameObject.SetActive(false);
                life6.gameObject.SetActive(false);
                life7.gameObject.SetActive(false);
                life8.gameObject.SetActive(false);
                life9.gameObject.SetActive(false);
                life10.gameObject.SetActive(false);
                break;

        }
    }
}
