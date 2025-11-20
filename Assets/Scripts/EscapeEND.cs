using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EscapeEND : MonoBehaviour
{
    public StopWatch stopWatch;
    public bool isInside;
    public Slider fuelSlider;
    public Animator anim;
    public GameObject tmpro;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("SpaceShuttle"))
        {
            isInside = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("SpaceShuttle"))
        {
            isInside = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isInside && fuelSlider.value >= 19f)
        {
            stopWatch.stopwatchActive = false;
            anim.SetTrigger("end");
            StartCoroutine(Finish());
        }
    }

    IEnumerator Finish()
    {
        yield return new WaitForSeconds(1.2f);
        tmpro.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
