namespace Bot_Application2.Answer_Message
{
    public class Question_Message
    {
        public static string Registration_Section(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "學生證":
                    msg = "經簽署學生證個資同意書者，學生證為記名學生卡，遺失或毀損作業如下：" + br +
                        "(1)學生證遺失或人為毀損，需先至一卡通股份有限公司網頁掛失後，至註冊組申請補發。" + br +
                        "-\t掛失後請到註冊組6號窗口填寫申請表(在校生)" + br +
                        "-\t出納組繳費200元" + br +
                        "-\t繳回申請表至註冊組，等待3個工作天後至註冊組領取新證" + br +
                        "(2)非人為毀損經一卡通股份有限公司確認者，則予以核發新卡。" + br +
                        "(3)其他相關訊息亦可參考註冊組「數位學生證專區」。 https://goo.gl/383dQ2 ";
                    break;
                case "成績單":
                    msg = "成績單申請步驟如下:" + br +
                        "(1)請到註冊組6號窗口填寫申請表(在校生or畢業生)" + br +
                        "(2)至出納組繳費20元" + br +
                        "(3)繳回申請表及繳費收據至註冊組領取成績單";
                    break;
                case "學期成績":
                    msg = "上、下學期的學期成績通常在期末考後的兩週內會公布在應用資訊系統唷";
                    break;
                case "學生證蓋章":
                    msg = "請在每學期開學後的三天內到\"註冊組\"蓋章";
                    break;
                case "註冊":
                    msg = "請在9/4(一)前完成繳費即可完成註冊" + br +
                        "就貸生請於8/23(三)前將完成銀行對保後，至應用資訊系統填寫就貸申請" + br +
                        "並將台灣銀行就貸申請書郵寄至本校生活輔導組即完成註冊" + br +
                        "更多詳情請參考此網址：" + br +
                        "http://www2.isu.edu.tw/upload/03/2/news/postfile_104045.pdf";
                    break;
                case "繳費單":
                    msg = "繳費單如果遺失了" + br +
                        "可以上應用資訊系統自行列印哦ヽ(・×・´)ゞ";
                    break;
                case "期末成績":
                    msg = "期末成績通常會在期末考後的一週內" + br +
                        "由各老師決定要不要把期末成績放在MOODLE" + br +
                        "如果老師沒公布成績請寫信或打電話至系辦詢問";
                    break;
                case "開學日期":
                    msg = "106-1的開學日期為9/11(一)，不要忘記來上課嘿(ﾟ∀ﾟ)";
                    break;
            }
            return msg;
        }

