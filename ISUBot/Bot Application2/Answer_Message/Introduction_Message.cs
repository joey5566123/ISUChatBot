using Bot_Application2.Dialogs;

namespace Bot_Application2.Answer_Message
{
    public class Introduction_Message
    {
        public static string School_Introduction(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "國際學院": //1
                    msg = "國際學院位於理工大樓及科技大樓旁，是最新的一棟建築物" + br +
                        "國際學院為應英系、應日系、國際企業經營學系、國際財務金融學系、國際觀光餐旅學系、娛樂事業管理學系等主要上課的地方";
                    break;
                case "科技大樓": //2
                    msg = "科技大樓位於學校最裡面" + br +
                        "科技大樓三樓為義守圖書館總館" + br +
                        "四樓為電腦教室、自由上機電腦教室與圖書資訊處" + br +
                        "其餘樓層為電機系、電子系、資工系、資管系、通訊系的上課樓層";
                    break;
                case "綜教大樓": //3
                    msg = "綜教大樓位於學校的最高處" + br +
                        "為一棟13層樓的建築，是各系的上課所在。" + br +
                        "前往綜教大樓，會遇到百階、小百階，是義守人肯定走過的一條路" + br +
                        "詳情可以問我百階、小百階，會有詳細介紹唷~";
                    break;
                case "理工大樓": //4
                    msg = "理工大樓位於國際學院的旁邊" + br +
                        "為機動系、土木系、化工系、材料系的上課教室，有著各種專業教室" +
                        "還有很多的\"燕子\"，對！你沒看錯，\"燕子\"";
                    break;
                case "行政大樓": //5
                    msg = "行政大樓一樓為各行政單位的所在，有需要辦事情可以到這裡找唷" + br +
                        "行政四樓開始為財數系、工管系、企管系、財金系、會計系、政管系、國商系的所在";
                    break;
                case "宿舍": //6
                    msg = "宿舍分為一宿、二宿，每學期價錢各不同，一宿寒、暑假需搬出，二宿不用" + br +
                        "詳細介紹：https://goo.gl/jZdLqa";
                    break;
                case "地雷食物": //7
                    msg = "地雷食物這不好說啊，每個人口味不同，吃起來也不一樣。" + br +
                        "或許可以上DCARD搜尋，很多同學有PO文過哦";
                    break;
                case "自修室": //8
                    msg = "自修室位在科技大樓三樓，圖書館旁，是個安靜讀書或休息的好地方，冷氣很強";
                    break;
                case "郵局": //9
                    msg = "郵局位在校門口進來的左手邊，有提款機，營業時間為： 8:30-12:30 中午休息 13:00-16:30";
                    break;
                case "電腦教室": //10
                    msg = "電腦教室在科技大樓四樓，有一間自由上機教室，可以自由使用" + br +
                        "其餘電腦教室在未上課時間也可以自由使用";
                    break;
                case "操場": //11
                    msg = "操場在綜教大樓後方，一圈為400公尺。";
                    break;
                case "球場": //12
                    msg = "球場分為排球場、網球場、籃球場" + br +
                        "網球場位於體育館旁，排球場位於網球場旁下方" + br +
                        "籃球場的位置較多，操場旁有一個、排球場旁也有";
                    break;
                case "保健室": //13
                    msg = "保健室位在行政大樓三樓，有不舒服都可以去看看唷";
                    break;
                case "圖書館": //14
                    msg = "圖書館總館位在科技大樓二、三樓，館藏很多唷！！" + br +
                        "只要攜帶學生證，就可以嗶卡進入" + br +
                        "在國際學院三樓也有一個分館";
                    break;
                case "影印部": //15
                    msg = "影印部位在綜教大樓一樓，營業時間為08:30~11:30、12:30~21:00" + br +
                        "價格：影印1元、列印2元，其餘價格請詢問影印部" + br +
                        "如果需要同一份的列印出好幾份，可以先列印一份，其餘用複印的，會比較便宜唷";
                    break;
                case "菸亭": //16
                    msg = "在學校只能在菸亭抽菸，其餘地方抽菸會被嫌棄或是被檢舉哦~" + br +
                        "菸亭有三個位置，男宿管站外涼亭、理工大樓右側涼亭、綜教大樓左側涼亭";
                    break;
                case "百階": //17
                    msg = "百階是上去綜教大樓可能會需要爬的一個超長階梯，總共有115階，很多人建議增設手扶梯呢";
                    break;
                case "小百階": //18
                    msg = "小百階在靠近行政大樓旁，總共有100階，坡度比大百階小，階梯數也較少";
                    break;
                case "校長": //19
                    msg = "現任校長為蕭介夫博士" + br +
                        "現任校長詳細介紹：" + br +
                        "https://goo.gl/sB2EEE " + br +
                        "歷任校長：" + br +
                        "https://goo.gl/rBGev1";
                    break;
                case "健身房": //20
                    msg = "健身房位置綜教大樓後操場旁，球場邊有一個樓梯可以下去" +
                        "是運動的好地方，不過設備較少較舊，有時人多可能會沒設備可以使用";
                    break;
                case "書局": //21
                    msg = "書局位在活動中心三樓全家對面";
                    break;
                case "全家": //22
                    msg = "本部的全家有兩家，一家在活動中心三樓，一家在二宿管站旁，東西都打9折唷";
                    break;
                case "義守大學": //23
                    msg = "創辦人林義守先生於西元1990年創辦高雄工學院" + br +
                        "於西元1997年經教育部核定升格並更名為\"義守大學\"" + br +
                        "105學年學生人數為16373人，共有50個系所(包含原民班)" + br +
                        "地址：高雄市84001大樹區學城路一段1號" + br +
                        "電話：(07)6577711";
                    break;
                case "社團介紹": //24
                    msg = "學校有各式各樣的社團，請參考以下網址" + br +
                        "網址內為部份社團，直接點選社團名稱可以到該社團的網頁" + br +
                        "此表年久失修，可能會有遺漏，以實際為主，請見諒" + br + "( ´•̥̥̥ω•̥̥̥` )" + br +
                        "http://www.sa.isu.edu.tw/extclub/index.php?deptid=all";
                    break;
                case "美食街": //25
                    msg = "美食街位於體育館下方，集合各式各樣的餐廳在裡面" + br +
                        "裡面有麵食部、味美、賀喜屋、八方雲集、飲料店" + br +
                        "是午餐及晚餐的好選擇" + br +
                        "詳細介紹可以問我該餐廳的名稱唷" + br + "( • ̀ω•́ )";
                    break;
                case "教室編號": //26
                    msg = "學校的教室編號很好記哦 都為五碼" + br+
                        "1. 第一、二碼為該教室所在建築編號" + br +
                        "(行政大樓01、理工大樓02、科技大樓03)" + br +
                        "(綜教5、國際學院6)" + br +
                        "2. 第三碼為該教室所在樓層" + br +
                        "3. 第四、五碼為該教室編號" + br +
                        "請參考此網址：http://netreg.isu.edu.tw/wapp/wap_doc/Classroom.pdf";
                    break;
                case "校花": //26
                    msg = "義守應該沒有選過校花耶" + br + "(｡ŏ_ŏ)" + br +
                        "可以跟我介紹一下校花是誰嗎";
                    break;
                case "校犬": //27
                    RootDialog.Image_Use = 3;
                    msg = "目前校犬的數量為7隻唷" + br +
                        "請參考義守汪汪社粉絲專頁：" + br +
                        "https://www.facebook.com/isuWWC/";
                    break;
                case "撞球館": //28
                    msg = "撞球館位於男宿管站前的商店街，於八車旁邊。";
                    break;
            }
            return msg;
        }

