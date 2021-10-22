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
    [SerializeField]
    private float fullAlphaDistance = 200f;
    [SerializeField]
    private float fadedAlphaDistance = 250f;
    [SerializeField]
    private float yPivotOffsetMin = -0.8f;
    [SerializeField]
    private float yPivotOffsetMax = -0.2f;
    [SerializeField]
    private float scaleMin = 0.8f;
    [SerializeField]
    private float scaleMax = 3f;
    private GameObject healthBarUIElement;
    private Slider healthSlider;
    private CanvasGroup alphaGroup;
    private RectTransform healthBarRectTransform;
    // Start is called before the first frame update
    void Start()
    {
        healthBarUIElement = Instantiate(healthBarUIPrefab, healthBarsContainer);
        currentHealth = maxHealth;
        healthSlider = healthBarUIElement.GetComponent<Slider>();
        alphaGroup = healthBarUIElement.GetComponent<CanvasGroup>();
        healthBarRectTransform = healthBarUIElement.GetComponent<RectTransform>();
        healthSlider.maxValue = maxHealth;
        healthSlider.value = currentHealth;
    }

    // Update is called once per frame
    void Update()
    {
        Camera cam = Camera.main;
        float healthBarDistance = Vector3.Distance(cam.transform.position, targetPosition.position);
        // Debug.Log(healthBarDistance);

        if (healthBarDistance <= fadedAlphaDistance) {
            Vector3 healthBarPosition = cam.WorldToScreenPoint(targetPosition.position);
            if (healthBarPosition.z < 0) {
                healthBarPosition.x -= 100000f;
            }
            healthBarUIElement.transform.position = healthBarPosition;

            alphaGroup.alpha = 1;

            pivotY(healthBarDistance);
            scale(healthBarDistance);
        }
        if(healthBarDistance > fullAlphaDistance && healthBarDistance <= fadedAlphaDistance) {
            float fadeDistance = fadedAlphaDistance - healthBarDistance;
            float alpha = fadeDistance.Remap(2f, fadedAlphaDistance - fullAlphaDistance, 0f, 1f);
            alphaGroup.alpha = alpha;

            pivotY(healthBarDistance);
            scale(healthBarDistance);
        }
    }

    public void damage(float damage) {
        currentHealth = Mathf.Max(currentHealth - damage, 0f);
        healthSlider.value = currentHealth;
    }

    void pivotY(float distance) {
        float pivotY = distance.Remap(0f, fadedAlphaDistance, yPivotOffsetMin, yPivotOffsetMax);
        healthBarRectTransform.pivot = new Vector2(0.5f, pivotY);
    }

    void scale(float distance) {
        float scale = distance.Remap(0f, fadedAlphaDistance, scaleMax, scaleMin);
        healthBarRectTransform.localScale = new Vector3(scale, scale, scale);
    }
}
