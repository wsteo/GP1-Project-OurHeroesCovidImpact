using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;
   void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }
        instance = this;
    }

    public GameObject ArmyPrefab;
    public GameObject DoctorPrefab;
    public GameObject NursePrefab;

    private HeroesBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild == null; } }

    public void BuildHeroesOnNode(Node node)
    {
        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;
    }

    public void SelectTurretToBuild(HeroesBlueprint turret)
    {
        turretToBuild = turret;
    }
}
