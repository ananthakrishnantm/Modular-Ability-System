using UnityEngine;

namespace ModularAbilitySystems
{

    public class PlayerMana : MonoBehaviour
    {
        public float maxMana = 100f;
        public float currentMana = 100f;

        void Start()
        {
            currentMana = maxMana;
        }

        public bool SpendMana(float amount)
        {
            if (currentMana >= amount)
            {
                currentMana -= amount;
                Debug.Log($"Mana spent: {amount}. Remaining mana: {currentMana}");
                return true;
            }

            Debug.Log("Not enough mana!");
            return false;
        }
        //regenerate can be called to regenerate mana over time
        public void RegenerateMana(float amount)
        {
            currentMana = Mathf.Min(currentMana + amount, maxMana);
            Debug.Log($"Mana regenerated: {amount}. Current mana: {currentMana}");
        }
    }

}
