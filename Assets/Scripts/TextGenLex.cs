using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextGenLex : MonoBehaviour {
	public TextGenLexEntry[] lex;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public GameObject GetCharacter(char c)
    {
        GameObject ret = null; // returned game object

        for(int i = 0; i < lex.Length; i++)
        {
            if(lex[i].character == c)
            {
                ret = lex[i].prefab;
                break;
            }
        }
        return ret;
    }
}

[System.Serializable]
public struct TextGenLexEntry
{
    public GameObject prefab;
    public char character;
}
