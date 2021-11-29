using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Land : MonoBehaviour
{
    public bool canInteract = true;
    public Timer timer;
    public enum LandStatus
    {
        Soil, Farmland, Watered
    }
    public LandStatus landStatus;
    public Material soilMat, farmlandMat, wateredMat;
    new Renderer renderer;

    //The player is selecting the objects
    public GameObject select;

    void Start()
    {
        renderer = GetComponent<Renderer>();
     //set Soil as default
        SwitchLandStatus(LandStatus.Soil);
    }

  public void SwitchLandStatus (LandStatus statusToSwitch)
    {
        landStatus = statusToSwitch;
        Material materialToSwitch = soilMat;
        //What material it changes to
        switch (statusToSwitch)
        {
            //When its true the LandStatus changes
            case LandStatus.Soil:
                materialToSwitch = soilMat;
  
                break;

            case LandStatus.Farmland:
                materialToSwitch = farmlandMat;
              
                break;

            case LandStatus.Watered:
                materialToSwitch = wateredMat;
           
                break;

        }

        //get renderer to apply
        renderer.material = materialToSwitch;
    }
  public void Select(bool toggle)
    {
        select.SetActive(toggle);
    }


    //It the computer kmows if the player is standing in a harvestable land
    public void Interact()
    {
        if (canInteract == true )
        {

            if (landStatus == LandStatus.Soil)
            {
                SwitchLandStatus(LandStatus.Farmland);
                canInteract = false;
                timer.TimerUp();
            }


            else if (landStatus != LandStatus.Soil && landStatus == LandStatus.Farmland)
            {
                SwitchLandStatus(LandStatus.Watered);
                canInteract = false;
                timer.TimerUp();
            }
        }
        //else if (canInteract == true && seed2)
       

        else
        { }


    }
}