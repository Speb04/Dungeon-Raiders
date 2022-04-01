using UnityEngine;

public class Projectile : MonoBehaviour
{

    public Vector3 direction;

    public float speed;

    public System.Action destroyed;

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    //when gameObject projectile collides with something, destroy

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.destroyed.Invoke();
        Destroy(this.gameObject);
    }

}
