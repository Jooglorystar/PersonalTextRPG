using System.Net;

namespace PersonalTextRPG
{
    class Player
    {
        string name;
        string charClass = "디폴트직업";
        int level = 1;
        int maxLevel = 5;
        int playerExp = 0;
        float attack;
        int defence;
        int health;
        int maxhealth= 100;
        int money = 1500;
        bool isWeaponEquipped = false;
        bool isArmorEquipped = false;

        public Player(string _name, int _health, float _attack, int _defence)
        {
            name = _name;
            attack = _attack;
            defence = _defence;
            health = _health;
        }

        public string Name { get { return name; } set { name = value; } }
        public string CharClass { get { return charClass; } set { charClass = value; } }
        public int Level { get { return level; } set { level = value; } }
        public int MaxLevel { get { return maxLevel; } set { maxLevel = value; } }
        public int PlayerExp { get { return playerExp; } set { playerExp = value; } }
        public float Attack { get { return attack; } set { attack = value; } }
        public int Defence { get { return defence; } set { defence = value; } }
        public int Health { get { return health; } set { health = value; } }
        public int MaxHealth { get { return maxhealth; } set { maxhealth = value; } }
        public int Money { get { return money; } set { money = value; } }
        public bool IsWeaponEquipped { get { return isWeaponEquipped; } set { isWeaponEquipped = value; } }
        public bool IsArmorEquipped { get { return isArmorEquipped; } set { isArmorEquipped = value; } }

    }

    interface IGameItem
    {
        public string Name { get; set; }
        public int ItemID { get; set; }
        public string ItemInfo { get; set; }
        public int ItemPrice { get; set; }
        public bool IsHave { get; set; }
        public bool IsEquipped { get; set; }
    }

    class Weapon : IGameItem
    {
        string name;
        int itemID;
        int itemAttack;
        string itemInfo;
        int itemPrice;
        bool isHave = false;
        bool isEquipped = false;

        public Weapon(string _name, int _itemID, int _itemAttack, string _itemInfo)
        {
            name = _name;
            itemID = _itemID;
            itemAttack = _itemAttack;
            ItemInfo = _itemInfo;
        }

        public string Name { get { return name; } set { name = value; } }
        public int ItemID { get { return itemID; } set { itemID = value; } }
        public int ItemAttack { get { return itemAttack; } set { itemAttack = value; } }
        public string ItemInfo { get { return itemInfo; } set { itemInfo = value; } }
        public int ItemPrice { get { return itemAttack * 200; } set { } }
        public bool IsHave { get { return isHave; } set { isHave = value; } }
        public bool IsEquipped { get { return isEquipped; } set { isEquipped = value; } }
    }

    class Armor : IGameItem
    {
        string name;
        int itemID;
        int itemDefence;
        string itemInfo;
        int itemPrice;
        bool isHave = false;
        bool isEquipped = false;

        public Armor(string _name, int _itemID, int _itemDefence, string _itemInfo)
        {
            name = _name;
            itemID = _itemID;
            itemDefence = _itemDefence;
            itemInfo = _itemInfo;
        }

        public string Name { get { return name; } set { name = value; } }
        public int ItemID { get { return itemID; } set { itemID = value; } }
        public int ItemDefence { get { return itemDefence; } set { itemDefence = value; } }
        public string ItemInfo { get { return itemInfo; } set { itemInfo = value; } }
        public int ItemPrice { get { return itemDefence * 400; } set { } }
        public bool IsHave { get { return isHave; } set { isHave = value; } }
        public bool IsEquipped { get { return isEquipped; } set { isEquipped = value; } }
    }

    class GameSystem
    {
        Player player = new Player("Default", 100, 10f, 5);

        List<Weapon> weaponInventory = new List<Weapon>();
        List<Armor> armorInventory = new List<Armor>();

        Weapon[] weapons =
        {
        new Weapon("무기0",0,1, "테스트 무기입니다."),
        new Weapon("무기0",0,1, "테스트 무기입니다."),
        new Weapon("무기0",0,1, "테스트 무기입니다."),
        new Weapon("무기0",0,1, "테스트 무기입니다.")
        };
        Armor[] armors =
        {
        new Armor("방어구0", 0, 1, "테스트 방어구입니다."),
        new Armor("방어구0", 0, 1, "테스트 방어구입니다."),
        new Armor("방어구0", 0, 1, "테스트 방어구입니다."),
        new Armor("방어구0", 0, 1, "테스트 방어구입니다."),
        };

