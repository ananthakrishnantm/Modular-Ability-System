

namespace ModularAbilitySystems
{
    
public interface IAbility
    {
        string AbilityName { get; }
        void Activate(UnityEngine.GameObject user);
    }
}