        public static string Curriculum_Section(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "選課時間":
                    msg = "106-1選課時程：" + br +
                        "一、完成期中、期末問卷100%優先選課時間：" + br +
                        "-\t四年級、碩二及博二：8 月 22 日(二) 9：00 起至 24：00 止" + br +
                        "-\t三年級：8 月 23 日(三) 9：00 起至 24：00 止" + br +
                        "-\t二年級：8 月 24 日(四) 9：00 起至 24：00 止(包含體育必修課程)" + br +
                        "二、一般選課時程" + br +
                        "\t◎第一階段：可選日間本院系本年級、通識博雅、軍訓課程(二年級包含體育必修課程)" + br +
                        "\t 選課時間：8 月 28 日(一) 9：00 起至 24：00 止" + br +
                        "\t◎第二階段：可選日間本院系跨年級、通識博雅、軍訓課程之科目" + br +
                        "\t 選課時間：8 月 29 日(二) 9：00 起至 24：00 止" + br +
                        "\t◎第三階段：可選日間所有課程" + br +
                        "\t 選課時間：8 月 30 日(三) 9：00 起至 24：00 止" + br +
                        "\t◎第四階段：可選日間及進修所有課程(不含進修通識博雅課程選課人數未達 15 人之課程)" + br +
                        "\t 選課時間：自 8 月 31 日(四)9:00 起至 9 月 3 日(日) 24：00 止" + br +
                        "公告網址：https://goo.gl/pYmJVb";
                    break;
                case "通識":
                    msg = "每學期至多可修習二門通識博雅課程" + br +
                        "每門2學分，至少需修習12學分始可畢業" + br +
                        "超過之學分是否計入畢業學分數由各系自行認定" + br +
                        "公告網址：https://goo.gl/rnT9fE";
                    break;
                case "學分":
                    msg = "學分的相關問題請到課務組詢問唷" + br +
                        "也歡迎打電話至課務組詢問" + br +
                        "電話：(07)657-7711 轉 2122~2127";
                    break;
                case "行事曆":
                    msg = "106學年的行事曆：https://goo.gl/FdshjH";
                    break;
                case "畢業門檻":
                    msg = "各系畢業門檻跟學分相關規定請詢問各系辦~" + br +
                        "請參考此網址：https://goo.gl/K7f3FD 並點選自己的系，找到自己系上的修課計畫表";
                    break;
                case "選課":
                    msg = "選課請到應用資訊系統 " + br +
                        "DCARD選課教學（包含如何查詢課程資料）：" + br + " https://goo.gl/LExoY2 " + br +
                        "學校課務組公告（包含選課時間與其他說明與注意事項）：" + br + " https://goo.gl/pYmJVb";
                    break;
                case "選修":
                    msg = "選修的相關規定請詢問\"各系辦\"或到\"課務組\"詢問" + br +
                        "歡迎打電話至課務組詢問" + br +
                        "電話：(07)657-7711 轉 2122~2127";
                    break;
                case "借教室":
                    msg = "借教室請至課務組詢問";
                    break;
                case "停修":
                    msg = "想要停修請在公告停修的期間，於應用資訊系統進行停修" + br +
                        "有任何問題歡迎打電話至課務組詢問" + br +
                        "電話：(07)657-7711 轉 2122~2127";
                    break;
                case "加退選":
                    msg = "9 月 11 日(一) 9：00 起至 09 月 17 日(日) 24：00 止可以進行加退選唷" + br +
                        "公告網址：https://goo.gl/pYmJVb";
                    break;
                case "重修":
                    msg = "重修只需要在有開該堂課的學期" + br +
                        "於選課期間至應用資訊系統選課即可" + br +
                        "如果有任何問題，歡迎打電話至課務組詢問" + br +
                        "電話：(07)657-7711 轉 2122~2127";
                    break;
                case "三二":
                    msg = "三二為該學期的學期成績中" + br +
                        "未通過與檢定未通過科目之學分數" + br +
                        "達修習學分總數三分之二(含)以上" + br +
                        "即稱為三二" + br +
                        "只要連續兩學期達到三二的狀態" + br +
                        "應予退學";
                    break;
                case "退學":
                    msg = "只要連續兩學期達到三二的狀態，應予退學" + br ;
                    break;
                case "二一":
                    msg = "目前學校已經沒有二一的退學規定囉，已經都是雙三二了";
                    break;
                case "上課時間表":
                    msg = "學校的日間部上課時間表 " + br +
                        "http://netreg.isu.edu.tw/wapp/wap_doc/day.htm";
                    break;
            }
            return msg;
        }

        public static string Life_Counseling_Section(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";
            switch (message)
            {
                case "就學貸款":
                    msg = "請參考生輔組就學貸款的網頁 https://goo.gl/6keWm7" ;
                    break;
                case "請假單":
                    msg = "請參考生輔組學生請假的網頁 https://goo.gl/6CjfSp";
                    break;
                case "請假":
                    msg = "請參考生輔組學生請假的網頁 https://goo.gl/6CjfSp";
                    break;
            }
            return msg;
        }

        public static string Security_Section(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "停車證":
                    msg = "請參考安全組的公告" + br +
                        "http://www.isu.edu.tw/upload/24/2/news/postfile_103689.pdf";
                    break;
                case "沒帶學生證":
                    msg = "騎乘機車出學校，如果沒攜帶學生證，無法嗶卡。" + br +
                        "可以使用行照於嗶卡處交給工作人員，並報出學號，即可通行";
                    break;
                case "借安全帽":
                    msg = "如果需要借用安全帽可至校門口的 警衛室 填寫資料借用";
                    break;
                case "停車場":
                    msg = "目前本部的機車停車場有3處：" + br +
                        "第一立體停車場、第二停車場、二宿停車場" + br +
                        "汽車停車場有4處：" + br +
                        "第一停車場、綜合教學大樓停車場、二宿停車場、國際學院停車場" + br +
                        "請參考公告：" + br +
                        "http://www.isu.edu.tw/upload/24/2/news/postfile_103689.pdf";
                    break;
            }
            return msg;
        }

        public static string Service_Education_Section(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "服教心得":
                    msg = "服教心得請確實填寫哦 請不要抄襲 內容不管是正面或是負面都可以填寫" + br +
                        "請於公告時間內完成心得填寫，避免再次被當掉" + br +
                        "如果服務教育不小心被當掉" + br +
                        "可於重修時申請已完成的部份進行抵免" + br +
                        "可以更快完成重修" + br + "d(`･∀･)b";
                    break;
                case "服務教育":
                    msg = "101-104學年學生 服教課程(一)" + br +
                        "https://goo.gl/Pf89dn " + br +
                        "101-104學年學生 服教課程(二)" + br +
                        "https://goo.gl/gY9HJ6 " + br +
                        "105學年以後入學學生 服教課程" +
                        "https://goo.gl/bbiqJf";
                    break;
            }
            return msg;
        }

        public static string Information_Introduction(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";

            switch (message)
            {
                case "還書":
                    msg = "如果需要還書，只需要到圖書館即可還書。" + br +
                        "如果忘記還書導致愈期，可能需要繳交愈期費用哦";
                    break;
            }
            return msg;
        }

        public static string Student_Accommodation_Section(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";
            switch (message)
            {
                case "入宿日期":
                    msg = "106-1的入宿日期是在9/9、10號，也就是開學前的周末" + br +
                        "請參考行事曆：https://goo.gl/79CHge";
                    break;
                case "宿舍網路":
                    msg = "1. 星期一至五00:00~12:00限制遊戲登入動作與P2P傳輸" + br +
                        "2. 例假日與國定假日為00:00~07:00" + br +
                        "3. 每日流量限制5G(上傳+下載)，超過將限速64Kb/s (每日00:00重置)" + br +
                        "其餘詳細介紹：" + br +
                        "https://goo.gl/4XAUvq";
                    break;
            }
            return msg;
        }

        public static string Accounting_Section(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";
            switch (message)
            {
                case "學費":
                    msg = "請參考會計處網頁：http://www2.isu.edu.tw/site/20/13";
                    break;
            }
            return msg;
        }

        public static string Military_Training_Room(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";
            switch (message)
            {
                case "教官":
                    msg = "教官介紹" + br +
                        "https://goo.gl/rVFb79";
                    break;
            }
            return msg;
        }

        public static string Division_Of_Continuing_Education(string message, string br)
        {
            string msg = "關於此問題的回答" + br + "機器人有點錯誤٩(ŏ﹏ŏ、)۶" + br + "將盡快修復" + br + "歡迎詢問其他問題";
            switch (message)
            {
                case "進修部介紹":
                    msg = "進修部網頁：" + br +
                        "http://www.isu.edu.tw/interface/overview.php?dept_mno=99";
                    break;
            }

            return msg;
        }

    }
}