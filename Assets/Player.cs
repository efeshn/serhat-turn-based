using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int hp;
    public Transform fireBullet;

    public void TakeDamage(int damage)
    {
        hp -= damage;
    }

    public void FireBall()
    {
        var bullet = Instantiate(fireBullet);
        bullet.transform.position = transform.position;
    }
}
