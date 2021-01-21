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
        buildManager.SelectTurretToBuild(Army);
    }
    public void SelectDoctor()
    {
        buildManager.SelectTurretToBuild(Doctor);
    }
    public void SelectNurse()
    {
        buildManager.SelectTurretToBuild(Nurse);
    }
}
