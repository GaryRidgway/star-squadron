using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private Transform firePoint;
    [SerializeField]
    private Transform projectiles;
    [SerializeField]
    private float heat = 0f;
    [SerializeField]
    private float maxheat = 10f;
    [SerializeField]
    private float heatPerRound = 1f;
    [SerializeField]
    private float heatReducePerSecond = 1f;
    [SerializeField]
    private bool mandatoryCooldown = false;

    public void Update() {
        heat = Mathf.Max(heat - (heatReducePerSecond * Time.deltaTime), 0f) ;

        if(heat > maxheat) {
            mandatoryCooldown = true;
        }

        if (mandatoryCooldown && heat == 0f) {
            mandatoryCooldown = false;
        }
    }

    public void fireProjectile() {
        if (heat < maxheat && !mandatoryCooldown) {
            GameObject firedProjectile = Instantiate(projectile, projectiles);
            firedProjectile.transform.position = firePoint.position;
            firedProjectile.transform.rotation = firePoint.rotation;
            heat += heatPerRound;
        }
    }
}
