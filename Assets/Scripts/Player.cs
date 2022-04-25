using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public PlayerProjectile fireballPrefab;

    public float speed = 5.0f;

    public bool _fireballActive;

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
            PlayerProjectile projectile = Instantiate(this.fireballPrefab, this.transform.position, Quaternion.identity);
            projectile.destroyed += FireballDestroyed;
            _fireballActive = true;
        }
    }

    public void FireballDestroyed()
    {
        _fireballActive = false;
    }

}
