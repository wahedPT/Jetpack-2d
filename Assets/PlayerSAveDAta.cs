using UnityEngine;
using System.IO;
//using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.UI;

public class PlayerSAveDAta : MonoBehaviour
{
    public string playerName;
    public string PalyerBirth;
    public string Region;
    // public Score lastscore;
    // Start is called before the first frame update
    void Start()
    {
        //lastscore = GameObject.Find("ScoreManager").GetComponent<Score>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void SetData()
    {
        //string path = Application.persistentDataPath + "/GamePdata.file";
        string path = Application.persistentDataPath + "/PlayerDetail.file";
        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
        BinaryWriter bw = new BinaryWriter(fs);
        bw.Write("Player Name : " + playerName);
        bw.Write("Player Gender : " + PalyerBirth);
        bw.Write("Region : " + Region);
        //bw.Write("Score is : " + lastscore.
        bw.Close();
        fs.Close();
    }
    public void GetData()
    {
        string path = Application.persistentDataPath + "/PlayerDetail.file";
        FileStream fs = new FileStream(path, FileMode.Open);
        BinaryReader br = new BinaryReader(fs);
        br.ReadString();
        br.Close();
        fs.Close();
    }
}
