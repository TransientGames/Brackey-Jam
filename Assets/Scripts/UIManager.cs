using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Text _targetText;

    private void Awake()
    {
        _targetText = GameObject.Find("TargetText").GetComponent<Text>();
    }

    public void UpdateTargetText(string txt)
    {
        _targetText.text = txt;
    }
}
