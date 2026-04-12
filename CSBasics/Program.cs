using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using static CSBasics.Program;

namespace CSBasics
{
    public class Furniture
    {
        public int m_furnitureID;
        public string m_furnitureName;
        public string m_furnitureDescription;

        public void InitFurnitureInfo()
        {
            m_furnitureID = 0;
            m_furnitureName = string.Empty;
            m_furnitureDescription = string.Empty;

        }

    }

    public class FurnitureStore
    {
        public Dictionary<string, Furniture> m_todayFurniture = new Dictionary<string, Furniture>();
        public void bringTodayFurniture()
        {
            Furniture furniture = new Furniture();
            furniture.InitFurnitureInfo();


            List<string> makeFurnitureListName = new List<string>();
            makeFurnitureListName.Add("냉장고");
            makeFurnitureListName.Add("TV");
            makeFurnitureListName.Add("스타일러");
            makeFurnitureListName.Add("라디오");
            makeFurnitureListName.Add("컴퓨터");
            makeFurnitureListName.Add("피아노");
            makeFurnitureListName.Add("선풍기");
            makeFurnitureListName.Add("에어컨");
            makeFurnitureListName.Add("세탁기");
            makeFurnitureListName.Add("의자");

            for (int i = 0; i < makeFurnitureListName.Count; i++)
            {
                Furniture addFurniture = new Furniture();
                addFurniture.InitFurnitureInfo();

                addFurniture.m_furnitureName = makeFurnitureListName[i];
                addFurniture.m_furnitureID = i;

                m_todayFurniture.Add(makeFurnitureListName[i], addFurniture);

            }




        }

        public void openStore()
        {
            foreach (Furniture OpenItem in m_todayFurniture.Values)
            {
                Console.WriteLine($"가구 Id : {OpenItem.m_furnitureID}, 가구 이름 : {OpenItem.m_furnitureName}");
            }
        }
    }



    internal class Program
    {





        static void Main(string[] args)
        {
            Furniture furniture1 = new Furniture();
            FurnitureStore bringFurniture = new FurnitureStore();
            bringFurniture.bringTodayFurniture();
            bringFurniture.openStore();

        }

    }
}
