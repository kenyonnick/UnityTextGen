using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class TextGen3D : MonoBehaviour {
    public string text;
    TextGenLex lex;
    public float spacing;

	// Use this for initialization
	void Start () {
        
        
	}
	
	// Update is called once per frame
	void Update () {
        ClearText();
        GenerateText();
    }

    void ClearText()
    {
        for(int i = 0; i < transform.childCount; i++)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
    }

    void GenerateText()
    {
        // Grab the lex
        lex = FindObjectOfType<TextGenLex>();

        GameObject temp; // the game object for the letter
        GameObject parent = new GameObject(text); // Parent for the text
        parent.transform.parent = this.transform;

        for (int i = 0; i < text.Length; i++)
        {
            // Get the prefab for the letter
            temp = lex.GetCharacter(text[i]);

            if (temp != null)
            {
                // Setup letter position
                Vector3 pos = transform.position;
                pos.x += spacing * i;

                Instantiate(temp, pos, this.transform.rotation, parent.transform);
            }
        }
    }
}