        Weapon[] paladinWeapons =
        {
        new Weapon("무기0",0,1, "테스트 무기입니다."),
        new Weapon("나무 망치", 1, 3, "나무로 만들어진 망치."),
        new Weapon("쇠 망치", 2, 9, "강철로 만들어진 망치."),
        new Weapon("빛의 망치", 3, 15, "빛의 축복을 받은 망치.")
        };
        Armor[] paladinArmors =
        {
        new Armor("방어구0", 0, 1, "테스트 방어구입니다."),
        new Armor("가죽 갑옷", 1, 1, "가죽으로 만들어진 방어구."),
        new Armor("사슬 갑옷", 2, 3, "사슬로 이어진 방어구."),
        new Armor("판금 갑옷", 3, 5, "판금으로 만들어진 방어구.")
        };
        Weapon[] priestWeapons =
        {
        new Weapon("무기0",0,1, "테스트 무기입니다."),
        new Weapon("나무 지팡이", 1, 3, "나무로 만들어진 지팡이."),
        new Weapon("철제 지팡이", 2, 9, "강철로 만들어진 지팡이."),
        new Weapon("빛의 지팡이", 3, 15, "빛의 축복을 받은 지팡이.")
        };
        Armor[] priestArmors =
        {
        new Armor("방어구0", 0, 1, "테스트 방어구입니다."),
        new Armor("수행사제 기도복", 1, 1, "수행사제의 기도복."),
        new Armor("고위사제 기도복", 2, 3, "고위사제의 기도복."),
        new Armor("대사제의 기도복", 3, 5, "대사제의 기도복.")
        };

        Random random = new Random();

        int playerSelect = 0;
        int itemSelect = 0;

        int weaponAttack = 0;
        int armorDefence = 0;

        public void PlayerMake()
        {
            string inputName;
            Console.WriteLine("게임을 시작합니다.");
            Console.Write("플레이어의 이름을 입력해주세요: ");
            inputName = Console.ReadLine();
            player.Name = inputName;

            do
            {
                Console.Write("플레이어의 직업을 설정해주세요\n1. 성기사\n2. 사제\n>>");
                PlayerSelectReset();
                PlayerSelect();

                switch (playerSelect)
                {
                    case 1:
                        Console.WriteLine("당신은 성기사입니다.");
                        player.CharClass = "성기사";
                        weapons = paladinWeapons;
                        armors = paladinArmors;
                        break;
                    case 2:
                        Console.WriteLine("당신은 사제입니다.");
                        player.CharClass = "사제";
                        weapons = priestWeapons;
                        armors = priestArmors;

                        break;
                    default:
                        Console.WriteLine("올바른 값을 입력해주세요");
                        break;
                }

            } while (playerSelect != 1 && playerSelect != 2);

        }


        public void InTown()
        {
            while (true)
            {
                if (player.Health < 0)
                {
                    Console.WriteLine("힘이 다하고 말았다...");
                    Console.WriteLine("==========Game Over==========");
                    break;
                }
                if (player.Level < player.MaxLevel)
                {
                    if (player.PlayerExp >= player.Level)
                    {
                        Console.WriteLine("레벨업!");
                        player.Level += 1;
                        player.Defence += 1;
                        player.Attack += 0.5f;

                        player.PlayerExp = 0;
                    }
                }

                Console.WriteLine("\n마을이다.\n\n");
                Console.WriteLine("1. 던전입장\n2. 인벤토리\n3. 상태보기\n4. 상점\n5. 휴식하기\n6. 게임 종료");
                Console.Write("어떤 행동을 할까?\n>>");

                PlayerSelectReset();
                PlayerSelect();
                switch (playerSelect)
                {
                    case 1:             // 던전 입장
                        EnterDungeon();
                        break;

                    case 2:             // 인벤토리
                        OpenInventory();
                        break;

                    case 3:             // 상태보기
                        PlayerInfoDraw();
                        break;

                    case 4:             // 상점
                        TownShop();
                        break;

                    case 5:             // 휴식하기
                        RestInTown();
                        break;

                    case 6:             // 게임종료
                        Console.WriteLine("게임을 종료합니다.");
                        break;

                    default:
                        Console.WriteLine("올바른 값을 입력해주세요.");
                        continue;
                }

                if (playerSelect == 6)
                {
                    break;
                }
            }
        }

