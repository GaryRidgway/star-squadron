using System.Collections.Generic;

public static class ExtensionMethods {
 
    public static float Remap (this float value, float from1, float to1, float from2, float to2) {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    public static void fireWeapons(List<weapon> weapons) {
        foreach( weapon shipWeapon in weapons) {
            shipWeapon.toggleHoldFire();
        }
    }

    public static void setFireWeapons(List<weapon> weapons, bool doFire) {
        foreach( weapon shipWeapon in weapons) {
            shipWeapon.setHoldFire(doFire);
        }
    }
}