using UnityEngine;
using UnityEngine.EventSystems;


public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;
    
    [Header("Optional")]
    public GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color; //needs to be below rend or else it won't work
        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition ()
    {
        return transform.position + positionOffset;
    }

    void OnMouseDown ()
    {
         //taken from unity docs
      if(EventSystem.current.IsPointerOverGameObject())
        return;

        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build there GLV! - TODO: Display on screen.");
            return;
        }

       buildManager.BuildTurretOn(this);
    }

    //Callback from Unity doc page
  void OnMouseEnter () 
  {
      //taken from unity docs
      if(EventSystem.current.IsPointerOverGameObject())
        return;

      if (!buildManager.CanBuild)
            return;

      if(buildManager.HasMoney)
      {
          rend.material.color = hoverColor;
      } else {
          rend.material.color = notEnoughMoneyColor;
      }

     
  }

  void OnMouseExit ()
  {
      rend.material.color = startColor;
  }
}
