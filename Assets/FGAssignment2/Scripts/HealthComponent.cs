using UnityEngine;

namespace HealthSystem.Components
{
    public class HealthComponant : MonoBehaviour
    {
        public float maxHealth;
        [HideInInspector]
        public float currentHealth;

        private void Start()
        {
            currentHealth = maxHealth;
        }

        public virtual void Damage(float damage)
        {
            currentHealth = Mathf.Clamp(currentHealth - damage, 0, maxHealth);

            if (currentHealth <= 0)
            {
                //die
                Death();
            }

        }

        public virtual void Heal(float heal)
        {
            currentHealth = Mathf.Clamp(currentHealth + heal, 0, maxHealth);
        }

        public virtual void Death()
        {

        }
    }
}