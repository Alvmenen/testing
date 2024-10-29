using UnityEngine;
using TMPro; 


public class EsferaCollider : MonoBehaviour
{
    public TextMeshProUGUI myText; 
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Obstaculo")
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.tag == "Obstaculo2")
        {
            myText.text = "se acabo la fiesta"; 
        }
    }
         
}
