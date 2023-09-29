using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System.Diagnostics;


namespace TransactionInvoiceApp
{
    class MongoDB
    {

        public  void Connect()
        {
            // Mongo DB를 위한 Connection String
            string connString = "mongodb://localhost:27017";

            // MongoClient 클라이언트 객체 생성
            MongoClient cli = new MongoClient(connString);

            MongoServer Server = cli.GetServer();
            // testdb 라는 데이타베이스 가져오기
            // 만약 해당 DB 없으면 Collection 생성시 새로 생성함
            MongoDatabase Database = Server.GetDatabase("Databases");

            // Daatabases 안에 Devices 라는 컬렉션(일종의 테이블)
            // 가져오기. 만약 없으면 새로 생성.
            var Devices = Database.GetCollection<Devices>("Devices");

            MongoCollection<Devices> collection = Database.GetCollection<Devices>("Devices");
          
            //SELECT - id로 검색
            IMongoQuery query = Query<Devices>.EQ(e => e.Id, kim);
            Devices e2 = collection.FindOne(query);

            //var result = Devices.Find(query).SingleOrDefault();
            //if (result != null)
            //{
            //    Console.WriteLine(result.ToString());
            //    }


            }

    }
    class Devices
    {
        // 이 Id는 MongoDB Collection의 _id 컬럼과 매칭됨
        // (예외적인 Naming Convention)
        public ObjectId Id { get; set; }

        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " " + Age;
        }
    }
}
