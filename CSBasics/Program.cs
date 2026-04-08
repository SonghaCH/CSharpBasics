using System;
using System.Collections.Generic;

namespace CSBasics
{
    internal class Program
    {
        public class FantasyCreature
        {
            public void Move()
            {
                Console.WriteLine("움직인다~");
            }
        }

        static void Main(string[] args)
        {
            var fantasyCreatureDictionary = new Dictionary<string, FantasyCreature>(); //딕셔너리 만들기

            var dragon = new FantasyCreature();                    //키와 밸류 집어넣기
            fantasyCreatureDictionary.Add("드래곤", dragon);
            var nineTaleFox = new FantasyCreature();
            fantasyCreatureDictionary.Add("구미호", nineTaleFox); 
            var kraken = new FantasyCreature();
            fantasyCreatureDictionary.Add("크라켄", kraken);

            FantasyCreature foundFantasyCreature = fantasyCreatureDictionary["드래곤"]; //사전찾기

            if (foundFantasyCreature != null)//널체크
            {
                foundFantasyCreature.Move();
                fantasyCreatureDictionary.Remove("드래곤");
            }

        }
    }
}