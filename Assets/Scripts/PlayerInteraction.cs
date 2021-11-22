using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    Movement movement;

    Land selectedLand = null;

    // Start is called before the first frame update
    void Start()
    {
    //gives access to the movement 
        movement = transform.parent.GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(transform.position, Vector3.down,out hit, 1))
        {
            OnInteractableHit(hit);
        }
    }
    void OnInteractableHit(RaycastHit hit)
    {
        Collider other = hit.collider;
       
        if(other.tag == "Land")
        {
            Land land = other.GetComponent<Land>();
            selectLand(land);
            return;
        }
        //unselecting the land when the player is not on it
        if(selectedLand != null)
        {
            selectedLand.Select(false);
            selectedLand = null;
        }
    }

    void selectLand(Land land)
    {
        if (selectedLand != null)
        {
            selectedLand.Select(false);
        }
    //selects work
        selectedLand = land;
        land.Select(true);
    }
}
