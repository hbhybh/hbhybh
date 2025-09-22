using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    int level=5;
    float strength =15.5f;
    string playername = "hb";
    bool isFullLevel = false;
    int health = 30;
    void Start()
    {
        //Debug.Log("Hello");
        //1.변수 
        
        //Debug.Log("레벨");
        //Debug.Log(level);
        //Debug.Log('힘');
        //Debug.Log(strength);
        //Debug.Log("이름");
        //Debug.Log(playername);
        //Debug.Log("레벨의 만렙여부");
        //Debug.Log(isFullLevel);
        
        //2.그룹형 변수 
        string[] monsters = { "슬라임", "고블린", "오크" };//(그냥 딕셔너리 라고 생각하면 됨)
        int[] monsterLevel = new int[3];
        monsterLevel[0] = 1;
        monsterLevel[1] = 6;
        monsterLevel[2] = 24;
        
        //Debug.Log("맵에 존재하는 몬스터 레벨");
        //Debug.Log(monsterLevel[0]);
        //Debug.Log(monsterLevel[1]);
        //Debug.Log(monsterLevel[2]);

        List<string> item = new List<string>();//이건 말그대로 리스트
        item.Add("생명 물약 30");
        item.Add("마나물약 30");
        
        //Debug.Log("가지고 있는 아이템");
        //Debug.Log(item[0]);
        //Debug.Log(item[1]);
        //Debug.Log(item[0]);
        
        //3.연산자(말 그대로 연산자 +,-,*,/,%(나머지),<,>,<=,>=,&&,||)
        int exp = 2900;

        exp = exp - 300;
        exp =exp+400;
        level = exp / 300;
        strength = level * 3.1f;
        
        //Debug.Log(exp);
        //Debug.Log(level);
        //Debug.Log(strength);

        int nextExp = 300 - (exp % 300);
        //Debug.Log("다음 레벨까지");
        //Debug.Log(nextExp);

        string title = "전설의";
        //Debug.Log("용사 이름");
        //Debug.Log(title+" "+playername);
        

        int fullLevel = 99;
        isFullLevel = level == fullLevel;
        //Debug.Log("만렙?"+isFullLevel);

        bool isEndTutorial = level >= 10;
        //Debug.Log("튜토리얼 끝?"+isEndTutorial);

        int health = 30;
        int mana = 30;
       // bool isBadcondition = health <= 50 && mana <= 20; &&는 and ||sms or
        bool isBadcondition = health <= 50 && mana <= 20;
        //Debug.Log("용사 상태 나쁨?"+isBadcondition);

        string condition = isBadcondition ? "나쁨" : "좋음";
        //Debug.Log("용사 상태 나쁨?"+condition);
        //4.키워드
        //int,float,string,new,List,bool(변수 이름같은걸로 사용 불가능)
        
        //5.조건문
        if (condition == "나쁨")
        {
            //Debug.Log("상태 나쁨");
        }
        else
        {
            //Debug.Log("좋음");
        }

        if (isBadcondition && item[0] == "생명물약30") ; {
            item.RemoveAt(0);
            //Debug.Log("생명 물약을 사용하였습니다");
        }
        
        if (isBadcondition && item[0] == "마나포션30") ; {
            item.RemoveAt(0);
            //Debug.Log("마나포션을 사용하였습니다");
        }

        switch (monsters[1])
        {
            case "슬라임"://같이둬도 ok
            case "사막뱀":
                //Debug.Log("소형 몬스터 출현!");
                break;
            case "악마":
                //Debug.Log("중형 몬스터 출현!");
                break;
            case "골렘":
                //Debug.Log("대형 몬스터 출현!");
                break; 
            default:
                //Debug.Log("??? 몬스터 출현!");
                break;
        }
        //6.반복문
        while (health > 0)
        {
            health--;
            //Debug.Log("독 데미지를 입었습니다" + health);

            if (health == 10) {
                //Debug.Log("해독제를 사용합니다");
                break;
            }
        }

        for (int index = 0; index < monsterLevel.Length; index++)
        {
            //Debug.Log("용사는"+monsters[index]+"에게"+battle(monsterLevel[index]));
        }

        for (int count = 0; count < 10; count++) {
            //count는 0;count가 10 이하이면;1씩 더해라
            health++;
            //Debug.Log("치료중..." + health);
        }

        for (int index = 0; index < monsters.Length; index++) { 
            //Debug.Log("이 지역에 있는 몬스터:"+monster[index]);
           
        }

        foreach (string monster in monsters)
        {
            //Debug.Log("이 지역에 있는 몬스터:"+monster);
        } 
        Heal();
        
        
        
        //8.클래스
        Player player = new Player();
        player.id = 0;
        player.name = "hb";
        player.title="몰라";
        player.strength = 2.4f;
        player.weapon = "나무 검";
        Debug.Log(player.Talk());
        Debug.Log(player.Hasweapon());
        
        player.LevelUp();
        Debug.Log(player.name+"의 레벨은"+player.level+"입니다");
        
        Debug.Log(player.move());












    }


    void Heal()
    {
        health += 10;
        //Debug.Log("힐을 받았습니다" + health);
    }

    string battle(int monsterLevel)
    {
        string result;
        if (level >= monsterLevel)
            result="이겼습니다";
        else
        {
            result = "졌습니다";
        }
        return result;
    }
    void Update()
    {
        
    }
}