        void EnterDungeon()
        {
            Console.WriteLine("어떤 던전에 들어가시겠습니까?");
            Console.WriteLine("1. 쉬운 던전     | 방어력 5 이상 권장");
            Console.WriteLine("2. 일반 던전     | 방어력 11 이상 권장");
            Console.WriteLine("3. 어려운 던전   | 방어력 17 이상 권장");
            Console.WriteLine("4. 마을로 돌아가기");
            Console.Write(">>");
            PlayerSelectReset();
            PlayerSelect();

            int dungeonStatcut = 0;
            int dungeonDamage = 0;
            int dungeonReward;
            float additionalReward = 0f;
            int randomCheck;
            bool isClear;
            WeaponStatCheck();

            switch (playerSelect)
            {
                case 1:
                    Console.WriteLine("쉬운 던전 입장");
                    dungeonStatcut = 5;
                    dungeonReward = 1000;
                    DungeonStatCheck();
                    DungeonClearCheck();

                    break;

                case 2:
                    Console.WriteLine("일반 던전 입장");
                    dungeonStatcut = 11;
                    dungeonReward = 1700;
                    DungeonStatCheck();
                    DungeonClearCheck();

                    break;

                case 3:
                    Console.WriteLine("어려운 던전 입장");
                    dungeonStatcut = 17;
                    dungeonReward = 2500;
                    DungeonStatCheck();
                    DungeonClearCheck();

                    break;

                case 4:
                    Console.WriteLine("마을로 돌아갑니다.");
                    break;

                default:
                    Console.WriteLine("올바른 값을 입력해주세요.");
                    break;
            }

            void DungeonStatCheck()
            {
                int totalDefence = player.Defence + armorDefence;

                if (totalDefence >= dungeonStatcut)
                {
                    isClear = true;
                }
                else
                {
                    randomCheck = random.Next(0, 10);
                    if (randomCheck < 4)
                    {
                        isClear = false;
                    }
                    else
                    {
                        isClear = true;
                    }
                }
                dungeonDamage = (totalDefence) - dungeonStatcut;
            }

            void DungeonClearCheck()
            {
                float totalAttack = player.Attack + weaponAttack;

                if (isClear)
                {
                    additionalReward = ((float)random.Next((int)(totalAttack), (int)(totalAttack * 2)) / 100);
                    additionalReward = (float)dungeonReward * additionalReward;
                    dungeonReward += (int)additionalReward;

                    Console.WriteLine("던전 클리어!\n\n");

                    randomCheck = random.Next(20, 36);
                    dungeonDamage += randomCheck;

                    int playerHealthTemp = player.Health;
                    player.Health -= dungeonDamage;

                    int playerMoneyTemp = player.Money;
                    player.Money += dungeonReward;
                    Console.WriteLine("===[탐험 결과]===\n");
                    Console.WriteLine($"체력: {playerHealthTemp} -> {player.Health}");
                    Console.WriteLine($"소지금: {playerMoneyTemp} -> {player.Money}");
                    Console.WriteLine("=================\n");
                    player.PlayerExp++;
                }
                else
                {
                    Console.WriteLine("던전 클리어 실패...");
                    player.Health -= (player.MaxHealth / 2);
                }
            }
        }

