using UnityEngine;

public class BatScript : MonoBehaviour
{

    public System.Action killed;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Fireball")) {
            this.killed.Invoke();
            this.gameObject.SetActive(false);
        }
    }

}
