using UnityEngine;

namespace ModularAbilitySystems

{ 
    
public class HealAbility : MonoBehaviour, IAbility
    {
        public float healAmount = 20f;
        public float cooldown = 5f;
        public float manaCost = 15f;

        private float lastUsedTime = -999f;

        public string AbilityName => "Heal";

        public void Activate(GameObject user)
        {
            if (Time.time < lastUsedTime + cooldown)
            {
                Debug.Log("Heal is on cooldown!");
                return;
            }

            var mana = user.GetComponent<PlayerMana>();
            if (mana != null && !mana.SpendMana(manaCost)) return;

            var health = user.GetComponent<PlayerHealth>();
            if (health != null)
            {
                lastUsedTime = Time.time;
                health.Heal(healAmount);
            }
        }
    }
  }