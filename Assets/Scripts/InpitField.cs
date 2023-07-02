using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InpitField : MonoBehaviour
{
    public InputField inpufField;

        public void Write()
    {
        PersistanceManager.Instance.PlayerName = inpufField.text;
    }
}
