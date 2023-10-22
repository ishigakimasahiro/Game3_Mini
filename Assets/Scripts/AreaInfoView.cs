using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AreaInfoView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI currentNumberText;
    [SerializeField] private TextMeshProUGUI subInfoText;

    public TextMeshProUGUI CurrentNumberText => currentNumberText;
    public TextMeshProUGUI SubInfoText => subInfoText;
}
