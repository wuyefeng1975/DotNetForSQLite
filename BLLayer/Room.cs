using System;
using System.Collections.Generic;
using System.Data;
using Project_02_YefengWu.DBLayer;

namespace Project_02_YefengWu.BLLayer
{
    public class Room
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Room( string Name )
        {
            DataRowValueToProperty(RoomDB.GetOne(Name));
        }

        public Room(int ID)
        {
            DataRowValueToProperty(RoomDB.GetOne(ID));
        }

        private Room(DataRow dr)
        {
            DataRowValueToProperty(dr);
        }

        public static List<Room> GetAll()
        {
            List<Room> rooms = new List<Room>();
            DataRowCollection rows = RoomDB.GetAll();
            foreach (DataRow row in rows)
            {
                Room room = new Room(row);
                rooms.Add(room);
            }
            
            return rooms;
        }

        private void DataRowValueToProperty(DataRow dr)
        {
            ID = Convert.ToInt32(dr["ID"]);
            Name = dr["Name"].ToString();
            Price = Convert.ToDouble(dr["Price"]);
        }
    }
}
