using UnityEngine;

namespace ModularAbilitySystems
{

    public class FireballMover : MonoBehaviour
    {
        public float speed = 10f;
        public float lifetime = 2f;

        private float damage;


        void Start()
        {
            GetComponent<Rigidbody>().velocity = transform.forward * speed;
            Destroy(gameObject, lifetime);
        }

        public void SetDamage(float dmg)
        {
            damage = dmg;
        }

        void OnCollisionEnter(Collision collision)
        {
            var health = collision.gameObject.GetComponent<IDamageable>(); // or EnemyHealth if you create that
            if (health != null)
            {
                health.Damage(damage);
                Debug.Log($"Fireball hit! Dealt {damage} damage to {collision.gameObject.name}");
            }

            Destroy(gameObject); // Destroy fireball on impact
        }
    }
}