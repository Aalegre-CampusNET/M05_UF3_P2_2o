using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace M05_UF3_P2_Template.App_Code.Model
{
    public class Game
    {
        public int Id { get; set; }
        public int Product_Id { get; set; }
        public float Rating { get; set; }
        public string Version { get; set; }

        public Game()
        {

        }
        public Game(DataRow row)
        {

        }
        public Game(int id) : this(DatabaseManager.Select("Game", null, "Id = " + id + " ").Rows[0]) { }

        public void Update()
        {

        }
        public void Add()
        {

        }
    }
}