        void OpenInventory()
        {
            do
            {
                Console.WriteLine("===인벤토리창===\n");
                Console.WriteLine($"[보유 금액]\n{player.Money} G\n");

                HaveWeaponDraw();

                HaveArmorDraw();
                Console.Write("어떤 행동을 할까요?\n1. 무기 장착 관리\n2. 방어구 장착 관리\n3. 돌아가기\n>>");
                PlayerSelectReset();
                PlayerSelect();
                switch (playerSelect)
                {
                    case 1:
                        foreach (var weapon in weaponInventory)
                        {
                            if (weapon.IsEquipped)
                            {
                                Console.Write("-[E] ");
                            }
                            else
                            {
                                Console.Write("- ");
                            }
                            Console.WriteLine($"{weaponInventory.IndexOf(weapon) + 1}. {weapon.Name}\t|공격력 \t+{weapon.ItemAttack}|{weapon.ItemInfo}");
                        }
                        Console.Write("어떤 무기를 장착 할까요?(0 눌러 뒤로가기)\n>>");

                        itemSelect = 0;
                        ItemSelect();

                        if(itemSelect == 0)
                        {
                            break;
                        }

                        if (itemSelect - 1 < weaponInventory.Count())
                        {
                            if (itemSelect - 1 == weaponInventory.IndexOf(weaponInventory[itemSelect - 1]))
                            {
                                Weapon selectedWeapon = weaponInventory[itemSelect - 1];
                                Console.WriteLine($"{selectedWeapon.Name}을 선택했습니다.");

                                // 선택한 장비가 장착되지 않음
                                if (!selectedWeapon.IsEquipped)
                                {
                                    // 플레이어는 장비를 착용중이 아님
                                    if (!player.IsWeaponEquipped)
                                    {
                                        Console.WriteLine($"{selectedWeapon.Name}을 장착했습니다.");
                                        selectedWeapon.IsEquipped = true;
                                        player.IsWeaponEquipped = true;
                                    }
                                    // 플레이어는 장비를 착용하고 있음(다른 장비를 착용중임)
                                    else
                                    {
                                        Console.WriteLine($"{selectedWeapon.Name}을 장착했습니다.");
                                        foreach (var weapon in weaponInventory)
                                        {
                                            weapon.IsEquipped = false;
                                        }
                                        selectedWeapon.IsEquipped = true;
                                        player.IsWeaponEquipped = true;
                                    }
                                }
                                // 선택한 아이템이 장착됨
                                else
                                {
                                    Console.WriteLine($"{selectedWeapon.Name}을 장착 해제했습니다.");
                                    selectedWeapon.IsEquipped = false;
                                    player.IsWeaponEquipped = false;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("제대로 된 값을 입력해주세요");
                            continue;
                        }
                        break;
                    case 2:
                        foreach (var armor in armorInventory)
                        {
                            if (armor.IsEquipped)
                            {
                                Console.Write("-[E] ");
                            }
                            else
                            {
                                Console.Write("- ");
                            }
                            Console.WriteLine($"{armorInventory.IndexOf(armor) + 1}. {armor.Name}\t|공격력 \t+{armor.ItemDefence}|{armor.ItemInfo}");
                        }
                        Console.Write("어떤 방어구를 장착 할까요?(0 눌러 뒤로가기)\n>>");

                        itemSelect = 0;
                        ItemSelect();

                        if (itemSelect == 0)
                        {
                            break;
                        }

                        if (itemSelect - 1 < armorInventory.Count())
                        {
                            if (itemSelect - 1 == armorInventory.IndexOf(armorInventory[itemSelect - 1]))
                            {
                                Armor selectedArmor = armorInventory[itemSelect - 1];
                                Console.WriteLine($"{selectedArmor.Name}을 선택했습니다.");

                                // 선택한 장비가 장착되지 않음
                                if (!selectedArmor.IsEquipped)
                                {
                                    // 플레이어는 장비를 착용중이 아님
                                    if (!player.IsArmorEquipped)
                                    {
                                        Console.WriteLine($"{selectedArmor.Name}을 장착했습니다.");
                                        selectedArmor.IsEquipped = true;
                                        player.IsArmorEquipped = true;
                                    }
                                    // 플레이어는 장비를 착용하고 있음(다른 장비를 착용중임)
                                    else
                                    {
                                        Console.WriteLine($"{selectedArmor.Name}을 장착했습니다.");
                                        foreach (var armor in armorInventory)
                                        {
                                            armor.IsEquipped = false;
                                        }
                                        selectedArmor.IsEquipped = true;
                                        player.IsArmorEquipped = true;
                                    }
                                }
                                // 선택한 아이템이 장착됨
                                else
                                {
                                    Console.WriteLine($"{selectedArmor.Name}을 장착 해제했습니다.");
                                    selectedArmor.IsEquipped = false;
                                    player.IsArmorEquipped = false;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("제대로 된 값을 입력해주세요");
                            continue;
                        }
                        break;
                    case 3:
                        Console.WriteLine("마을로 돌아갑니다.");
                        break;
                    default:
                        Console.WriteLine("올바른 값을 입력해주세요");
                        break;
                }
            } while (playerSelect != 3);

        }

        void PlayerInfoDraw()
        {
            WeaponStatCheck();
            Console.WriteLine("====================");
            Console.WriteLine($"이름: {player.Name} | 레벨: {player.Level}");
            Console.WriteLine($"직업: {player.CharClass}");
            Console.WriteLine($"HP : {player.Health} / {player.MaxHealth}");
            if (player.IsWeaponEquipped)
                Console.WriteLine($"공격력: {player.Attack + weaponAttack} (+ {weaponAttack})");
            else
                Console.WriteLine($"공격력: {player.Attack}");
            if (player.IsArmorEquipped)
                Console.WriteLine($"방어력: {player.Defence + armorDefence} (+ {armorDefence})");
            else
                Console.WriteLine($"방어력: {player.Defence}");
            Console.WriteLine($"소지금: {player.Money} G");
            Console.WriteLine("====================");
            Console.WriteLine("엔터 눌러 돌아가기");
            Console.ReadLine();
        }

        void TownShop()
        {
            Console.WriteLine("상점입니다. 어서오세요.\n");

            do
            {

                Console.WriteLine($"[보유 금액]\n{player.Money} G\n");

                WeaponShopDraw();
                ArmorShopDraw();

                Console.Write("어떤 행동을 할까?" +
                    "\n1. 무기 구입" +
                    "\n2. 방어구 구입" +
                    "\n3. 아이템 판매" +
                    "\n4. 마을로 돌아가기" +
                    "\n>>");
                PlayerSelectReset();
                PlayerSelect();
                switch (playerSelect)
                {
                    case 1:
                        Console.WriteLine("무기 구입을 합니다.");
                        WeaponShop();
                        break;
                    case 2:
                        Console.WriteLine("방어구 구입을 합니다.");
                        ArmorShop();
                        break;
                    case 3:
                        Console.WriteLine("아이템 판매를 합니다.(미구현)");
                        SellItem();
                        break;
                    case 4:
                        Console.WriteLine("마을로 돌아갑니다.");
                        break;
                    default:
                        Console.WriteLine("올바른 값을 입력해주세요");
                        break;
                }

            } while (playerSelect != 4);

            void WeaponShopDraw()
            {
                Console.WriteLine("[무기 목록]\n");

                for (int i = 1; i < weapons.Length; i++)
                {
                    Console.Write($"- {weapons[i].Name}\t|공격력 \t+{weapons[i].ItemAttack}|{weapons[i].ItemInfo}\t|");
                    if (weapons[i].IsHave)
                    {
                        Console.Write("구입 완료");
                    }
                    else
                    {
                        Console.Write($"{weapons[i].ItemPrice} G");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            void WeaponShop()
            {
                WeaponShopDraw();
                do
                {
                    Console.Write($"어떤 아이템을 구입할까?" +
                        $"\n\n1. {weapons[1].Name}" +
                        $"\n2. {weapons[2].Name}" +
                        $"\n3. {weapons[3].Name}" +
                        $"\n4. 구입하지 않음" +
                        $"\n>>");
                    PlayerSelectReset();
                    PlayerSelect();
                    switch (playerSelect)
                    {
                        case 1:
                        case 2:
                        case 3:
                            if (weapons[playerSelect].IsHave)
                            {
                                Console.WriteLine($"{weapons[playerSelect].Name}은 이미 가지고 있습니다.");
                                PlayerSelectReset();
                            }
                            else
                            {
                                if (player.Money >= weapons[playerSelect].ItemPrice)
                                {
                                    Console.WriteLine($"{weapons[playerSelect].Name}를 구입합니다.");
                                    weaponInventory.Add(weapons[playerSelect]);
                                    player.Money -= weapons[playerSelect].ItemPrice;
                                    weapons[playerSelect].IsHave = true;
                                }
                                else
                                {
                                    Console.WriteLine("돈이 부족해 구입할 수 없습니다.");
                                }
                            }
                            break;
                        case 4:
                            Console.WriteLine("아무것도 구입하지 않습니다");
                            break;
                        default:
                            Console.WriteLine("올바른 값을 입력해주세요");
                            break;
                    }
                } while (playerSelect != 1 && playerSelect != 2 && playerSelect != 3 && playerSelect != 4);
            }

            void ArmorShopDraw()
            {
                Console.WriteLine("[방어구 목록]\n");

                for (int i = 1; i < armors.Length; i++)
                {
                    Console.Write($"- {armors[i].Name}\t|방어력 \t+{armors[i].ItemDefence}|{armors[i].ItemInfo}\t|");
                    if (armors[i].IsHave)
                    {
                        Console.Write("구입 완료");
                    }
                    else
                    {
                        Console.Write($"{armors[i].ItemPrice} G");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }

            void ArmorShop()
            {
                ArmorShopDraw();
                do
                {
                    Console.Write($"어떤 아이템을 구입할까?\n\n1. {armors[1].Name}\n2. {armors[2].Name}\n3. {armors[3].Name}\n4. 구입하지 않음\n>>");
                    PlayerSelectReset();
                    PlayerSelect();
                    switch (playerSelect)
                    {
                        case 1:
                        case 2:
                        case 3:
                            if (armors[playerSelect].IsHave)
                            {
                                Console.WriteLine($"{armors[playerSelect].Name}은 이미 가지고 있습니다.");
                                PlayerSelectReset();
                            }
                            if (player.Money >= armors[playerSelect].ItemPrice)
                            {
                                Console.WriteLine($"{armors[playerSelect].Name}를 구입합니다.");
                                armorInventory.Add(armors[playerSelect]);
                                player.Money -= armors[playerSelect].ItemPrice;
                                armors[playerSelect].IsHave = true;
                            }
                            else
                            {
                                Console.WriteLine("돈이 부족해 구입할 수 없습니다.");
                            }
                            break;
                        case 4:
                            Console.WriteLine("아무것도 구입하지 않습니다");
                            break;
                        default:
                            Console.WriteLine("올바른 값을 입력해주세요");
                            break;
                    }
                } while (playerSelect != 1 && playerSelect != 2 && playerSelect != 3 && playerSelect != 4);

            }

            void SellItem()
            {
                Console.WriteLine("===인벤토리창===\n");

                HaveWeaponDraw();
                HaveArmorDraw();

                Console.Write("어떤 행동을 할까요?\n1. 무기 판매\n2. 방어구 판매\n3. 돌아가기\n>>");
                PlayerSelectReset();
                PlayerSelect();

                switch (playerSelect)
                {
                    case 1:
                        foreach (var weapon in weaponInventory)
                        {
                            if (weapon.IsEquipped)
                            {
                                Console.Write("-[E] ");
                            }
                            else
                            {
                                Console.Write("- ");
                            }
                            Console.WriteLine($"{weaponInventory.IndexOf(weapon) + 1}. {weapon.Name}\t|공격력 \t+{weapon.ItemAttack}|{weapon.ItemInfo}");
                        }
                        Console.Write("어떤 무기를 판매 할까요?\n>>");

                        itemSelect = 0;
                        ItemSelect();

                        if (itemSelect - 1 < weaponInventory.Count())
                        {
                            Weapon selectedWeapon = weaponInventory[itemSelect - 1];
                            int sellPrice = (int)((float)(selectedWeapon.ItemPrice) * 0.85f);
                            if (itemSelect - 1 == weaponInventory.IndexOf(selectedWeapon))
                            {
                                if (selectedWeapon.IsEquipped)
                                {
                                    player.IsWeaponEquipped = false;
                                    selectedWeapon.IsEquipped = false;
                                }
                                selectedWeapon.IsHave = false;

                                player.Money += sellPrice;
                                Console.WriteLine($"{selectedWeapon.Name}을 팔아 {sellPrice} G를 획득했습니다.");
                                weaponInventory.Remove(selectedWeapon);
                            }
                        }
                        else
                        {
                            Console.WriteLine("제대로 된 값을 입력해주세요");
                        }
                        break;
                    case 2:
                        foreach (var armor in armorInventory)
                        {
                            if (armor.IsEquipped)
                            {
                                Console.Write("-[E] ");
                            }
                            else
                            {
                                Console.Write("- ");
                            }
                            Console.WriteLine($"{armorInventory.IndexOf(armor) + 1}. {armor.Name}\t|공격력 \t+{armor.ItemDefence}|{armor.ItemInfo}");
                        }
                        Console.Write("어떤 방어구를 판매 할까요?\n>>");

                        itemSelect = 0;
                        ItemSelect();

                        if (itemSelect - 1 < armorInventory.Count())
                        {
                            Armor selectedArmor = armorInventory[itemSelect - 1];
                            int sellPrice = (int)((float)(selectedArmor.ItemPrice) * 0.85f);
                            if (itemSelect - 1 == armorInventory.IndexOf(selectedArmor))
                            {
                                if (selectedArmor.IsEquipped)
                                {
                                    player.IsWeaponEquipped = false;
                                    selectedArmor.IsEquipped = false;
                                }
                                selectedArmor.IsHave = false;

                                player.Money += sellPrice;
                                Console.WriteLine($"{selectedArmor.Name}을 팔아 {sellPrice} G를 획득했습니다.");
                                armorInventory.Remove(selectedArmor);
                            }
                        }
                        else
                        {
                            Console.WriteLine("제대로 된 값을 입력해주세요");
                        }
                        break;
                    case 3:
                        Console.WriteLine("상점으로 돌아갑니다.");
                        break;
                    default:
                        Console.WriteLine("올바른 값을 입력해주세요");
                        break;
                }
            }

        }

        void RestInTown()
        {
            int restPrice = 500;
            Console.Write($"휴식하는데는 {restPrice}G가 필요합니다.");
            if (player.Money > restPrice)
            {
                do
                {
                    Console.Write("\n휴식하시겠습니까?\n1. 예\n2. 아니오\n>>");
                    PlayerSelectReset();
                    PlayerSelect();
                    switch (playerSelect)
                    {
                        case 1:
                            Console.WriteLine("휴식 했습니다.\n체력이 전부 회복되었습니다.");
                            player.Money -= restPrice;
                            player.Health = player.MaxHealth;
                            break;
                        case 2:
                            Console.WriteLine("휴식하지 않습니다.");
                            break;
                        default:
                            Console.WriteLine("올바른 값을 입력해주세요");
                            break;
                    }

                } while (playerSelect != 1 && playerSelect != 2);

            }
            else
            {
                Console.WriteLine("보유금액이 부족해 휴식할 수 없습니다.");
            }
        }

        void PlayerSelectReset()
        {
            playerSelect = 0;
        }

        void PlayerSelect()
        {
            try
            {
                playerSelect = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

            }
        }

        void ItemSelect()
        {
            try
            {
                itemSelect = int.Parse(Console.ReadLine());
            }
            catch (Exception) 
            {

            }
        }

        void HaveWeaponDraw()
        {
            Console.WriteLine("=====소지 무기=====");

            foreach (var weapon in weaponInventory)
            {
                if (weapon.IsEquipped)
                {
                    Console.Write("-[E] ");
                }
                else
                {
                    Console.Write("- ");
                }
                Console.WriteLine($"{weapon.Name}\t|공격력 \t+{weapon.ItemAttack}|{weapon.ItemInfo}");


            }

        }

        void HaveArmorDraw()
        {
            Console.WriteLine("=====소지 방어구=====");
            foreach (var armor in armorInventory)
            {
                if (armor.IsEquipped)
                {
                    Console.Write("-[E] ");
                }
                else
                {
                    Console.Write("- ");
                }
                Console.WriteLine($"{armor.Name}\t|공격력 \t+{armor.ItemDefence}|{armor.ItemInfo}");


            }
        }

        void WeaponStatCheck()
        {
            foreach (var weapon in weaponInventory)
            {
                if (weapon.IsEquipped)
                {
                    weaponAttack = weapon.ItemAttack;
                }
            }
            foreach (var armor in armorInventory)
            {
                if (armor.IsEquipped)
                {
                    armorDefence = armor.ItemDefence;
                }
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            GameSystem system = new GameSystem();

            system.PlayerMake();

            system.InTown();
        }

    }
}

