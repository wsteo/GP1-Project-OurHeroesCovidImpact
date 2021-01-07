using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    public GameObject heroPrefab;
    private GameObject hero;

    private bool CanPlaceHero(){
        return hero == null;
    }

    private void OnMouseUp() {
        if(CanPlaceHero()){
            hero = (GameObject)
                Instantiate(heroPrefab,transform.position,Quaternion.identity);
        }
    }
}
