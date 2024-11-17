using UnityEngine;
using UnityEngine.UI;

public class ScrollViewManager : MonoBehaviour
{
    public GameObject content;  
    public GameObject textPrefab;  

    public void AddText(string newText)
    {
        // Instantiate the text prefab as a child of the content GameObject
        GameObject newTextObject = Instantiate(textPrefab, content.transform);

        // Set the text on the Text component
        Text textComponent = newTextObject.GetComponent<Text>();
        textComponent.text = newText;

        // Optionally adjust styling dynamically
        textComponent.color = Color.black; // Example: set text color to black
    }
}
