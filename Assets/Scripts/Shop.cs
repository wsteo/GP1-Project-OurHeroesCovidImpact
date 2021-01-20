using UnityEngine;

public class Shop : MonoBehaviour
{
    public HeroesBlueprint Army;
    public HeroesBlueprint Doctor;
    public HeroesBlueprint Nurse;

    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void SelectSoldier()
    {
        Debug.Log("Bought Soldier");
        buildManager.SelectTurretToBuild(Army);
    }
    public void SelectDoctor()
    {
        Debug.Log("Bought Doctor");
        buildManager.SelectTurretToBuild(Doctor);
    }
    public void SelectNurse()
    {
        Debug.Log("Bought Nurse");
        buildManager.SelectTurretToBuild(Nurse);
    }
}
