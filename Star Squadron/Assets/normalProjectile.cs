using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class normalProjectile : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    [SerializeField]
    private float lifetime = 10f;
    [SerializeField]
    private string collisionTag = "Enemy";
    public Collider shipIgnoreCollider;
    public float damage;

    // Start is called before the first frame update
    void Start()
    {
        Physics.IgnoreCollision(shipIgnoreCollider, GetComponent<Collider>());
    }

    // Update is called once per frame
    void Update()
    {
        lifetime -= Time.deltaTime;
        if (lifetime <= 0) {
            Destroy(gameObject);
        }

        if (speed !=0) {
            transform.position += transform.forward * (speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision co) {
        if (co.gameObject.tag == collisionTag) {  
            speed = 0f;

            if (co.gameObject.TryGetComponent(out healthBar healthBar))
        {
            healthBar.damage(damage);
        }

            Destroy(gameObject);
        }
    }
}
