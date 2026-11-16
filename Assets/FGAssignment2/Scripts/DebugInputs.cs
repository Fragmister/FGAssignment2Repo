using HealthSystem.Components;
using UnityEngine;
using UnityEngine.InputSystem;

namespace HealthSystem.Debugging
{
    public class DebugInputs : MonoBehaviour
    {
        [SerializeField]
        HealthComponant healthComponant;
        public void DoSomeDamage(InputAction.CallbackContext context)
        {
            if (context.started)
            {
                if (healthComponant != null)
                {
                    healthComponant.Damage(10);
                }
                else
                {
                    Debug.LogError("Health component is null, place health component in debug inputs health components");
                }
            }
        }
    }
}