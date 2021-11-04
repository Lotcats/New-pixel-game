using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewRoomGen : MonoBehaviour
{
    private RoomTemplates rooms;
    private int rand;
    private int spawnedrooms;

    private void Start()
    {
        rooms = GameObject.Find("RoomTemplate").GetComponent<RoomTemplates>();
        if (RoomTemplates.Instance.roomAmount < 5)
            // if you want more or less rooms to spawn, change the number for the roomAmount above!
        {
            spawnRooms();
        }
        else
        {
            EndRooms();
        }
    }

    void spawnRooms()
    {
        rand = Random.Range(0, rooms.Rooms.Length);
        Instantiate(rooms.Rooms[rand], transform.position, rooms.Rooms[rand].transform.rotation);
        RoomTemplates.Instance.roomAmount++;
        Debug.Log(RoomTemplates.Instance.roomAmount);
    }
    void EndRooms()
    {
        Instantiate(rooms.EndRoom, transform.position, rooms.EndRoom.transform.rotation);
    }
}