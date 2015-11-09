using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class ItemSelection : MonoBehaviour {

    public Image SelectedImage;
    public Text WeaponName;
    public List<Sprite> ItemList = new List<Sprite>();

    private int position = 0;
    private GameObject gameob;
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}

    public void RightDirection()
    {
        if (position < ItemList.Count-1)
        {
            position++;
            SelectedImage.sprite = ItemList[position];
            WeaponName.text = PlayerController_new.Text;
        }

    }

    public void LeftDirection()
    {
        if (position > 0)
        {
            position--;
            SelectedImage.sprite = ItemList[position];
            
        }
    }
}

