using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{

    public Vector3 direction;

    public float speed;

    public System.Action destroyed;
    public Player player;

    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    //when gameObject projectile collides with something, destroy

    private void OnTriggerEnter2D(Collider2D other)
    {
        player = GameObject.Find("Player").GetComponent<Player>();
        player._fireballActive = false;
        Destroy(this.gameObject);
    }
}
