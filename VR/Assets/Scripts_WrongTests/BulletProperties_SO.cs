using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Bullet Property", menuName = "Fernanda - Bullet Property")]
public class BulletProperties_SO : ScriptableObject
{
    public Vector3 scale = new Vector3(1, 1, 1);
    public float speed = 1000;
    public int damage = 5;
}
