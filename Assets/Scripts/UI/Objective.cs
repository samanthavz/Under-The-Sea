using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Objective : MonoBehaviour
{

    [SerializeField]
    GameObject text;

    public void SetObjective(string objectiveText)
    {
        text.SetActive(true);
        text.GetComponent<TextMeshProUGUI>().text = objectiveText;
    }
}
