using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using System.Text;

public class DataLoader 
{
    private string filePath = Application.persistentDataPath + "/data.txt";

    public Dictionary<String, float> dateToHours = new Dictionary<string, float>();

    string fileSplitString = "***";

    public DataLoader()
    {
        //Debug.Log(filePath);
        if (File.Exists(filePath))
        {
            //file exists so load it in
            Debug.Log("Found file");
            LoadData();
            
        }
        else
        {
            //create file
            Debug.Log("Could not find file");
            File.Create(filePath);
        }
    }

    private void LoadData()
    {
        using (StreamReader sr = File.OpenText(filePath))
        {
            string s = String.Empty;
            while ((s = sr.ReadLine()) != null)
            {
                String[] strings = s.Split(fileSplitString);
                String date = strings[0];
                float hours = float.Parse(strings[1]);
                dateToHours.Add(date, hours);
            }
        }
    }

    public void UpdateData()
    {
        using (StreamWriter writetext = new StreamWriter(filePath))
        {
            //writetext.WriteLine("writing in text file");
            foreach (KeyValuePair<string, float> entry in dateToHours)
            {
                string s = entry.Key + fileSplitString + entry.Value;
                writetext.WriteLine(s);
            }
        }
    }
}
