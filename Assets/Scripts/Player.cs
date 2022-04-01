using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Projectile fireballPrefab;

    public float speed = 5.0f;

    private bool _fireballActive;

    private void Update()
    {
        if (Input.GetKey(KeyCode.A)) {
            this.transform.position += Vector3.left * this.speed * Time.deltaTime;
        } else if (Input.GetKey(KeyCode.D)) {
            this.transform.position += Vector3.right * this.speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space)) {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (!_fireballActive)
        {
            //only only projectile active at once
            Projectile projectile = Instantiate(this.fireballPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += FireballDestroyed;
            _fireballActive = true;
        }
    }

    private void FireballDestroyed()
    {
        _fireballActive = false;
    }

}
