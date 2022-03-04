using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trailShoot : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 destination;
    public float shootTime = 3f;
    float lerpTime = 0;
    LineRenderer lineRenderer;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
        lineRenderer = GetComponent<LineRenderer>();
        Vector3[] positions = new Vector3[2];
        positions[0] = startPosition;
        positions[1] = destination;
        lineRenderer.SetPositions(positions);
        StartCoroutine("Fadeout");
    }

    public IEnumerator Fadeout()
    {
        while (shootTime > 0)
        {
            lineRenderer.startColor = new Color(1, 1, 1, shootTime);
            lineRenderer.endColor = new Color(1, 1, 1, shootTime);
            shootTime-= Time.deltaTime; 
            yield return new WaitForSeconds(Time.deltaTime);
        }
        
    }

    
}
