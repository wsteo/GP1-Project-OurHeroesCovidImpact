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

    public GameObject buildEffect;

    private HeroesBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild == null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildHeroesOnNode(Node node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect =  (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 3f);
    }

    public void SelectTurretToBuild(HeroesBlueprint turret)
    {
        turretToBuild = turret;
    }
}
