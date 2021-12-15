using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    [SerializeField] GameObject laserBeam1, laserBeam2, laserBeam3, laserBeam4;
    [SerializeField] Transform laserSpawnPoint;


    public void Fire()
    {
        //instantiate the laser beam
        GameObject generatedlaserBeam = Instantiate(laserBeam1, laserSpawnPoint.position, laserSpawnPoint.rotation);
        GameObject generatedlaserBeam2 = Instantiate(laserBeam2, laserSpawnPoint.position, laserSpawnPoint.rotation);
        GameObject generatedlaserBeam3 = Instantiate(laserBeam3, laserSpawnPoint.position, laserSpawnPoint.rotation);
        GameObject generatedlaserBeam4 = Instantiate(laserBeam4, laserSpawnPoint.position, laserSpawnPoint.rotation);

        Destroy(generatedlaserBeam, 2.0f);
        Destroy(generatedlaserBeam2, 2.0f);
        Destroy(generatedlaserBeam3, 2.0f);
        Destroy(generatedlaserBeam4, 2.0f);

        Debug.Log("Fire laser beam");
    }

   

}

