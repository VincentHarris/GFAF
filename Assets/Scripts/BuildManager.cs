using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        if(instance !=null)
        {
            Debug.LogError ("More than one BuildManager in scene");
            return;
        }

        //everytime we start the game this build manager is gonna be put into the instance variable
        //this instance variable is accessible from anywhere
        instance = this;
    }

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;

    private TurretBlueprint turretToBuild;

    public bool CanBuild {get {return turretToBuild != null; }}
    public bool HasMoney {get {return PlayerStats.Money >= turretToBuild.cost; }}

    public void BuildTurretOn (Node node) 
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log ("You're too broke to build that, GLV!!");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        Debug.Log ("Turret built! Money left: "+ PlayerStats.Money);
    }

    public void SelectTurretToBuild ( TurretBlueprint turret)
    {
        turretToBuild = turret;
    }


}
