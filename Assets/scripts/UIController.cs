using UnityEngine;
    using TMPro;

public class UIController : MonoBehaviour
{
    public GameObject avatarImage;
    public TMP_Text text;   
   public void DeactivateImage()
    {
        avatarImage.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
