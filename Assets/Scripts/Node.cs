using UnityEngine;

public class Node : MonoBehaviour
{
    public Color hoverColor;
    public Color noMoneyColour;
    public Vector3 positionOffset;

    [Header("Optinal")]
    public GameObject turret;

    private SpriteRenderer rend;
    private Color startColor;

    BuildManager buildManager;

    private void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        startColor = rend.color;

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
            return;
        }

        buildManager.BuildHeroesOnNode(this);
    }

    private void OnMouseEnter()
    {
        if (buildManager.CanBuild)
            return;

        if (buildManager.HasMoney)
        {
            rend.color = hoverColor;
        }
        else
        {
            rend.color = noMoneyColour;
        }


    }

    private void OnMouseExit()
    {
        rend.color = startColor;
    }
}
