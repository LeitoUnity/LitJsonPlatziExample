using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;

public class ReadJson : MonoBehaviour
{
    private string jsonText;
    private JsonData itemData;
    private Weapon weapon;

    // Start is called before the first frame update
    void Start()
    {
        //jsonText = File.ReadAllText(Application.dataPath + "/Files/Items.json");

        //itemData = JsonMapper.ToObject(jsonText);

        //Debug.Log(itemData["Weapons"][1]["damage"]);

        weapon = new Weapon("Pistola Platzi", 20);

        itemData = JsonMapper.ToJson(weapon);

        File.WriteAllText(Application.dataPath + "/Files/weapon.json", itemData.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Weapon
{
    public string Name;
    public int Damage;

    public Weapon(string Name = "DefaultName", int Damage = 10)
    {
        this.Name = Name;
        this.Damage = Damage;
    }
}
