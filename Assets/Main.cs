using UnityEngine;
using System.Collections;
using JeuDames;

public class Main : MonoBehaviour {

    public JeuDame jeuDeDames;
	// Use this for initialization
	void Start () {
        this.jeuDeDames = new JeuDame();
        this.GenerateMap();

	}
	
	// Update is called once per frame
	void Update () {

        jeuDeDames.Update();
	}

    private void GenerateMap()
    {

        foreach (var item in jeuDeDames.plateauJeu.ListeCase)
        {
                string RessourcesToLoad = item.Resources;
                GameObject uneCase = Instantiate(Resources.Load(RessourcesToLoad)) as GameObject;
                uneCase.transform.position = new Vector3(item.Position.X * 10, 2, item.Position.Y * 10);

                GameObject unTank = Instantiate(Resources.Load("Tank")) as GameObject;
                unTank.transform.position = new Vector3(item.Position.X * 10, 2.5f, item.Position.Y * 10);
        }
    }
}
