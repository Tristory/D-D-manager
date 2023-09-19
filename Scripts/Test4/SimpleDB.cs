using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;

public class SimpleDB : MonoBehaviour
{
    private string dbName = "URI=file:Inventory.db";
    
    // Start is called before the first frame update
    void Start()
    {
        CreateDB();
        AddWeapon("Silver sword", 30);
        DisplayWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateDB()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "CREATE TABLE IF NOT EXISTS weapons (name VARCHAR(20), damage INT);";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public void AddWeapon(string weaponName, int weaponDamage)
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "INSERT INTO weapons (name, damage) VALUES ('" + weaponName + "', '" + weaponDamage + "');";
                command.ExecuteNonQuery();
            }

            connection.Close();
        }
    }

    public void DisplayWeapon()
    {
        using (var connection = new SqliteConnection(dbName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT * FROM weapons;";
                
                using (IDataReader reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        Debug.Log("Name: " + reader["name"] + "\tDamage: " + reader["damage"]);                        
                    }

                    reader.Close();
                }
            }

            connection.Close();
        }
    }
}


