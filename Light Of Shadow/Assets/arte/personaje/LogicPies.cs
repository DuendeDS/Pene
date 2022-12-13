using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicPies : MonoBehaviour
{
    public LogicPersona logicPersona;
   
    private void OnTriggerStay(Collider other)
    {
        logicPersona.puedoSaltar = true;
    }
    private void OnTriggerExit(Collider other)
    {
        logicPersona.puedoSaltar = false;
    }
}
