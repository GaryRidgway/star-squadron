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
    private Collider shipIgnoreCollider;
    [SerializeField]
    private float weaponDamage = 10f;
    [SerializeField]
    private float heat = 0f;
    [SerializeField]
    private float maxheat = 10f;
    [SerializeField]
    private float heatPerRound = 1f;
    [SerializeField]
    private float heatReducePerSecond = 3f;
    [SerializeField]
    private bool mandatoryCooldown = false;
    [SerializeField]
    private float fireRate = 6f;
    private bool holdFire = false;
    private float timeToFire = 0;

    public void Update() {
        heat = Mathf.Max(heat - (heatReducePerSecond * Time.deltaTime), 0f) ;

        if(heat > maxheat) {
            mandatoryCooldown = true;
        }

        if (mandatoryCooldown && heat == 0f) {
            mandatoryCooldown = false;
        }

        if (holdFire && Time.time >= timeToFire) {
            fireProjectile();
            timeToFire = Time.time + 1/fireRate;
        }
    }

    public void fireProjectile() {
        if (heat < maxheat && !mandatoryCooldown) {
            GameObject firedProjectile = Instantiate(projectile, projectiles);
            firedProjectile.transform.position = firePoint.position;
            firedProjectile.transform.rotation = firePoint.rotation;
            normalProjectile nProjectile = firedProjectile.GetComponent<normalProjectile>();
            nProjectile.shipIgnoreCollider = shipIgnoreCollider;
            nProjectile.damage = weaponDamage;
            heat += heatPerRound;
        }
    }

    public void toggleHoldFire() {
        holdFire = holdFire ? false : true;
    }

    public void setHoldFire(bool doFire) {
        holdFire = doFire;
    }
}
