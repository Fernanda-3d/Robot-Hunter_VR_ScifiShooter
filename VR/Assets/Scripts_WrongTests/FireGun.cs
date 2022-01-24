using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    
    public BulletProperties_SO currentBulletProperties;
  

    [SerializeField] GameObject laserBeam1, laserBeam2, laserBeam3;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform laserSpawnPoint;
   

    public void Fire()
    {
       
        //instantiate the laser beam
        GameObject generatedlaserBeam = Instantiate(laserBeam1, laserSpawnPoint.position, laserSpawnPoint.rotation);
        GameObject generatedlaserBeam2 = Instantiate(laserBeam2, laserSpawnPoint.position, laserSpawnPoint.rotation);
        GameObject generatedlaserBeam3 = Instantiate(laserBeam3, laserSpawnPoint.position, laserSpawnPoint.rotation);

        GameObject generatedbullet = Instantiate(bullet, laserSpawnPoint.position, laserSpawnPoint.rotation);
        generatedbullet.GetComponent<LaserMove>().myProperties = generatedbullet.GetComponent<LaserMove>().myProperties;

      /*
        Destroy(generatedlaserBeam, 2.0f);
        Destroy(generatedlaserBeam2, 2.0f);
        Destroy(generatedlaserBeam3, 2.0f);
        Destroy(generatedbullet, 2.0f); */


    }

   

}

