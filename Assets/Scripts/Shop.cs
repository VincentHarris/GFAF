using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint squirtGunPrefab;
    
    //public TurretBlueprint missileLauncher;

    BuildManager buildManager;

    void Start ()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret ()
    {
        Debug.Log ("Standard Turret Selected");
        buildManager.SelectTurretToBuild (standardTurret);
    }

    public void SelectSquirtGun()
    {
        Debug.Log ("Squirt Gun Selected");
        buildManager.SelectTurretToBuild(squirtGunPrefab);
    }

/* 
    public void SelectMissileLauncher ()
    {
        Debug.Log ("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
*/
}
