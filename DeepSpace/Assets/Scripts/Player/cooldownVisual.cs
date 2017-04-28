using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cooldownVisual : MonoBehaviour {

    public Text Timer;
    int timerCountDown;
   
    public GameObject playerShip;
    public int CoolDownPlaceMent = 0;
    // Use this for initialization
   /* void Start()
    {
        Timer = GetComponent<Text>();
    }
    */
    // Update is called once per frame
    void Update()
    {
        ConstructionScript construct = (ConstructionScript)playerShip.GetComponent<ConstructionScript>();
      //  timerCountDown = Mathf.Floor((float)construct.GetConstructTime(CoolDownPlaceMent)).ToString();
        Timer.text = Mathf.Floor((float)construct.GetConstructTime(CoolDownPlaceMent)).ToString();
    }
}
