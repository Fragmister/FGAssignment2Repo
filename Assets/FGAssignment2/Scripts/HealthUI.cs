using UnityEngine;
using HealthSystem.Components;
using UnityEngine.UI;
public class HealthUI : MonoBehaviour
{
    [SerializeField]
    HealthComponant healthComponant;
    [SerializeField]
    Image healthBar, delayedBar;



    private void Update()
    {
        float healthpercent = healthComponant.currentHealth / healthComponant.maxHealth;
        healthBar.fillAmount = healthpercent;
        delayedBar.fillAmount = Mathf.Lerp(delayedBar.fillAmount, healthpercent, Time.deltaTime);
    }
}
