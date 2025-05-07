using UnityEngine;
    using TMPro;
using UnityEngine.UIElements;
using UnityEngine.Animations;

public class UIController : MonoBehaviour
{
  
    public TMP_Text text;
    public GameObject Panel;
    public GameObject Panel2;
   public void DeactivatePanel()
    {
        Panel.SetActive(false);
        Panel2.SetActive(true);
    }





    void Update()
    {
        
    }
}
