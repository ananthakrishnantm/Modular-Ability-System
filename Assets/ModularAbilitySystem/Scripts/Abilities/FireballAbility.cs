using UnityEngine;

namespace ModularAbilitySystems

{
    public class FireballAbility : MonoBehaviour, IAbility
    {
        public GameObject fireballPrefab;
        public float spawnDistance = 1f;

        public float damage = 25f;
        public float cooldown = 1f;
        public float manaCost = 20f;
        private float lastUsedTime = -999f;

        public string AbilityName => "Fireball";

        public void Activate(GameObject user)
        {
            if (fireballPrefab == null)
            {
                Debug.LogWarning("No fireball prefab assigned!");
                return;
            }

            if (Time.time < lastUsedTime + cooldown)
            {
                Debug.Log("Fireball is on cooldown!");
                return;
            }

            var mana = user.GetComponent<PlayerMana>();
            if (mana != null && !mana.SpendMana(manaCost)) return;

            lastUsedTime = Time.time;

            Vector3 spawnPos = user.transform.position + user.transform.forward * spawnDistance;
            Quaternion spawnRot = user.transform.rotation;

            GameObject fireball = GameObject.Instantiate(fireballPrefab, spawnPos, spawnRot);

            fireball.GetComponent<FireballMover>().SetDamage(damage);
        }
    }
}
