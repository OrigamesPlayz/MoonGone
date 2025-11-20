using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelCollect : MonoBehaviour
{
    public OutlinerScript outliner;
    public Slider fuelBarSlider;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && outliner.CurrentOutlinedObject != null)
        {
            Destroy(outliner.CurrentOutlinedObject);
            fuelBarSlider.value = fuelBarSlider.value + 2;
        }
    }
}
