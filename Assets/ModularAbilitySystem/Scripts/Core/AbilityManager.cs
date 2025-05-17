using System.Collections.Generic;
using UnityEngine;


namespace ModularAbilitySystems
{
public class AbilityManager : MonoBehaviour
{
    public List<MonoBehaviour> abilityComponents = new(); // Must implement IAbility

    private List<IAbility> abilities = new();

    void Awake()
    {
        foreach (var comp in abilityComponents)
        {
            if (comp is IAbility ability)
            {
                abilities.Add(ability);
            }
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && abilities.Count > 0)
            abilities[0].Activate(gameObject);

        if (Input.GetKeyDown(KeyCode.E) && abilities.Count > 1)
            abilities[1].Activate(gameObject);
        if (Input.GetMouseButtonDown(0) && abilities.Count > 2)
            abilities[2].Activate(gameObject);
    }
}
}