        public static string BUS_Introduction(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "時刻表":
                    msg = "義大客運時刻表：https://goo.gl/dzLb4E";
                    break;
                case "義大客運":
                    msg = "目前會行駛到學校的客運或公車只有義大客運" + br +
                        "義大客運官網：http://www.edabus.com.tw/ " + br +
                        "義大客運路線圖：https://goo.gl/zhKoj6 " + br +
                        "義大客運時刻表：https://goo.gl/dzLb4E";
                    break;
            }
            return msg;
        }

        public static string Restaurant_Introduction(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "味美":
                    msg = "味美位在體育館美食街，為自行夾取的自助餐便當店";
                    break;
                case "賀喜屋":
                    msg = "賀喜屋位在體育館美食街，為可以指定菜色的便當店";
                    break;
                case "八方雲集":
                    msg = "八方雲集位在體育館美食街，為煎餃專賣店，也有賣水餃" + br +
                        "有套餐可以選擇哦" + br +
                        "招牌煎餃一顆4.5元";
                    break;
                case "飲料":
                    msg = "飲料店位在體育館美食街，有三家哦";
                    break;
                case "麵食部":
                    msg = "麵食部位在體育館美食街，有各式麵食哦";
                    break;
                case "綜三":
                    msg = "綜教三樓為輕食坊，賣各式各樣的食品飲料，有早餐、關東煮、便當(中午販售)、包子、涼麵、飯捲";
                    break;
                case "義廚房":
                    msg = "義廚位於活動中心四樓，有各類餐點";
                    break;
                case "義咖啡":
                    msg = "義咖啡位在綜教大樓與科技大樓中間，操場旁邊，單價較高" + br +
                        "中午容易客滿，可以在當天AM10:30先打電話訂位 " + br;
                    break;
                case "八車":
                    msg = "八車在男宿管站前的街道，是一家餐廳哦";
                    break;
                case "餐廳介紹":
                    msg = "目前學校有的餐聽：" + br +
                        "麵食部、味美、賀喜屋、八方雲集、綜三、義廚房、義咖啡、八車" + br +
                        "各餐廳詳細介紹可以問我唷" + br + "(ゝ∀･)";
                    break;
            }
            return msg;
        }

        public static string Self_Introduction(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "作者介紹":
                    msg = "安安 你好 我是作者李明賢 目前是義守資工大四的學生 :D" + br +
                        "如果遇到任何問題可以直接留言給粉絲團" + br +
                        "也可以寄信給我 joey5566123@gmail.com" + br +
                        "٩(｡・ω・｡)﻿و";
                    break;
                case "軟體介紹":
                    msg = "你好 我是義守萬事通" + br +
                        "歡迎多問我問題 ε٩(๑> ₃ <)۶з" + br +
                        "我是在作者某天靈光乍現 突然想寫聊天機器人" + br +
                        "於是就花了一些時間完成整個架構" + br +
                        "後台伺服器的訊息傳入、訊息回傳是使用C#" + br +
                        "在我身上的語意分析是使用微軟的LUIS";
                    break;
                case "協助者介紹":
                    msg = "感謝我的同學協助我擴增剛開始的語句庫以及開發期間的測試" + br +
                        "感謝名單：Jimmy、Andy、90、冠諺" + br +
                        "｡:.ﾟヽ(*´∀`)ﾉﾟ.:｡";
                    break;
                case "BOT年齡":
                    msg = "身為一個機器人是沒有年齡可言的" + br +
                        "థ౪థ";
                    break;
                case "功能介紹":
                    msg = "有任何問題直接問我就可以了" + br +
                        "目前會回答的：客運、學餐、各單位介紹、各大樓介紹等等" + br +
                        "歡迎多嘗試一些問題唷";
                    break;
                case "馬大大介紹":
                    msg = "Adr、馬大大、馬聖豪，為義守管家的開發者" + br +
                        "他的義守管家及問卷機器人很實用哦" + br +
                        "是位實力超強的神人" + br +
                        "DCARD上詳細介紹：https://goo.gl/nyM4HC " + br +
                        "義守管家：http://isu.30cm.tw/";
                    break;
                case "SIRI":
                    msg = "我跟SIRI不一樣唷，SIRI比我聰明" + br +
                        "他還可以語音對話，我只會回文字" + br +
                        "他知道的事情比我還多(´;ω;`)";
                    break;
                case "開源":
                    msg = "開源的部份牽扯到微軟相關的帳號設定" + br +
                        "但還是歡迎有人繼續維護下去" + br +
                        "有需要程式碼的話請寄信與我聯絡" + br +
                        "joey5566123@gmail.com";
                    break;
            }
            return msg;
        }

        public static string Administrative_Introduction(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "課外活動組":
                    msg = message + "位於行政大樓1樓，大門進去之後的右邊" + br +
                        message + "主要辦理：\"社團\"、\"學生會\"等相關事情" + br +
                        "https://goo.gl/kpw4FM";
                    break;
                case "教官室":
                    msg = message + "位於綜教大樓2樓，中間樓梯上去之後的左邊" + br +
                        message + "主要辦理：\"學生獎懲\"、\"校園安全\"等相關事情" + br +
                        "https://goo.gl/v7HPjy";
                    break;
                case "註冊組":
                    msg = message + "位於行政大樓1樓，大門進去之後的右前方" + br +
                        message + "主要辦理：\"成績\"、\"註冊\"等相關事情" + br +
                        "https://goo.gl/6J7c1o";
                    break;
                case "課務組":
                    msg = message + "位於行政大樓1樓，大門進去之後的左前方" + br +
                        message + "主要辦理：\"選課\"、\"學分\"、\"課程規劃\"等相關事情" + br +
                        "課務組電話：(07)657-7711 轉 2122~2127" + br +
                        "https://goo.gl/LX1Lma";
                    break;
                case "出納組":
                    msg = message + "位於行政大樓1樓，大門進去之後的左邊" + br +
                        message + "主要辦理：\"繳費\"、\"學雜費業務\"等相關事情" + br +
                        "https://goo.gl/Qup9HS";
                    break;
                case "服教組":
                    msg = message + "位於行政大樓1樓，大門進去之後往右邊直走到底的右方" + br +
                        message + "主要辦理：\"服務教育\"等相關事情" + br +
                        "https://goo.gl/91t2tv";
                    break;
                case "生輔組":
                    msg = message + "位於行政大樓1樓，大門進去之後往右邊直走到底的右方" + br +
                        message + "主要辦理：\"補助金\"、\"就學貸款\"等相關事情" + br +
                        "https://goo.gl/7zGVK4";
                    break;
                case "圖資處":
                    msg = message + "位於科技大樓4樓，電梯出去之後的左邊" + br +
                        message + "主要辦理：\"資訊服務\"、\"網路服務\"等相關事情" + br +
                        "https://goo.gl/fG4Pmj";
                    break;
                case "安全組":
                    msg = message + "位於行政大樓1樓，大門就去之後的左邊直走即可看到" + br +
                        message + "主要辦理：\"汽、機車停車證\"等相關事情" + br +
                        "https://goo.gl/5NisrE";
                    break;
            }
            return msg;
        }
    }
}