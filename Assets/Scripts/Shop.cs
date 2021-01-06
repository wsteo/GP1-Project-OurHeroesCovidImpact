using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseSoldier()
    {
        Debug.Log("Bought Soldier");
        buildManager.SetTurretToBuild(buildManager.Army);
    }
    public void PurchaseDoctor()
    {
        Debug.Log("Bought Doctor");
        buildManager.SetTurretToBuild(buildManager.Doctor);
    }
    public void PurchaseNurse()
    {
        Debug.Log("Bought Nurse");
        buildManager.SetTurretToBuild(buildManager.Nurse);
    }
}
