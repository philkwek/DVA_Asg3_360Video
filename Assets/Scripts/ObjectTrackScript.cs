using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectTrackScript : MonoBehaviour
{

    public Image testImage;
    public GameObject canvasParent;

    private Image uiUse;
    private MeshRenderer mesh;
    public Camera mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        DisplayInteractUI();
        mesh = gameObject.GetComponent<MeshRenderer>();
        mesh.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        uiUse.transform.position = mainCamera.WorldToScreenPoint(gameObject.transform.position);
    }

    private void DisplayInteractUI() //Displays or Hides UI to indicate object can be interacted with
    {
        Destroy(uiUse);

        uiUse = Instantiate(testImage, FindObjectOfType<Canvas>().transform).GetComponent<Image>();
    }
}
