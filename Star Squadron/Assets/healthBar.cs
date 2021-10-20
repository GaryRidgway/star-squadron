using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBar : MonoBehaviour
{
    [SerializeField]
    private GameObject healthBarUIPrefab;
    [SerializeField]
    private Transform healthBarsContainer;
    [SerializeField]
    private Transform targetPosition;
    [SerializeField]
    private float maxHealth = 100f;
    [SerializeField]
    private float currentHealth = 100f;
    private GameObject healthBarUIElement;
    private Slider healthSlider;
    // Start is called before the first frame update
    void Start()
    {
        healthBarUIElement = Instantiate(healthBarUIPrefab, healthBarsContainer);
        currentHealth = maxHealth;
        healthSlider = healthBarUIElement.GetComponent<Slider>();
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 healthBarPosition = Camera.main.WorldToScreenPoint(targetPosition.position);
        if (healthBarPosition.z < 0) {
            healthBarPosition.x -= 100000f;
        }
        healthBarUIElement.transform.position = healthBarPosition;
    }

    public void damage(float damage) {
        currentHealth = Mathf.Max(currentHealth - damage, 0f);
        healthSlider.value = currentHealth;
    }
}
