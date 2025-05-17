using UnityEngine;

namespace ModularAbilitySystems

{
    public class DashAbility : MonoBehaviour, IAbility
    {
        public float dashDistance = 5f;

        public float cooldown = 3f;
        public float manaCost = 0f;

        private float lastUsedTime = -999f;

        public string AbilityName => "Dash";

        public void Activate(GameObject user)
        {

            if (Time.time < lastUsedTime + cooldown)
            {
                Debug.Log("Dash is on cooldown!");
                return;
            }

            var mana = user.GetComponent<PlayerMana>();
            if (mana != null && !mana.SpendMana(manaCost)) return;

            lastUsedTime = Time.time;
            user.transform.position += user.transform.forward * dashDistance;
            Debug.Log("Dash Activated!");
        }
    }
}
