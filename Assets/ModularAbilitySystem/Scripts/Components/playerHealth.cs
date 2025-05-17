using UnityEngine;

namespace ModularAbilitySystems

{
 
 
public class PlayerHealth : MonoBehaviour, IDamageable
    {
        public float maxHealth = 100f;
        public float currentHealth = 100f;

        void Start()
        {
            currentHealth = maxHealth;
        }

        public void Heal(float amount)
        {
            currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
            Debug.Log($"[PlayerHealth] Healed {amount}, current HP: {currentHealth}");
        }

        public void Damage(float amount)
        {
            currentHealth = Mathf.Max(currentHealth - amount, 0);
            Debug.Log($"[PlayerHealth] Took {amount} damage, current HP: {currentHealth}");

            if (currentHealth <= 0)
            {
                Debug.Log("[PlayerHealth] Player died!");
            }
        }
    }
   
}