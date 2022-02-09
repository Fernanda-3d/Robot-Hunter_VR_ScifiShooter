using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterDissolveMovement : MonoBehaviour
{
    [SerializeField] Transform[] points;
    int pointIndex = 0;
    bool isMoving = false;
    [SerializeField] SkinnedMeshRenderer[] renderer;

    void Start()
    {
        if (points.Length == 0)
        {
            Debug.LogWarning("0 points");
            return;
        }

        transform.position = points[0].position;
    }

   
    void Update()
    {
        if (!isMoving )
        {
            StartCoroutine(Move());
        }
    }

    IEnumerator Move()
    {
        isMoving = true;
        int lastPoint = pointIndex;
        pointIndex = (pointIndex + 1) % points.Length;

        //start
        float dissolveTime = 0; 

        while (dissolveTime <= 1f)
        {
            for (int i = 0; i < renderer.Length; i++)
            {
                renderer[i].sharedMaterial.SetFloat("DissolveTime", dissolveTime);
            }
            dissolveTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        //movement
        float path = 0;
        while (path <= 1f)
        {
            transform.position = Vector3.Lerp(points[lastPoint].position, points[pointIndex].position, path);
            path += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }

        while (dissolveTime >= 0f)
        {
            for (int i = 0; i < renderer.Length; i++)
            {
                renderer[i].sharedMaterial.SetFloat("DissolveTime", dissolveTime);
            }
            dissolveTime -= Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        isMoving = false;

    }
}
