using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace ArcoMage
{
    public class DataAccess
    {
        public List<DBCard> GetAllDBCards()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("ArcomageDB")))
            {
                //return connection.Query<DBCard>($"select * from Cards").ToList();//$"select * from Cards where CardName = '{ "Brian" }'"
                return connection.Query<DBCard>("dbo.spCards_GetAll").ToList();
            }
        }
        public DBCard GetCardByIdDBCards(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("ArcomageDB")))
            {
                return connection.Query<DBCard>("dbo.spCards_GetById @CardId", new { CardId = Id }).FirstOrDefault();
            }
        }
        public DBCard GetCardBynameDBCards(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("ArcomageDB")))
            {
                return connection.Query<DBCard>("dbo.spCards_GetByName @CardName", new { CardName = name }).FirstOrDefault();
            }
        }
        public void AddCard(string cardName, string costType, string description, string imageName, int costAmount)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DBHelper.CnnVal("ArcomageDB")))
            {
                connection.Query<DBCard>("dbo.spCards_AddCard @CardName, @CostType, @Description, @ImageName, @CostAmount ", new { CardName = cardName, CostType = costType, Description = description, ImageName = imageName, CostAmount = costAmount }).FirstOrDefault();
            }
        }
    }
}
