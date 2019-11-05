using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standardTurret;
    public TurretBlueprint anotherTurret;
    
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

    public void SelectAnotherTurret ()
    {
        Debug.Log ("Another Turret Selected");
        buildManager.SelectTurretToBuild(anotherTurret);
    }

/* 
    public void SelectMissileLauncher ()
    {
        Debug.Log ("Missile Launcher Selected");
        buildManager.SelectTurretToBuild(missileLauncher);
    }
*/
}
