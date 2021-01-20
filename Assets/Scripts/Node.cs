using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color noMoneyColour;
    public Vector3 positionOffset;

    [Header("Optinal")]
    public GameObject turret;

    private Renderer rend;
    private Color startColor;

    BuildManager buildManager;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    private void OnMouseDown()
    {
        if (buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build here! TODO: Display on Screen");
            return;
        }

        buildManager.BuildHeroesOnNode(this);
    }

    private void OnMouseEnter()
    {
        if (buildManager.CanBuild)
            return;

        if(buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = noMoneyColour;
        }
        

    }

    private void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
